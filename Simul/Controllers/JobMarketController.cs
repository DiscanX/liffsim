using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Controllers
{
    public class JobMarketController
    {
        public List<JobMarket> markets { get; set; }

        public JobMarketController()
        {
            markets = new List<JobMarket>();
            markets.Add(new JobMarket("Main job market", new List<JobOffer>()));
        }
    }
}
