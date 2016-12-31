using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public static class Calculator
    {
        public static float CalculateSkillIncrement(float skill)
        {
            if (skill <= 1)
            {
                skill++;
            }
            else if (skill <= 5)
            {
                skill += 0.5f;
            }
            else if (skill <= 10)
            {
                skill += 0.25f;
            }
            else if (skill <= 20)
            {
                skill += 0.10f;
            }
            else
            {
                skill += 0.05f;
            }

            return skill;
        }

        public static float CalculateStrengthIncrement(float strength)
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

            return strength;
        }

        public static float CalculateProductionProgress(Contract contract)
        {
            KeyValuePair<Skill, float> skill = contract.person.skillset.skills.First(x => x.Key == contract.company.producedResource.improvedSkill);
            return skill.Value;
        }
    }
}
