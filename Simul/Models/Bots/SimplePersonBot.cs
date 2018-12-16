using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var interestInEconomy = Parameters[eSPBotParameters.interestInEconomy.ToString()];
            var interestInMilitary = Parameters[eSPBotParameters.interestInMilitary.ToString()];

            if (passion > 0 && _random.Next(1, 101) <= passion)
            {
                //Eat
                _myself.EatUntilFull();

                //Find a job if none
                if (_myself.Employer == null)
                {
                    var bestJob = FindBestJob();
                    if (bestJob != null)
                    {
                        _myself.TakeJob(bestJob.Item1, bestJob.Item2, _gameController.CurrentDay);
                    }
                }

                //Get an objective if none (TODO)

                //Work & Train
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

                //Buy & Sell

                //Food
                if (_myself.Energy < Constants.MAX_ENERGY / 2)
                {
                    ResourceMarket countryResourceMarket = _resourceMarketController.GetMarketOfCountry(_myself.Country.Name);

                    var quantityWanted = _random.Next(1, 4);
                    var foodToBuy = _resourceMarketController.GetBestOffersOfMarket(countryResourceMarket, Helpers.eResourceName.bread, quantityWanted);

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
        }

        private Tuple<JobMarket, JobOffer> FindBestJob()
        {
            var bestOffer = new JobOffer(null, Decimal.MinValue);
            JobMarket bestJobMarketOfOffer = null;

            foreach (JobMarket market in _jobMarketController.Markets.Where(x => x.Country == _myself.Country))
            {
                var bestOfferOfThisMarket = market.Offers.OrderByDescending(x => x.Salary).FirstOrDefault();
                if (bestOfferOfThisMarket != null && bestOfferOfThisMarket.Salary > bestOffer.Salary)
                {
                    bestOffer = bestOfferOfThisMarket;
                    bestJobMarketOfOffer = market;
                }
            }

            if (bestJobMarketOfOffer == null || bestOffer == null)
            {
                return null;
            }

            return new Tuple<JobMarket, JobOffer>(bestJobMarketOfOffer, bestOffer);
        }

        private void TryToWork()
        {
            if (_myself.Employer != null && _myself.Energy - Constants.ENERGY_LOST_WORKING >= 0)
            {
                if (_myself.Work() != eWorkResult.Success)
                {
                    //Try to find another job
                    var bestJob = FindBestJob();
                    if (bestJob != null)
                    {
                        _myself.Resign(_gameController.CurrentDay);
                        _myself.TakeJob(bestJob.Item1, bestJob.Item2, _gameController.CurrentDay);
                    }
                }
            }
        }

        private void TryToTrain()
        {
            if (_myself.Energy - Constants.ENERGY_LOST_TRAINING >= 0)
            {
                _myself.Train();
            }
        }
    }
}
