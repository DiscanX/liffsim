using Simul.Helpers;
using System.Collections.Generic;

namespace Simul.Models
{
    public abstract class Resource
    {
        public eResourceName Name { get; set; }
        public Skill ImprovedSkill { get; set; }
        public int ProductionCost { get; set; }
        public bool Edible { get; set; }

        internal Resource(eResourceName name, Skill improvedSkill, int productionCost, bool edible)
        {
            Name = name;
            ImprovedSkill = improvedSkill;
            ProductionCost = productionCost;
            Edible = edible;
        }

        public virtual Dictionary<Resource, int> GetRequirements()
        {
            //AKA no requirements
            return null;
        }
    }
}
