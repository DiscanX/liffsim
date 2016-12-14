using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class JobMarket
    {
        public string name { get; set; }
        private List<JobOffer> offers;

        public JobMarket(string nom, List<JobOffer> offers)
        {
            this.name = name;
            this.offers = offers;
        }

        public void AddOffer(JobOffer offer)
        {
            throw new NotImplementedException();
        }

        public void DeleteOffer(JobOffer offer)
        {
            if (name != offer.market.name)
            {
                throw new Exception("The market is not the good one for the offer");
            }

            JobOffer foundOffer = offers.Find(x => x == offer);

            if (foundOffer == null)
            {
                throw new Exception("The market does not own the offer");
            }

            offers.Remove(foundOffer);
        }
    }
}
