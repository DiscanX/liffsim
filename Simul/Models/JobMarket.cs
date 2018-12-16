using System.Collections.Generic;

namespace Simul.Models
{
    public class JobMarket
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public List<JobOffer> Offers { get; set; }

        public JobMarket(string name, Country country, List<JobOffer> offers)
        {
            Name = name;
            Country = country;
            Offers = offers;
        }
    }
}
