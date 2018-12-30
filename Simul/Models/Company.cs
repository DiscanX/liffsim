using System;
using System.Collections.Generic;

namespace Simul.Models
{
    public class Company : Player, ICompany
    {
        public Resource ProducedResource { get; set; }
        public float Progress { get; set; }
        public List<IPerson> Employees { get; set; }

        public Company(string name, Country country, Resource producedResource, decimal money, Inventory inventory, bool isHumanControlled = false) : base(name, country, money, inventory, isHumanControlled)
        {
            this.ProducedResource = producedResource;
            Employees = new List<IPerson>();
        }

        private eWorkResult CanWork(IPerson employee)
        {
            var requirements = ProducedResource.GetRequirements();
            if (requirements == null)
            {
                return eWorkResult.Success;
            }

            foreach (KeyValuePair<Resource, int> requirement in requirements)
            {
                var nbrProducedUnits = Calculator.CalculateProductionProgress(this, employee) / ProducedResource.ProductionCost;
                var nbrResourcesRequired = (int)Math.Ceiling(nbrProducedUnits * requirement.Value);
                var stockAfterProduction = Inventory.Stocks[requirement.Key] - nbrResourcesRequired;

                if (stockAfterProduction < 0)
                {
                    return eWorkResult.FailureStocksTooLow;
                }
            }

            return eWorkResult.Success;
        }

        public eWorkResult Produce(IPerson employee, decimal salary)
        {
            var workResult = CanWork(employee);
            if (workResult != eWorkResult.Success)
            {
                return workResult;
            }

            var nbrProducedUnits = Calculator.CalculateProductionProgress(this, employee) / ProducedResource.ProductionCost;

            var requirements = ProducedResource.GetRequirements();
            if (requirements != null)
            {
                foreach (KeyValuePair<Resource, int> requirement in requirements)
                {
                    var nbrResourcesRequired = (int)Math.Ceiling(nbrProducedUnits * requirement.Value);
                    Inventory.Stocks[requirement.Key] -= nbrResourcesRequired;
                }
            }

            Progress += nbrProducedUnits;

            if (Progress >= 1)
            {
                Inventory.Stocks[ProducedResource] += (int)Progress;
                Progress %= 1;
            }

            workResult = PayEmployee(employee, salary);
            return workResult;
        }

        private eWorkResult PayEmployee(IPerson employee, decimal salary)
        {
            var employeeSkill = (decimal)employee.Skillset.Skills[ProducedResource.ImprovedSkill];
            var moneyAfterPay = Money - (salary * employeeSkill);

            if (moneyAfterPay < 0)
            {
                return eWorkResult.FailureNotEnoughMoney;
            }

            Money = moneyAfterPay;
            employee.Money += salary * employeeSkill;

            return eWorkResult.Success;
        }
    }
}
