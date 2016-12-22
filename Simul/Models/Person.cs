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
        public int energy { get; set; }
        public Contract contract { get; set; }
        public Skillset skillset { get; set; }

        public Person(string name, decimal money, Skillset skillset,  Inventory inventory, int energy, float strength) : base(name, money, inventory)
        {
            this.skillset = skillset;
            this.energy = energy;
            this.strength = strength;
        }

        public string DisplayStrength()
        {
            return strength.ToString();
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
            if (energy - 10 < 0)
            {
                throw new Exception("Energy can't go below zero");
            }

            contract.company.Produce(contract);
            IncrementSkill(contract.company.producedResource.improvedSkill);
            energy -= 10;
        }

        public void Train()
        {
            IncrementStrength();
        }

        private void IncrementStrength()
        {
            strength += Calculator.IncrementStrength(strength);
        }

        private void IncrementSkill(Skill skill)
        {
            skillset.skills[skill] += Calculator.IncrementSkill(skillset.skills[skill]);
        }
    }
}
