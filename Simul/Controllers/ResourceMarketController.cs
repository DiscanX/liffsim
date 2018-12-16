using Simul.Helpers;
using Simul.Models;
using System;
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

        public List<Tuple<ResourceOffer, int>> GetBestOffersOfMarket(ResourceMarket resourceMarket, eResourceName resourceName, int quantity)
        {
            var offersToReturn = new List<Tuple<ResourceOffer, int>>();
            var allBestOffers = resourceMarket.Offers.Where(x => x.Resource.Name == resourceName).OrderBy(x => x.UnitPrice).ToList();

            for (int i = 0; i < allBestOffers.Count(); i++)
            {
                if (allBestOffers[i].Quantity > quantity)
                {
                    offersToReturn.Add(Tuple.Create(allBestOffers[i], quantity));
                    break;
                }
                else
                {
                    quantity -= allBestOffers[i].Quantity;
                    offersToReturn.Add(Tuple.Create(allBestOffers[i], allBestOffers[i].Quantity));
                }
            }

            return offersToReturn;
        }
    }
}
