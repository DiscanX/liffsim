using Simul.Models;
using System.Collections.Generic;

namespace Simul.Controllers
{
    public class CountryController
    {
        static CountryController() { }
        public static CountryController Instance { get; } = new CountryController();
        public List<Country> Countries { get; set; }

        private CountryController()
        {
            Countries = new List<Country>();
        }
    }
}
