using Simul.Models;
using System.Collections.Generic;
using System.Linq;

namespace Simul.Controllers
{
    public class JobMarketController
    {
        static JobMarketController() { }
        public static JobMarketController Instance { get; } = new JobMarketController();

        public List<JobMarket> Markets { get; set; }

        private JobMarketController()
        {
            Markets = new List<JobMarket>();
        }

        public JobMarket GetMarketOfCountry(string countryName)
        {
            return Markets.First(x => x.Country.Name == countryName);
        }

        public (JobMarket jobMarket, JobOffer jobOffer) FindBestJob(Country country)
        {
            var bestOffer = new JobOffer(null, decimal.MinValue);
            JobMarket bestJobMarketOfOffer = null;

            foreach (JobMarket market in Markets.Where(x => x.Country == country))
            {
                var bestOfferOfThisMarket = market.Offers.OrderByDescending(x => x.Salary).FirstOrDefault();
                if (bestOfferOfThisMarket != null && bestOfferOfThisMarket.Salary > bestOffer.Salary)
                {
                    bestOffer = bestOfferOfThisMarket;
                    bestJobMarketOfOffer = market;
                }
            }

            if (bestJobMarketOfOffer == null || bestOffer == null)
            {
                return (null, null);
            }

            return (bestJobMarketOfOffer, bestOffer);
        }
    }
}
