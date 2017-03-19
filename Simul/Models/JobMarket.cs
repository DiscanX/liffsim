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
        public List<JobOffer> offers { get; set; }

        public JobMarket(string name, List<JobOffer> offers)
        {
            this.name = name;
            this.offers = offers;
        }
    }
}
