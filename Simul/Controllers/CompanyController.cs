using Simul.Helpers;
using Simul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Controllers
{
    public class CompanyController
    {
        static CompanyController() { }
        private static CompanyController instance = new CompanyController();
        public static CompanyController Instance { get { return instance; } }

        public List<Company> companies { get; set; }

        private CompanyController()
        {
            companies = new List<Company>();
            //Where ReadResources()[0] is wheat (see resources.xml)
            companies.Add(new Company("Sample Company", ContentReader.GetResources()[0], 100, new Inventory()));
            companies.Add(new Company("World Company", ContentReader.GetResources()[1], 10000, new Inventory()));
        }
    }
}
