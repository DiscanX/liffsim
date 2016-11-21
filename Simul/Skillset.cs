using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Skillset
    {
        public Dictionary<Skill, float> skills { get; set; }

        public Skillset(Dictionary<Skill, float> skills)
        {
            this.skills = skills;
        }
    }
}
