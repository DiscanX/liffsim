using Simul.Helpers;
using System.Collections.Generic;

namespace Simul.Models
{
    public class Skillset
    {
        public Dictionary<Skill, float> Skills { get; set; }

        public Skillset()
        {
            Skills = new Dictionary<Skill, float>();

            foreach (Skill skill in ContentReader.GetSkills())
            {
                Skills.Add(skill, 1);
            }
        }

        public Skillset(Dictionary<Skill, float> skills)
        {
            Skills = skills;
        }
    }
}
