﻿using Simul.Helpers;
using System.Collections.Generic;

namespace Simul.Models
{
    public class TertiaryResource : Resource
    {
        public Dictionary<Resource, int> Requirements { get; set; }

        public TertiaryResource(ResourceName name, Skill improvedSkill, int productionCost, Dictionary<Resource, int> requirements, bool edible) : base(name, improvedSkill, productionCost, edible)
        {
            Requirements = requirements;
        }

        public override Dictionary<Resource, int> GetRequirements()
        {
            return Requirements;
        }
    }
}
