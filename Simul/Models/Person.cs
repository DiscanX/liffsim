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
        public ICompany employer { get; set; }
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
            if(employer != null)
            {
                throw new Exception("Already has an employer. Needs to resign first");
            }

            if(country != jobMarket.country)
            {
                throw new Exception("Can't take job from another country");
            }

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

            if(country != employer.country)
            {
                throw new Exception("Can't work for another country");
            }

            employer.employees.Remove(this);

            employer = null;
            salary = 0;
            jobStartDay = 0;
            canResign = false;
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

        public void Eat(Resource resource, int quantity = 1)
        {
            int quantityAfterEating = inventory.stocks[resource] - quantity;

            if(!resource.edible)
            {
                throw new Exception("This resource can't be eaten");
            }

            if(quantityAfterEating < 0)
            {
                throw new Exception("Quantity can't go below zero");
            }

            Energy += Constants.ENERGY_GAINED_AFTER_EATING * quantity;
            inventory.stocks[resource] = quantityAfterEating;
        }

        public void EatUntilFull()
        {
            if (energy + Constants.ENERGY_GAINED_AFTER_EATING <= Constants.MAX_ENERGY)
            {
                var edibleResources = inventory.stocks.Where(x => x.Key.edible && x.Value > 0);
                int quantityToEat = Math.Min((Constants.MAX_ENERGY - energy) / Constants.ENERGY_GAINED_AFTER_EATING, edibleResources.Count());

                for (int i = 0; i < edibleResources.Count(); i++)
                {
                    var edibleResource = edibleResources.ElementAt(i);

                    if (edibleResource.Value >= quantityToEat)
                    {
                        Eat(edibleResource.Key, quantityToEat);
                        break;
                    }
                    else
                    {
                        Eat(edibleResource.Key, edibleResource.Value);
                        quantityToEat -= edibleResource.Value;
                    }
                }
            }
        }

        private void IncrementStrength()
        {
            strength = Calculator.CalculateStrengthIncrement(strength);
        }

        private void IncrementSkill(Skill skill)
        {
            skillset.skills[skill] = Calculator.CalculateSkillIncrement(skillset.skills[skill]);
        }

        public string DisplayCurrentEmployer()
        {
            return employer == null ? "None" : employer.name;
        }

        public bool CanWork()
        {
            return employer != null && energy - Constants.ENERGY_LOST_WORKING >= 0 && !alreadyWorked;
        }

        public bool CanTrain()
        {
            return energy - Constants.ENERGY_LOST_TRAINING >= 0 && !alreadyTrained;
        }
    }
}
