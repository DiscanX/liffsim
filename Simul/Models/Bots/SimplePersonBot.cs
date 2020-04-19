using Simul.Controllers;
using System;
using System.Collections.Generic;

namespace Simul.Models.Bots
{
    public enum eSPBotParameters
    {
        passion,
        interestInEconomy,
        interestInMilitary
    }

    public class SimplePersonBot : Bot
    {
        private IPerson _myself;
        private List<ePersonalityTrait> _personalityTraits;

        private GameController _gameController;
        private PersonController _personController;
        private CompanyController _companyController;
        private ResourceMarketController _resourceMarketController;
        private JobMarketController _jobMarketController;

        private Random _random;

        public override string GetBotTypeName()
        {
            return Constants.SIMPLE_PERSON_BOT_NAME;
        }

        public override IPlayer GetControlledPlayer()
        {
            return _myself;
        }

        public SimplePersonBot(IPerson myself,
            List<ePersonalityTrait> personalityTraits,
            int passion,
            int interestInEconomy,
            int interestInMilitary,
            Random random)
        {
            _myself = myself;
            _myself.IsHumanControlled = false;
            _personalityTraits = personalityTraits;

            Parameters = new Dictionary<string, int>
            {
                { nameof(eSPBotParameters.passion), passion },
                { nameof(eSPBotParameters.interestInEconomy), interestInEconomy },
                { nameof(eSPBotParameters.interestInMilitary), interestInMilitary }
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
            var passion = Parameters[eSPBotParameters.passion.ToString()];
            if (passion == 0 || _random.Next(1, 101) > passion)
            {
                IdleDays++;
                return;
            }

            IdleDays = 0;

            _myself.EatUntilFull();

            //Get an objective if none (TODO)

            WorkAndTrain();

            //Buy & Sell (TODO)

            //Food
            if (_myself.Energy < Constants.MAX_ENERGY / 2)
            {
                var countryResourceMarket = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);

                var quantityWanted = _random.Next(1, 4);
                var foodToBuy = ResourceMarketController.GetBestOffersOfMarket(countryResourceMarket, Helpers.ResourceName.bread, quantityWanted);

                var maximumBuyable = _myself.CalculateMaximumBuyable(foodToBuy);

                //Only buy food when able to buy the maximum
                if (maximumBuyable == quantityWanted)
                {
                    foreach (var food in foodToBuy)
                    {
                        _myself.Buy(countryResourceMarket, food.Item1, food.Item2);
                    }
                }
            }


            //Weapons
        }

        private void WorkAndTrain()
        {
            var interestInEconomy = Parameters[eSPBotParameters.interestInEconomy.ToString()];
            var interestInMilitary = Parameters[eSPBotParameters.interestInMilitary.ToString()];

            if (interestInEconomy >= interestInMilitary)
            {
                TryToWork();
                TryToTrain();
            }
            else
            {
                TryToTrain();
                TryToWork();
            }
        }

        private void TryToWork()
        {
            var bestJob = _jobMarketController.FindBestJob(_myself.Country);

            if (_myself.Employer == null && bestJob.jobOffer != null)
            {
                _myself.TakeJob(bestJob.jobMarket, bestJob.jobOffer, _gameController.CurrentDay);
            }

            if (_myself.CanResign && bestJob.jobOffer != null && bestJob.jobOffer.Salary > _myself.Salary)
            {
                _myself.Resign(_gameController.CurrentDay);
                _myself.TakeJob(bestJob.jobMarket, bestJob.jobOffer, _gameController.CurrentDay);
            }

            if (_myself.CanWork() && _myself.Work() != eWorkResult.Success && bestJob.jobOffer != null)
            {
                _myself.Resign(_gameController.CurrentDay);
                _myself.TakeJob(bestJob.jobMarket, bestJob.jobOffer, _gameController.CurrentDay);
            }
        }

        private void TryToTrain()
        {
            if (_myself.CanTrain())
            {
                _myself.Train();
            }
        }
    }
}
