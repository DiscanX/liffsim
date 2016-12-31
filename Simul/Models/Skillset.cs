using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Skillset
    {
        public Dictionary<Skill, float> skills { get; set; }

        public Skillset()
        {
            skills = new Dictionary<Skill, float>();

            foreach(Skill skill in ContentReader.GetSkills())
            {
                skills.Add(skill, 1);
            }
        }

        public Skillset(Dictionary<Skill, float> skills)
        {
            this.skills = skills;
        }
    }
}
