using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private IPerson myself;
        private List<ePersonalityTrait> personalityTraits;

        private GameController gameController;
        private PersonController personController;
        private CompanyController companyController;
        private ResourceMarketController resourceMarketController;
        private JobMarketController jobMarketController;

        private Random random;

        public override string getBotTypeName()
        {
            return Constants.SIMPLE_PERSON_BOT_NAME;
        }

        public override IPlayer getControlledPlayer()
        {
            return myself;
        }

        public SimplePersonBot(IPerson myself, List<ePersonalityTrait> personalityTraits, int passion, int interestInEconomy, int interestInMilitary, Random random)
        {
            this.myself = myself;
            this.myself.isHumanControlled = false;
            this.personalityTraits = personalityTraits;

            this.parameters = new Dictionary<string, int>();
            parameters.Add(eSPBotParameters.passion.ToString(), passion);
            parameters.Add(eSPBotParameters.interestInEconomy.ToString(), interestInEconomy);
            parameters.Add(eSPBotParameters.interestInMilitary.ToString(), interestInMilitary);

            this.gameController = GameController.Instance;
            this.personController = PersonController.Instance;
            this.companyController = CompanyController.Instance;
            this.resourceMarketController = ResourceMarketController.Instance;
            this.jobMarketController = JobMarketController.Instance;

            this.random = random;
        }

        public override void LiveDay()
        {
            int passion = parameters[eSPBotParameters.passion.ToString()];
            int interestInEconomy = parameters[eSPBotParameters.interestInEconomy.ToString()];
            int interestInMilitary = parameters[eSPBotParameters.interestInMilitary.ToString()];

            if (passion > 0 && random.Next(1, 101) <= passion)
            {
                //Eat
                myself.EatUntilFull();

                //Find a job if none
                if(myself.employer == null)
                {
                    Tuple<JobMarket, JobOffer> bestJob = FindBestJob();
                    if (bestJob != null)
                    {
                        myself.TakeJob(bestJob.Item1, bestJob.Item2, gameController.currentDay);
                    }
                }

                //Get an objective if none (TODO)

                //Work & Train
                if(interestInEconomy >= interestInMilitary)
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
                if (myself.Energy < Constants.MAX_ENERGY / 2)
                {
                    ResourceMarket countryResourceMarket = resourceMarketController.GetMarketOfCountry(myself.country.name);

                    int quantityWanted = random.Next(1, 4);
                    var foodToBuy = resourceMarketController.GetBestOffersOfMarket(countryResourceMarket, Helpers.eResourceName.bread, quantityWanted);

                    int maximumBuyable = myself.CalculateMaximumBuyable(foodToBuy);

                    //Only buy food when able to buy the maximum
                    if(maximumBuyable == quantityWanted)
                    {
                        foreach(var food in foodToBuy)
                        {
                            myself.Buy(countryResourceMarket, food.Item1, food.Item2);
                        }
                    }
                }


                //Weapons
            }
        }

        private Tuple<JobMarket, JobOffer> FindBestJob()
        {
            JobOffer bestOffer = new JobOffer(null, Decimal.MinValue);
            JobMarket bestJobMarketOfOffer = null;

            foreach (JobMarket market in jobMarketController.markets.Where(x => x.country == myself.country))
            {
                JobOffer bestOfferOfThisMarket = market.offers.OrderByDescending(x => x.salary).FirstOrDefault();
                if (bestOfferOfThisMarket != null && bestOfferOfThisMarket.salary > bestOffer.salary)
                {
                    bestOffer = bestOfferOfThisMarket;
                    bestJobMarketOfOffer = market;
                }
            }

            if(bestJobMarketOfOffer == null || bestOffer == null)
            {
                return null;
            }

            return new Tuple<JobMarket, JobOffer>(bestJobMarketOfOffer, bestOffer);
        }

        private void TryToWork()
        {
            if (myself.employer != null && myself.Energy - Constants.ENERGY_LOST_WORKING >= 0)
            {
                if(myself.Work() != eWorkResult.Success)
                {
                    //Try to find another job
                    Tuple<JobMarket, JobOffer> bestJob = FindBestJob();
                    if (bestJob != null)
                    {
                        myself.Resign(gameController.currentDay);
                        myself.TakeJob(bestJob.Item1, bestJob.Item2, gameController.currentDay);
                    }
                }
            }
        }

        private void TryToTrain()
        {
            if (myself.Energy - Constants.ENERGY_LOST_TRAINING >= 0)
            {
                myself.Train();
            }
        }
    }
}
