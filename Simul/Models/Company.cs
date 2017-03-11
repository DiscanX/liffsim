using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Company : Player
    {
        public Resource producedResource { get; set; }
        public float progress { get; set; }
        public List<Person> employees { get; set; }

        public Company(string name, Resource producedResource, decimal money, Inventory inventory, bool isHumanControlled = false) : base(name, money, inventory, isHumanControlled)
        {
            this.producedResource = producedResource;
            employees = new List<Person>();
        }

        public void Produce(Person employee, decimal salary)
        {
            float nbrProducedUnits = Calculator.CalculateProductionProgress(this, employee) / producedResource.productionCost;

            Dictionary<Resource, int> requirements = producedResource.GetRequirements();
            if (requirements != null)
            {
                foreach (KeyValuePair<Resource, int> requirement in requirements)
                {
                    int nbrResourcesRequired = (int)Math.Ceiling(nbrProducedUnits * requirement.Value);
                    int stockAfterProduction = inventory.stocks[requirement.Key] - nbrResourcesRequired;

                    if (stockAfterProduction < 0)
                    {
                        throw new Exception("Can't produce resource : one of the required resource stock would go below 0");
                    }

                    inventory.stocks[requirement.Key] = stockAfterProduction;
                }
            }

            progress += nbrProducedUnits;

            if(progress >= 1)
            {
                inventory.stocks[producedResource] += (int)progress;
                progress %= 1;
            }

            PayEmployee(employee, salary);
        }
        
        private void PayEmployee(Person employee, decimal salary)
        {
            decimal moneyAfterPay = Money - salary;

            if(moneyAfterPay < 0)
            {
                throw new Exception("The company doesn't have enough money to pay the employee");
            }

            Money = moneyAfterPay;
            employee.Money += salary;
        }
    }
}
