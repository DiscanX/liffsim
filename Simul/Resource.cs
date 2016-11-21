using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Resource
    {
        public ResourceType resourceType { get; set; }
        public Skill improvedSkill { get; set; }

        public Resource(ResourceType resourceType, Skill improvedSkill)
        {
            this.resourceType = resourceType;
            this.improvedSkill = improvedSkill;
        }
    }
}
