using System.Linq;

namespace Simul.Models
{
    public static class Calculator
    {
        public static decimal CalculateSkillIncrement(decimal skill)
        {
            if (skill <= 1)
            {
                skill++;
            }
            else if (skill <= 5)
            {
                skill += 0.5m;
            }
            else if (skill <= 10)
            {
                skill += 0.25m;
            }
            else if (skill <= 20)
            {
                skill += 0.10m;
            }
            else
            {
                skill += 0.05m;
            }

            return skill;
        }

        public static decimal CalculateStrengthIncrement(decimal strength)
        {
            if (strength <= 10)
            {
                strength++;
            }
            else if (strength <= 50)
            {
                strength += 0.5m;
            }
            else if (strength <= 100)
            {
                strength += 0.25m;
            }
            else if (strength <= 200)
            {
                strength += 0.10m;
            }
            else
            {
                strength += 0.05m;
            }

            return strength;
        }

        public static decimal CalculateProductionProgress(ICompany company, IPerson employee)
        {
            var skill = employee.Skillset.Skills.First(x => x.Key == company.ProducedResource.ImprovedSkill);
            return skill.Value;
        }
    }
}
