using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class SecondaryResource : Resource
    {
        public Dictionary<Resource, int> requirements { get; set; }

        public SecondaryResource(eResourceName name, Skill improvedSkill, int productionCost, Dictionary<Resource, int> requirements) : base(name, improvedSkill, productionCost)
        {
            this.requirements = requirements;
        }

        public override Dictionary<Resource, int> GetRequirements()
        {
            return requirements;
        }
    }
}
