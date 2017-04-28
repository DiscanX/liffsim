using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class TertiaryResource : Resource
    {
        public Dictionary<Resource, int> requirements { get; set; }

        public TertiaryResource(eResourceName name, Skill improvedSkill, int productionCost, Dictionary<Resource, int> requirements, bool edible) : base(name, improvedSkill, productionCost, edible)
        {
            this.requirements = requirements;
        }

        public override Dictionary<Resource, int> GetRequirements()
        {
            return requirements;
        }
    }
}
