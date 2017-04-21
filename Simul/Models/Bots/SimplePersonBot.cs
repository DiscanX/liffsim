using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
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

        public SimplePersonBot(IPerson myself, int passion, int interestInEconomy, int interestInMilitary, Random random)
        {
            this.myself = myself;
            this.myself.isHumanControlled = false;

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
            }
        }

        private Tuple<JobMarket, JobOffer> FindBestJob()
        {
            JobOffer bestOffer = new JobOffer(null, Decimal.MinValue);
            JobMarket bestJobMarketOfOffer = null;

            foreach (JobMarket market in jobMarketController.markets)
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
