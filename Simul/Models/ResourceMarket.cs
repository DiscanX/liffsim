using System.Collections.Generic;

namespace Simul.Models
{
    public class ResourceMarket
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public List<ResourceOffer> Offers { get; set; }

        public ResourceMarket(string name, Country country, List<ResourceOffer> offers)
        {
            Name = name;
            Country = country;
            Offers = offers;
        }
    }
}
