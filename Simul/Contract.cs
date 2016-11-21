using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Contract
    {
        public Person person { get; set; }
        public Company company { get; set; }
        public decimal salary { get; set; }

        public Contract(Person person, Company company, decimal salary)
        {
            this.person = person;
            this.company = company;
            this.salary = salary;
        }
    }
}
