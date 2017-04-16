using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Controllers
{
    public class CountryController
    {
        static CountryController() { }
        private static CountryController instance = new CountryController();
        public static CountryController Instance { get { return instance; } }

        public List<Country> countries { get; set; }

        private CountryController()
        {
            countries = new List<Country>();
        }
    }
}
