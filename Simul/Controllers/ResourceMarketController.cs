using Simul.Helpers;
using Simul.Models;
using System.Collections.Generic;
using System.Linq;

namespace Simul.Controllers
{
    public class ResourceMarketController
    {
        static ResourceMarketController() { }
        public static ResourceMarketController Instance = new ResourceMarketController();

        public List<ResourceMarket> Markets { get; set; }

        private ResourceMarketController()
        {
            Markets = new List<ResourceMarket>();
        }

        public ResourceMarket GetMarketOfCountry(string countryName)
        {
            return Markets.First(x => x.Country.Name == countryName);
        }

        public static List<(ResourceOffer ressourceOffer, int quantity)> GetBestOffersOfMarket(ResourceMarket resourceMarket, ResourceName resourceName, int quantity)
        {
            var offersToReturn = new List<(ResourceOffer, int)>();
            var allBestOffers = resourceMarket.Offers.Where(x => x.Resource.Name == resourceName).OrderBy(x => x.UnitPrice).ToList();

            for (int i = 0; i < allBestOffers.Count; i++)
            {
                if (allBestOffers[i].Quantity > quantity)
                {
                    offersToReturn.Add((allBestOffers[i], quantity));
                    return offersToReturn;
                }

                quantity -= allBestOffers[i].Quantity;
                offersToReturn.Add((allBestOffers[i], allBestOffers[i].Quantity));
            }

            return offersToReturn;
        }
    }
}
