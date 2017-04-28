using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models.Decorators
{
    public class PersonDecorator : IPerson
    {
        private const string ACTION_DESCRIPTION_BUY = "Bought {0} {1} from the market {2}";
        private const string ACTION_DESCRIPTION_GIVETO = "Gave {0} {1} to the player {2}";
        private const string ACTION_DESCRIPTION_REMOVEOFFER = "Removed offer of {0} {1} from the market {2}";
        private const string ACTION_DESCRIPTION_RESIGN = "Resigned from {0}";
        private const string ACTION_DESCRIPTION_SELL = "Put for sale {0} {1} to the market {2}";
        private const string ACTION_DESCRIPTION_TAKEJOB = "Took job of {0} with a salary of {1} from the market {2}";
        private const string ACTION_DESCRIPTION_TRAIN = "Trained";
        private const string ACTION_DESCRIPTION_CANT_WORK = "Tried to work but can't : {0}";
        private const string ACTION_DESCRIPTION_WORK = "Worked";
        private const string ACTION_DESCRIPTION_EAT = "Ate {0} {1} for {2} energy";

        public List<Tuple<int, string>> actionHistory { get; set; }
        protected Person decoratedPerson;

        public PersonDecorator(Person decoratedPerson)
        {
            actionHistory = new List<Tuple<int, string>>();
            this.decoratedPerson = decoratedPerson;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            decoratedPerson.Buy(resourceMarket, offer, quantity);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_BUY, offer.quantity, offer.resource.name, resourceMarket.name)));
        }

        public void GiveTo(Player receiver, Resource resource, int quantity)
        {
            decoratedPerson.GiveTo(receiver, resource, quantity);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_GIVETO, quantity, resource.name, receiver.name)));
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedPerson.RemoveOffer(resourceMarket, offer);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_REMOVEOFFER, offer.quantity, offer.resource.name, resourceMarket.name)));
        }

        public void Resign(int currentDay)
        {
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_RESIGN, decoratedPerson.employer.name)));
            decoratedPerson.Resign(currentDay);
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedPerson.Sell(resourceMarket, offer);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_SELL, offer.quantity, offer.resource.name, resourceMarket.name)));
        }

        public void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay)
        {
            decoratedPerson.TakeJob(jobMarket, jobOffer, currentDay);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_TAKEJOB, jobOffer.employer.name, jobOffer.salary, jobMarket.name)));
        }

        public void Train()
        {
            decoratedPerson.Train();
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, ACTION_DESCRIPTION_TRAIN));
        }

        public eWorkResult Work()
        {
            eWorkResult workResult = decoratedPerson.Work();

            if(workResult != eWorkResult.Success)
            {
                actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_CANT_WORK, workResult.ToString())));
            }
            else
            {
                actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, ACTION_DESCRIPTION_WORK));
            }
            
            return workResult;
        }

        public void Eat(Resource resource, int quantity)
        {
            decoratedPerson.Eat(resource, quantity);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(ACTION_DESCRIPTION_EAT, quantity, resource.name, quantity * Constants.ENERGY_GAINED_AFTER_EATING)));

        }

        public float strength
        {
            get { return decoratedPerson.strength; }
            set { decoratedPerson.strength = value; }
        }

        public Company employer
        {
            get { return decoratedPerson.employer; }
            set { decoratedPerson.employer = value; }
        }

        public decimal salary
        {
            get { return decoratedPerson.salary; }
            set { decoratedPerson.salary = value; }
        }

        public Skillset skillset
        {
            get { return decoratedPerson.skillset; }
            set { decoratedPerson.skillset = value; }
        }

        public bool alreadyWorked
        {
            get { return decoratedPerson.alreadyWorked; }
            set { decoratedPerson.alreadyWorked = value; }
        }

        public bool alreadyTrained
        {
            get { return decoratedPerson.alreadyTrained; }
            set { decoratedPerson.alreadyTrained = value; }
        }

        public bool canResign
        {
            get { return decoratedPerson.canResign; }
            set { decoratedPerson.canResign = value; }
        }

        public int jobStartDay
        {
            get { return decoratedPerson.jobStartDay; }
            set { decoratedPerson.jobStartDay = value; }
        }

        public int Energy
        {
            get { return decoratedPerson.Energy; }
            set { decoratedPerson.Energy = value; }
        }

        public Country country
        {
            get { return decoratedPerson.country; }
            set { decoratedPerson.country = value; }
        }

        public Inventory inventory
        {
            get { return decoratedPerson.inventory; }
            set { decoratedPerson.inventory = value; }
        }

        public bool isHumanControlled
        {
            get { return decoratedPerson.isHumanControlled; }
            set { decoratedPerson.isHumanControlled = value; }
        }

        public decimal Money
        {
            get { return decoratedPerson.Money; }
            set { decoratedPerson.Money = value; }
        }

        public string name
        {
            get { return decoratedPerson.name; }
            set { decoratedPerson.name = value; }
        }

        public string DisplayProductivity()
        {
            return decoratedPerson.DisplayProductivity();
        }

        public float GetCurrentUsedSkillLevel()
        {
            return decoratedPerson.GetCurrentUsedSkillLevel();
        }
    }
}
