using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class SimplePersonBot : Bot
    {
        public int passion { get; set; }
        public int interestInEconomy { get; set; }
        public int interestInMilitary { get; set; }

        GameController gameController;
        PersonController personController;
        CompanyController companyController;
        ResourceMarketController resourceMarketController;
        JobMarketController jobMarketController;

        public SimplePersonBot(Person myself, int passion, int interestInEconomy, int interestInMilitary, Random random)
        {
            if(botTypeName == null)
            {
                botTypeName = Constants.SIMPLE_PERSON_BOT_NAME;
            }

            this.myself = myself;
            this.myself.isHumanControlled = false;

            this.passion = passion;
            this.interestInEconomy = interestInEconomy;
            this.interestInMilitary = interestInMilitary;
            this.random = new Random();

            this.gameController = GameController.Instance;
            this.personController = PersonController.Instance;
            this.companyController = CompanyController.Instance;
            this.resourceMarketController = ResourceMarketController.Instance;
            this.jobMarketController = JobMarketController.Instance;
        }

        public override void LiveDay()
        {
            if(passion > 0 && random.Next(1, 101) <= passion)
            {
                //Find a job if none
                if(myself.employer == null)
                {
                    FindBestJob();
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

        private void FindBestJob()
        {
            JobOffer bestOffer = null;
            JobMarket bestJobMarketOfOffer = null;

            foreach (JobMarket market in jobMarketController.markets)
            {
                JobOffer bestOfferOfThisMarket = market.offers.OrderByDescending(x => x.salary).FirstOrDefault();
                if (bestOffer == null || bestOfferOfThisMarket.salary > bestOffer.salary)
                {
                    bestOffer = bestOfferOfThisMarket;
                    bestJobMarketOfOffer = market;
                }
            }

            if(bestOffer != null)
            {
                myself.TakeJob(bestJobMarketOfOffer, bestOffer, gameController.currentDay);
            }
        }

        private void TryToWork()
        {
            if (myself.employer != null && myself.Energy - Constants.ENERGY_LOST_WORKING >= 0)
            {
                myself.Work();
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
