using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
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
            if (strength <= 10)
            {
                strength++;
            }
            else if (strength <= 50)
            {
                strength += 0.5f;
            }
            else if (strength <= 100)
            {
                strength += 0.25f;
            }
            else if (strength <= 200)
            {
                strength += 0.10f;
            }
            else
            {
                strength += 0.05f;
            }
        }

        private void IncrementSkill(Skill skill)
        {
            if (skillset.skills[skill] <= 1)
            {
                skillset.skills[skill]++;
            }
            else if (skillset.skills[skill] <= 5)
            {
                skillset.skills[skill] += 0.5f;
            }
            else if (skillset.skills[skill] <= 10)
            {
                skillset.skills[skill] += 0.25f;
            }
            else if (skillset.skills[skill] <= 20)
            {
                skillset.skills[skill] += 0.10f;
            }
            else
            {
                skillset.skills[skill] += 0.05f;
            }
        }
    }
}
