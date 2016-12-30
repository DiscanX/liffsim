﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class PrimaryResource : Resource
    {
        public PrimaryResource(string name, Skill improvedSkill, int productionCost) : base(name, improvedSkill, productionCost)
        {

        }
    }
}