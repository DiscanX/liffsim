using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simul.Models.Bots
{
    public enum eSCBotParameters
    {
        passion,
        greediness,
        stability
    }

    public class SimpleCompanyBot : Bot
    {
        private ICompany _myself;
        private GameController _gameController;
        private PersonController _personController;
        private CompanyController _companyController;
        private ResourceMarketController _resourceMarketController;
        private JobMarketController _jobMarketController;
        private Random _random;

        public override string GetBotTypeName()
        {
            return Constants.SIMPLE_COMPANY_BOT_NAME;
        }

        public override IPlayer GetControlledPlayer()
        {
            return _myself;
        }

        public SimpleCompanyBot(ICompany myself, int passion, int greediness, int stability, Random random)
        {
            _myself = myself;
            _myself.IsHumanControlled = false;

            Parameters = new Dictionary<string, int>
            {
                { nameof(eSCBotParameters.passion), passion },
                { nameof(eSCBotParameters.greediness), greediness },
                { nameof(eSCBotParameters.stability), stability }
            };

            _gameController = GameController.Instance;
            _personController = PersonController.Instance;
            _companyController = CompanyController.Instance;
            _resourceMarketController = ResourceMarketController.Instance;
            _jobMarketController = JobMarketController.Instance;

            _random = random;
        }

        public override void LiveDay()
        {
            var passion = Parameters[nameof(eSCBotParameters.passion)];
            if (passion == 0 || _random.Next(1, 101) > passion)
            {
                IdleDays++;
                return;
            }

            IdleDays = 0;

            Sell();

            var requirements = _myself.ProducedResource.GetRequirements();
            if (requirements != null)
            {
                Buy(requirements);
            }

            var bestJob = _jobMarketController.FindBestJob(_myself.Country);

            if (_myself.Money > 500)
            {
                if (bestJob.jobOffer == null)
                {
                    AddJobOffer(1m);
                }
                else if (bestJob.jobOffer.Employer != _myself && _myself.Employees.Count < 5)
                {
                    AddJobOffer(bestJob.jobOffer.Salary + 0.01m);
                }
            }

            if (_myself.Money < 200)
            {
                foreach (var employee in _myself.Employees)
                {
                    employee.Employer = null;
                }

                _myself.Employees.Clear();

                if (bestJob.jobOffer == null)
                {
                    AddJobOffer(0.5m);
                }
                else if (bestJob.jobOffer.Employer != _myself)
                {
                    AddJobOffer(bestJob.jobOffer.Salary);
                }

                var currentResourceMarket = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);
                var stocks = _myself.Inventory.Stocks;
                for (int i = 0; i < stocks.Count; i++)
                {
                    var stock = stocks.ElementAt(i);
                    if (stock.Value == 0)
                    {
                        continue;
                    }

                    var bestOffer = ResourceMarketController.GetBestOffersOfMarket(currentResourceMarket, stock.Key.Name, 1).FirstOrDefault();
                    if (bestOffer.ressourceOffer == null)
                    {
                        _myself.Sell(currentResourceMarket, new ResourceOffer(_myself, stock.Key, stock.Value, 1m));
                    }
                    else if (bestOffer.ressourceOffer.UnitPrice > 0.5m)
                    {
                        _myself.Sell(currentResourceMarket, new ResourceOffer(_myself, stock.Key, stock.Value, bestOffer.Item1.UnitPrice - 0.01m));
                    }
                }
            }
        }

        private void Sell()
        {
            var greediness = Parameters[nameof(eSCBotParameters.greediness)];
            var stability = Parameters[nameof(eSCBotParameters.stability)];

            var currentResourceMarket = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);
            var greedinessPercentage = 1 - (greediness * 0.01f);
            var stabilityPercentage = _random.Next(0, 100 - stability) * 0.01f;
            var numberToSell = (int)Math.Floor(_myself.Inventory.Stocks[_myself.ProducedResource] * Math.Max(greedinessPercentage, stabilityPercentage));

            if (numberToSell > 0)
            {
                var price = _myself.ProducedResource.ProductionCost > 1 ? _myself.ProducedResource.ProductionCost + 2 : 1;
                var adjustedPriceWithSalary = _myself.Employees.Count == 0 ? 1 : price * _myself.Employees.Select(x => x.Salary).Average();

                _myself.Sell(currentResourceMarket, new ResourceOffer(_myself, _myself.ProducedResource, numberToSell, adjustedPriceWithSalary));
            }
        }

        private void Buy(Dictionary<Resource, int> requirements)
        {
            var marketOfCountry = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);
            foreach (var requirement in requirements)
            {
                if (_myself.Inventory.Stocks[requirement.Key] > 100)
                {
                    continue;
                }

                var resourcesToBuy = ResourceMarketController.GetBestOffersOfMarket(marketOfCountry, requirement.Key.Name, (int)_myself.Money / 10);
                if (resourcesToBuy.Count > 0)
                {
                    var maximumBuyable = _myself.CalculateMaximumBuyable(resourcesToBuy);

                    foreach (var resource in resourcesToBuy)
                    {
                        _myself.Buy(marketOfCountry, resource.Item1, resource.Item2);
                    }
                }
            }
        }

        private void AddJobOffer(decimal salary)
        {
            var jobMarketOfCountry = _jobMarketController.GetMarketOfCountry(_myself.Country.Name);
            jobMarketOfCountry.Offers.Add(new JobOffer(_myself, salary));
        }
    }
}
