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

        public Person(string name, decimal money, Skillset skillset,  Inventory inventory, float strength) : base(name, money, inventory)
        {
            this.skillset = skillset;
            this.strength = strength;
        }

        public void Work()
        {
            contract.company.Produce(contract);
            IncrementSkill(contract.company.producedResource.improvedSkill);
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
