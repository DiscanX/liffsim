using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Company : Player, ICompany
    {
        public Resource producedResource { get; set; }
        public float progress { get; set; }
        public List<IPerson> employees { get; set; }

        public Company(string name, Country country, Resource producedResource, decimal money, Inventory inventory, bool isHumanControlled = false) : base(name, country, money, inventory, isHumanControlled)
        {
            this.producedResource = producedResource;
            employees = new List<IPerson>();
        }

        private eWorkResult CanWork(IPerson employee)
        {
            Dictionary<Resource, int> requirements = producedResource.GetRequirements();
            if (requirements == null)
            {
                return eWorkResult.Success;
            }

            foreach (KeyValuePair<Resource, int> requirement in requirements)
            {
                float nbrProducedUnits = Calculator.CalculateProductionProgress(this, employee) / producedResource.productionCost;
                int nbrResourcesRequired = (int)Math.Ceiling(nbrProducedUnits * requirement.Value);
                int stockAfterProduction = inventory.stocks[requirement.Key] - nbrResourcesRequired;

                if (stockAfterProduction < 0)
                {
                    return eWorkResult.FailureStocksTooLow;
                }
            }

            return eWorkResult.Success;
        }

        public eWorkResult Produce(IPerson employee, decimal salary)
        {
            eWorkResult workResult = CanWork(employee);
            if (workResult != eWorkResult.Success)
            {
                return workResult;
            }

            float nbrProducedUnits = Calculator.CalculateProductionProgress(this, employee) / producedResource.productionCost;

            Dictionary<Resource, int> requirements = producedResource.GetRequirements();
            if (requirements != null)
            {
                foreach (KeyValuePair<Resource, int> requirement in requirements)
                {
                    int nbrResourcesRequired = (int)Math.Ceiling(nbrProducedUnits * requirement.Value);
                    int stockAfterProduction = inventory.stocks[requirement.Key] - nbrResourcesRequired;

                    inventory.stocks[requirement.Key] = stockAfterProduction;
                }
            }

            progress += nbrProducedUnits;

            if (progress >= 1)
            {
                inventory.stocks[producedResource] += (int)progress;
                progress %= 1;
            }

            workResult = PayEmployee(employee, salary);
            return workResult;
        }

        private eWorkResult PayEmployee(IPerson employee, decimal salary)
        {
            decimal moneyAfterPay = Money - salary;

            if (moneyAfterPay < 0)
            {
                return eWorkResult.FailureNotEnoughMoney;
            }

            Money = moneyAfterPay;
            employee.Money += salary;
            return eWorkResult.Success;
        }
    }
}
