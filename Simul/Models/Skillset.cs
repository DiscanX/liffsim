using Simul.Helpers;
using System.Collections.Generic;

namespace Simul.Models
{
    public class Skillset
    {
        public Dictionary<Skill, decimal> Skills { get; set; }

        public Skillset()
        {
            Skills = new Dictionary<Skill, decimal>();

            foreach (Skill skill in ContentReader.GetSkills())
            {
                Skills.Add(skill, 1);
            }
        }

        public Skillset(Dictionary<Skill, decimal> skills)
        {
            Skills = skills;
        }
    }
}
