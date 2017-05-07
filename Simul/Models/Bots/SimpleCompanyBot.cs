using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private ICompany myself;
        private GameController gameController;
        private PersonController personController;
        private CompanyController companyController;
        private ResourceMarketController resourceMarketController;
        private JobMarketController jobMarketController;
        private Random random;

        public override string getBotTypeName()
        {
            return Constants.SIMPLE_COMPANY_BOT_NAME;
        }

        public override IPlayer getControlledPlayer()
        {
            return myself;
        }

        public SimpleCompanyBot(ICompany myself, int passion, int greediness, int stability, Random random)
        {
            this.myself = myself;
            this.myself.isHumanControlled = false;

            this.parameters = new Dictionary<string, int>();
            parameters.Add(eSCBotParameters.passion.ToString(), passion);
            parameters.Add(eSCBotParameters.greediness.ToString(), greediness);
            parameters.Add(eSCBotParameters.stability.ToString(), stability);

            this.gameController = GameController.Instance;
            this.personController = PersonController.Instance;
            this.companyController = CompanyController.Instance;
            this.resourceMarketController = ResourceMarketController.Instance;
            this.jobMarketController = JobMarketController.Instance;

            this.random = random;
        }

        public override void LiveDay()
        {
            int passion = parameters[eSCBotParameters.passion.ToString()];
            int greediness = parameters[eSCBotParameters.greediness.ToString()];
            int stability = parameters[eSCBotParameters.stability.ToString()];

            if (passion > 0 && random.Next(1, 101) <= passion)
            {
                ResourceMarket currentResourceMarket = resourceMarketController.GetMarketOfCountry(myself.country.name);

                //Sell
                float greedinessPercentage = 1 - (greediness * 0.01f);
                float stabilityPercentage = random.Next(0, 100 - stability) * 0.01f;
                int numberToSell = (int)Math.Floor(myself.inventory.stocks[myself.producedResource] * Math.Max(greedinessPercentage, stabilityPercentage));

                if(numberToSell > 0)
                {
                    myself.Sell(currentResourceMarket, new ResourceOffer(myself, myself.producedResource, numberToSell, 1));
                }

                //Buy
                Dictionary<Resource, int> requirements = myself.producedResource.GetRequirements();
                if (requirements != null)
                {
                    var marketOfCountry = resourceMarketController.GetMarketOfCountry(myself.country.name);
                    foreach (var requirement in requirements)
                    {
                        var resourcesToBuy = resourceMarketController.GetBestOffersOfMarket(marketOfCountry, requirement.Key.name, 2);
                        if (resourcesToBuy.Count > 0)
                        {
                            int maximumBuyable = myself.CalculateMaximumBuyable(resourcesToBuy);

                            //Only buy food when able to buy the maximum
                            if (maximumBuyable == 2)
                            {
                                foreach (var resource in resourcesToBuy)
                                {
                                    myself.Buy(marketOfCountry, resource.Item1, resource.Item2);
                                }
                            }
                        }
                    }
                }


                //Add job offers
                if(myself.producedResource.edible)
                {
                    var jobMarketOfCountry = jobMarketController.GetMarketOfCountry(myself.country.name);
                    while (jobMarketOfCountry.offers.Count(x => x.employer.name == myself.name) < 3)
                    {
                        jobMarketOfCountry.offers.Add(new JobOffer(myself, 1));
                    }
                }
            }
        }
    }
}
