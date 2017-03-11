using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class JobOffer
    {
        public JobMarket market { get; set; }
        public Company employer { get; set; }
        public decimal salary { get; set; }

        public JobOffer(JobMarket market, Company employer, decimal salary)
        {
            this.market = market;
            this.employer = employer;
            this.salary = salary;
        }
    }
}
