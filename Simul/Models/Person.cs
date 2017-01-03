using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Person : Player
    {
        public float strength { get; set; }
        public Contract contract { get; set; }
        public Skillset skillset { get; set; }
        public bool alreadyWorked { get; set; }
        public bool alreadyTrained { get; set; }
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0) { throw new Exception("Energy can't go below zero"); }
                energy = value > Constants.MAX_ENERGY ? Constants.MAX_ENERGY : value;
            }
        }

        public Person(string name, decimal money, Skillset skillset,  Inventory inventory, int energy, float strength, bool isHumanControlled = false) : base(name, money, inventory, isHumanControlled)
        {
            this.skillset = skillset;
            this.strength = strength;
            Energy = energy;
        }

        public string DisplayProductivity()
        {
            if (contract != null)
            {
                return skillset.skills.First(x => x.Key == contract.company.producedResource.improvedSkill).Value.ToString();
            }
            else
            {
                return skillset.skills.OrderByDescending(x => x.Value).First().Value.ToString();
            }
        }

        public void Work()
        {
            if (alreadyWorked)
            {
                throw new Exception("This person already worked");
            }

            contract.company.Produce(contract);
            IncrementSkill(contract.company.producedResource.improvedSkill);
            Energy -= 10;
            alreadyWorked = true;
        }

        public void Train()
        {
            if(alreadyTrained)
            {
                throw new Exception("This person already trained");
            }

            IncrementStrength();
            Energy -= 5;
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
