using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simul.Helpers;

namespace Simul.Models
{
    public class PrimaryResource : Resource
    {
        public PrimaryResource(eResourceName name, Skill improvedSkill, int productionCost, bool edible) : base(name, improvedSkill, productionCost, edible)
        {

        }
    }
}
