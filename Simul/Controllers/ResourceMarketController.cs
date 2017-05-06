using Simul.Helpers;
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
        static ResourceMarketController() { }
        private static ResourceMarketController instance = new ResourceMarketController();
        public static ResourceMarketController Instance { get { return instance; } }

        public List<ResourceMarket> markets { get; set; }

        private ResourceMarketController()
        {
            markets = new List<ResourceMarket>();
        }

        public ResourceMarket GetMarketOfCountry(string countryName)
        {
            return markets.First(x => x.country.name == countryName);
        }

        public List<Tuple<ResourceOffer, int>> GetBestOffersOfMarket(ResourceMarket resourceMarket, eResourceName resourceName, int quantity)
        {
            var offersToReturn = new List<Tuple<ResourceOffer, int>>();
            var allBestOffers = resourceMarket.offers.Where(x => x.resource.name == resourceName).OrderBy(x => x.unitPrice).ToList();

            for(int i = 0; i < allBestOffers.Count(); i++)
            {
                if (allBestOffers[i].quantity > quantity)
                {
                    offersToReturn.Add(Tuple.Create(allBestOffers[i], quantity));
                    break;
                }
                else
                {
                    quantity -= allBestOffers[i].quantity;
                    offersToReturn.Add(Tuple.Create(allBestOffers[i], allBestOffers[i].quantity));
                }
            }

            return offersToReturn;
        }
    }
}
