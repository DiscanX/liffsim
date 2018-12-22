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
            if (passion > 0 && _random.Next(1, 101) <= passion)
            {
                Sell();

                var requirements = _myself.ProducedResource.GetRequirements();
                if (requirements != null)
                {
                    Buy(requirements);
                }

                if (_myself.ProducedResource.Edible)
                {
                    AddJobOffers();
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
                decimal price = _myself.ProducedResource.ProductionCost > 1 ? _myself.ProducedResource.ProductionCost + 2 : 1;
                _myself.Sell(currentResourceMarket, new ResourceOffer(_myself, _myself.ProducedResource, numberToSell, price));
            }
        }

        private void Buy(Dictionary<Resource, int> requirements)
        {
            var marketOfCountry = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);
            foreach (var requirement in requirements)
            {
                var resourcesToBuy = _resourceMarketController.GetBestOffersOfMarket(marketOfCountry, requirement.Key.Name, (int)_myself.Money / 10);
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

        private void AddJobOffers()
        {
            var jobMarketOfCountry = _jobMarketController.GetMarketOfCountry(_myself.Country.Name);
            while (jobMarketOfCountry.Offers.Count(x => x.Employer.Name == _myself.Name) < 3)
            {
                jobMarketOfCountry.Offers.Add(new JobOffer(_myself, 1));
            }
        }
    }
}
