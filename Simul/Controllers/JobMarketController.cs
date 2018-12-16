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
    }
}
