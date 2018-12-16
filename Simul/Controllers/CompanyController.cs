using Simul.Models;
using System.Collections.Generic;

namespace Simul.Controllers
{
    public class CompanyController
    {
        static CompanyController() { }
        public static CompanyController Instance { get; } = new CompanyController();
        public List<ICompany> Companies { get; set; }

        private CompanyController()
        {
            Companies = new List<ICompany>();
        }
    }
}
