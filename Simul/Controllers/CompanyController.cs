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
        public List<Company> companies { get; set; }

        public CompanyController()
        {
            companies = new List<Company>();
            //Where ReadResources()[0] is wheat (see resources.xml)
            companies.Add(new Company("Sample Company", ContentReader.GetResources()[0], 100, new Inventory()));
        }
    }
}
