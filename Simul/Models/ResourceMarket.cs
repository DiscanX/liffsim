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

        public void AddOffer(ResourceOffer offer)
        {
            if (name != offer.market.name)
            {
                throw new Exception("The market is not the good one for the offer");
            }

            offers.Add(offer);
        }

        public void DeleteOffer(ResourceOffer offer)
        {
            if (name != offer.market.name)
            {
                throw new Exception("The market is not the good one for the offer");
            }

            ResourceOffer foundOffer = offers.Find(x => x == offer);

            if(foundOffer == null)
            {
                throw new Exception("The market does not own the offer");
            }

            offers.Remove(foundOffer);
        }
    }
}
