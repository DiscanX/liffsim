using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public abstract class Resource
    {
        public string name { get; set; }
        public Skill improvedSkill { get; set; }
        public int productionCost { get; set; }

        public Resource(string name, Skill improvedSkill, int productionCost)
        {
            this.name = name;
            this.improvedSkill = improvedSkill;
            this.productionCost = productionCost;
        }
    }
}
