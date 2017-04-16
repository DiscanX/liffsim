using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class JobMarket
    {
        public string name { get; set; }
        public Country country { get; set; }
        public List<JobOffer> offers { get; set; }

        public JobMarket(string name, Country country, List<JobOffer> offers)
        {
            this.name = name;
            this.country = country;
            this.offers = offers;
        }
    }
}
