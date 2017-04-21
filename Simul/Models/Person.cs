using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public enum eWorkResult
    {
        Success,
        FailureStocksTooLow,
        FailureNotEnoughMoney
    }

    public class Person : Player, IPerson
    {
        public float strength { get; set; }
        public Company employer { get; set; }
        public decimal salary { get; set; }
        public Skillset skillset { get; set; }
        public bool alreadyWorked { get; set; }
        public bool alreadyTrained { get; set; }
        public bool canResign { get; set; }
        public int jobStartDay { get; set; }
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < Constants.MIN_ENERGY) { throw new Exception("Energy can't go below zero"); }
                energy = value > Constants.MAX_ENERGY ? Constants.MAX_ENERGY : value;
            }
        }

        public Person(string name, Country country, decimal money, Skillset skillset,  Inventory inventory, int energy, float strength, bool isHumanControlled = false) : base(name, country, money, inventory, isHumanControlled)
        {
            this.skillset = skillset;
            this.strength = strength;
            Energy = energy;
        }

        public string DisplayProductivity()
        {
            if (employer != null)
            {
                return skillset.skills.First(x => x.Key == employer.producedResource.improvedSkill).Value.ToString();
            }
            else
            {
                return skillset.skills.OrderByDescending(x => x.Value).First().Value.ToString();
            }
        }

        public float GetCurrentUsedSkillLevel()
        {
            if (employer == null)
            {
                throw new Exception("No current used skill, as there is no current employer");
            }

            return skillset.skills.First(x => x.Key == employer.producedResource.improvedSkill).Value;
        }

        public void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay)
        {
            jobMarket.offers.Remove(jobOffer);
            jobOffer.employer.employees.Add(this);

            employer = jobOffer.employer;
            salary = jobOffer.salary;
            jobStartDay = currentDay;
            canResign = false;
        }

        public eWorkResult Work()
        {
            if (alreadyWorked)
            {
                throw new Exception("This person already worked");
            }

            eWorkResult workResult = employer.Produce(this, salary);
            if (workResult == eWorkResult.Success)
            {
                IncrementSkill(employer.producedResource.improvedSkill);
                Energy -= Constants.ENERGY_LOST_WORKING;
                alreadyWorked = true;
            }
            else
            {
                canResign = true;
            }

            return workResult;
        }

        public void Resign(int currentDay)
        {
            if(employer == null)
            {
                throw new Exception("Can't resign, this person has no employer");
            }

            if(!canResign)
            {
                throw new Exception("This person can't resign (as the value of the attribute canResign is false)");
            }

            employer.employees.Remove(this);

            employer = null;
            salary = 0;
            jobStartDay = 0;
        }

        public void Train()
        {
            if(alreadyTrained)
            {
                throw new Exception("This person already trained");
            }

            IncrementStrength();
            Energy -= Constants.ENERGY_LOST_TRAINING;
            alreadyTrained = true;
        }

        private void IncrementStrength()
        {
            strength = Calculator.CalculateStrengthIncrement(strength);
        }

        private void IncrementSkill(Skill skill)
        {
            skillset.skills[skill] = Calculator.CalculateSkillIncrement(skillset.skills[skill]);
        }
    }
}
