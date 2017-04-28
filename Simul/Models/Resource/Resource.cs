using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simul.Helpers;

namespace Simul.Models
{
    public abstract class Resource
    {
        public eResourceName name { get; set; }
        public Skill improvedSkill { get; set; }
        public int productionCost { get; set; }
        public bool edible { get; set; }

        internal Resource(eResourceName name, Skill improvedSkill, int productionCost, bool edible)
        {
            this.name = name;
            this.improvedSkill = improvedSkill;
            this.productionCost = productionCost;
            this.edible = edible;
        }

        public virtual Dictionary<Resource, int> GetRequirements()
        {
            //AKA no requirements
            return null;
        }
    }
}
