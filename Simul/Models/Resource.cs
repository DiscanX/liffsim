using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Resource
    {
        public string name { get; set; }
        public ResourceType resourceType { get; set; }
        public Skill improvedSkill { get; set; }

        public Resource(string name, ResourceType resourceType, Skill improvedSkill)
        {
            this.name = name;
            this.resourceType = resourceType;
            this.improvedSkill = improvedSkill;
        }
    }
}
