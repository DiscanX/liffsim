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
        public Country country { get; set; }
        public List<ResourceOffer> offers { get; set; }

        public ResourceMarket(string name, Country country, List<ResourceOffer> offers)
        {
            this.name = name;
            this.country = country;
            this.offers = offers;
        }
    }
}
