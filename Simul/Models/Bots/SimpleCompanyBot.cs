using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public enum eSCBotParameters
    {
        passion,
        greediness,
        stability
    }

    public class SimpleCompanyBot : Bot
    {
        private Company myself;
        private GameController gameController;
        private PersonController personController;
        private CompanyController companyController;
        private ResourceMarketController resourceMarketController;
        private JobMarketController jobMarketController;
        private Random random;
        private Dictionary<Resource, int> yesterdaysStocks;

        public override string getBotTypeName()
        {
            return Constants.SIMPLE_COMPANY_BOT_NAME;
        }

        public override string getBotName()
        {
            return myself.name;
        }

        public SimpleCompanyBot(Company myself, int passion, int greediness, int stability, Random random)
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

            }

            yesterdaysStocks = new Dictionary<Resource, int>(myself.inventory.stocks);
        }
    }
}
