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
        static JobMarketController() { }
        private static JobMarketController instance = new JobMarketController();
        public static JobMarketController Instance { get { return instance; } }

        public List<JobMarket> markets { get; set; }

        private JobMarketController()
        {
            markets = new List<JobMarket>();
        }
    }
}
