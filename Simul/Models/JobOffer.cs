using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class JobOffer
    {
        public ICompany employer { get; set; }
        public decimal salary { get; set; }

        public JobOffer(ICompany employer, decimal salary)
        {
            this.employer = employer;
            this.salary = salary;
        }
    }
}
