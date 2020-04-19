using Simul.Helpers;
using System.Collections.Generic;

namespace Simul.Models
{
    public abstract class Resource
    {
        public ResourceName Name { get; set; }
        public Skill ImprovedSkill { get; set; }
        public int ProductionCost { get; set; }
        public bool Edible { get; set; }

        internal Resource(ResourceName name, Skill improvedSkill, int productionCost, bool edible)
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
