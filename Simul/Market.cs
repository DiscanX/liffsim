using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Market
    {
        public string name { get; set; }
        public List<Offer> offers { get; set; }

        public Market(string nom, List<Offer> offers)
        {
            this.name = name;
            this.offers = offers;
        }

        public void DeleteOffer(Offer offer)
        {
            if (name != offer.market.name)
            {
                throw new Exception("Ce marché n'est pas le bon marché pour cette offre");
            }

            Offer foundOffer = offers.Find(x => x == offer);

            if(foundOffer == null)
            {
                throw new Exception("Ce marché ne possède pas cette offre");
            }

            offers.Remove(foundOffer);
        }
    }
}
