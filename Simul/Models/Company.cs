using System;
using System.Collections.Generic;

namespace Simul.Models
{
    public class Company : Player, ICompany
    {
        public Resource ProducedResource { get; set; }
        public decimal Progress { get; set; }
        public List<IPerson> Employees { get; set; }

        public Company(string name, Country country, Resource producedResource, decimal money, Inventory inventory, bool isHumanControlled = false) : base(name, country, money, inventory, isHumanControlled)
        {
            ProducedResource = producedResource;
            Employees = new List<IPerson>();
        }

        private WorkResult CanWork(IPerson employee)
        {
            var requirements = ProducedResource.GetRequirements();
            if (requirements == null)
            {
                return WorkResult.Success;
            }

            foreach (KeyValuePair<Resource, int> requirement in requirements)
            {
                var nbrProducedUnits = Calculator.CalculateProductionProgress(this, employee) / ProducedResource.ProductionCost;
                var nbrResourcesRequired = (int)Math.Ceiling(nbrProducedUnits * requirement.Value);
                var stockAfterProduction = Inventory.Stocks[requirement.Key] - nbrResourcesRequired;

                if (stockAfterProduction < 0)
                {
                    return WorkResult.FailureStocksTooLow;
                }
            }

            return WorkResult.Success;
        }

        public WorkResult Produce(IPerson employee, decimal salary)
        {
            var workResult = CanWork(employee);
            if (workResult != WorkResult.Success)
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

        private WorkResult PayEmployee(IPerson employee, decimal salary)
        {
            var employeeSkill = (decimal)employee.Skillset.Skills[ProducedResource.ImprovedSkill];
            var moneyAfterPay = Money - (salary * employeeSkill);

            if (moneyAfterPay < 0)
            {
                return WorkResult.FailureNotEnoughMoney;
            }

            Money = moneyAfterPay;
            employee.Money += salary * employeeSkill;

            return WorkResult.Success;
        }
    }
}
