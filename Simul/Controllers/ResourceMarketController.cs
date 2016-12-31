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
        public List<ResourceMarket> markets { get; set; }

        public ResourceMarketController()
        {
            markets = new List<ResourceMarket>();
            markets.Add(new ResourceMarket("Main resource market", new List<ResourceOffer>()));
        }
    }
}
