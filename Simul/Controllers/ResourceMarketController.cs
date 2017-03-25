using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Controllers
{
    public class ResourceMarketController
    {
        static ResourceMarketController() { }
        private static ResourceMarketController instance = new ResourceMarketController();
        public static ResourceMarketController Instance { get { return instance; } }

        public List<ResourceMarket> markets { get; set; }

        private ResourceMarketController()
        {
            markets = new List<ResourceMarket>();
            markets.Add(new ResourceMarket("Main resource market", new List<ResourceOffer>()));
            markets.Add(new ResourceMarket("Secondary resource market", new List<ResourceOffer>()));
        }
    }
}
