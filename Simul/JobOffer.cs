﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class JobOffer
    {
        public JobMarket market { get; set; }

        public JobOffer(JobMarket market)
        {
            this.market = market;
        }
    }
}
