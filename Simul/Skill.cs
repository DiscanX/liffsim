using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Skill
    {
        public SkillType skillType { get; set; }

        public Skill(SkillType skillType)
        {
            this.skillType = skillType;
        }
    }
}
