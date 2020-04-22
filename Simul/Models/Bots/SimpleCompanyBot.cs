using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Simul.Models.Bots
{
    ///<remarks>For now greediness and stability doesn't do anything</remarks>
    public enum eSCBotParameters
    {
        passion,
        greediness,
        stability
    }

    public class SimpleCompanyBot : Bot
    {
        private readonly ICompany _myself;
        private readonly ResourceMarketController _resourceMarketController;
        private readonly JobMarketController _jobMarketController;
        private readonly Random _random;
        private readonly decimal _initialMoney;
        private readonly ResourceMarket _marketOfCountry;

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

            _resourceMarketController = ResourceMarketController.Instance;
            _jobMarketController = JobMarketController.Instance;
            _random = random;

            _initialMoney = _myself.Money;
            _marketOfCountry = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);
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

            ExecuteSellLogic();

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
                FireEmployees();

                if (bestJob.jobOffer == null)
                {
                    AddJobOffer(0.5m);
                }
                else if (bestJob.jobOffer.Employer != _myself)
                {
                    AddJobOffer(bestJob.jobOffer.Salary);
                }

                var stocks = _myself.Inventory.Stocks;
                for (int i = 0; i < stocks.Count; i++)
                {
                    var stock = stocks.ElementAt(i);
                    if (stock.Value == 0)
                    {
                        continue;
                    }

                    var bestOffer = _resourceMarketController.GetBestOffersOfMarket(_marketOfCountry, stock.Key.Name, 1).FirstOrDefault();
                    if (bestOffer.ressourceOffer == null)
                    {
                        Sell(new ResourceOffer(_myself, stock.Key, stock.Value, 1m));
                    }
                    else if (bestOffer.ressourceOffer.UnitPrice > 0.5m)
                    {
                        Sell(new ResourceOffer(_myself, stock.Key, stock.Value, bestOffer.ressourceOffer.UnitPrice - 0.01m));
                    }
                }
            }
        }

        private void ExecuteSellLogic()
        {
            var numberToSell = _myself.Inventory.Stocks[_myself.ProducedResource];

            if (numberToSell == 0)
            {
                return;
            }

            decimal unitPrice;

            var bestExistingMarketOffer = _marketOfCountry.Offers.OrderBy(x => x.UnitPrice).FirstOrDefault(x => x.Resource == _myself.ProducedResource);
            if (bestExistingMarketOffer != null && bestExistingMarketOffer.Owner.Name != _myself.Name)
            {
                unitPrice = bestExistingMarketOffer.UnitPrice - bestExistingMarketOffer.UnitPrice * 0.01m;
            }
            else
            {
                var numberOfOurOffers = _marketOfCountry.Offers.Count(x => x.Owner.Name == _myself.Name);
                var moneyDifference = Math.Abs(_myself.Money - _initialMoney);
                unitPrice = moneyDifference / (numberToSell + numberOfOurOffers);
            }

            Sell(new ResourceOffer(_myself, _myself.ProducedResource, numberToSell, unitPrice));
        }

        private void Buy(Dictionary<Resource, int> requirements)
        {
            foreach (var requirement in requirements)
            {
                if (_myself.Inventory.Stocks[requirement.Key] > 100)
                {
                    continue;
                }

                var resourcesToBuy = _resourceMarketController.GetBestOffersOfMarket(_marketOfCountry, requirement.Key.Name, (int)_myself.Money / 10);
                if (resourcesToBuy.Count > 0)
                {
                    var maximumBuyable = _myself.CalculateMaximumBuyable(resourcesToBuy);

                    int numberBought = 0;
                    foreach (var resource in resourcesToBuy)
                    {
                        var numberToBuy = Math.Min(maximumBuyable, resource.quantity);

                        if (numberBought + numberToBuy > maximumBuyable)
                        {
                            break;
                        }

                        _myself.Buy(_marketOfCountry, resource.ressourceOffer, numberToBuy);
                        numberBought += numberToBuy;
                    }
                }
            }
        }

        private void AddJobOffer(decimal salary)
        {
            var jobMarketOfCountry = _jobMarketController.GetMarketOfCountry(_myself.Country.Name);
            jobMarketOfCountry.Offers.Add(new JobOffer(_myself, salary));
        }

        private void FireEmployees()
        {
            foreach (var employee in _myself.Employees)
            {
                employee.Employer = null;
            }

            _myself.Employees.Clear();
        }

        private void Sell(ResourceOffer offer)
        {
            var resourcesToRemove = _marketOfCountry.Offers.Where(x => x.Owner == _myself && x.Resource == offer.Resource).ToList();
            foreach (var resource in resourcesToRemove)
            {
                _myself.RemoveOffer(_marketOfCountry, resource);
            }

            _myself.Sell(_marketOfCountry,
                new ResourceOffer(offer.Owner, offer.Resource, offer.Quantity + resourcesToRemove.Sum(x => x.Quantity), offer.UnitPrice));
        }
    }
}
