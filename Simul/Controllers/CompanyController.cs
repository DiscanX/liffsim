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

        public List<ICompany> companies { get; set; }

        private CompanyController()
        {
            companies = new List<ICompany>();
        }
    }
}
