using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class ResourceMarket
    {
        public string name { get; set; }
        public List<ResourceOffer> offers { get; set; }

        public ResourceMarket(string name, List<ResourceOffer> offers)
        {
            this.name = name;
            this.offers = offers;
        }
    }
}
