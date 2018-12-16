using Simul.Controllers;
using System;
using System.Collections.Generic;

namespace Simul.Models.Decorators
{
    public class PersonDecorator : IPerson, IDecorator
    {
        private const string ACTION_DESCRIPTION_RESIGN = "Resigned from {0}";
        private const string ACTION_DESCRIPTION_TAKEJOB = "Took job of {0} with a salary of {1} from the market {2}";
        private const string ACTION_DESCRIPTION_TRAIN = "Trained";
        private const string ACTION_DESCRIPTION_CANT_WORK = "Tried to work but can't : {0}";
        private const string ACTION_DESCRIPTION_WORK = "Worked";
        private const string ACTION_DESCRIPTION_EAT = "Ate {0} {1} for {2} energy";

        public List<Tuple<int, string>> ActionHistory { get; set; }
        protected Person decoratedPerson;

        public PersonDecorator(Person decoratedPerson)
        {
            ActionHistory = new List<Tuple<int, string>>();
            this.decoratedPerson = decoratedPerson;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            decoratedPerson.Buy(resourceMarket, offer, quantity);
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_BUY, quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void GiveTo(Player receiver, Resource resource, int quantity)
        {
            decoratedPerson.GiveTo(receiver, resource, quantity);
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_GIVETO, quantity, resource.Name, receiver.Name)));
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedPerson.RemoveOffer(resourceMarket, offer);
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_REMOVEOFFER, offer.Quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void Resign(int currentDay)
        {
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(ACTION_DESCRIPTION_RESIGN, decoratedPerson.Employer.Name)));
            decoratedPerson.Resign(currentDay);
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedPerson.Sell(resourceMarket, offer);
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_SELL, offer.Quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay)
        {
            decoratedPerson.TakeJob(jobMarket, jobOffer, currentDay);
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(ACTION_DESCRIPTION_TAKEJOB, jobOffer.Employer.Name, jobOffer.Salary, jobMarket.Name)));
        }

        public void Train()
        {
            decoratedPerson.Train();
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, ACTION_DESCRIPTION_TRAIN));
        }

        public eWorkResult Work()
        {
            var workResult = decoratedPerson.Work();

            if (workResult != eWorkResult.Success)
            {
                ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(ACTION_DESCRIPTION_CANT_WORK, workResult.ToString())));
            }
            else
            {
                ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, ACTION_DESCRIPTION_WORK));
            }

            return workResult;
        }

        public void Eat(Resource resource, int quantity)
        {
            decoratedPerson.Eat(resource, quantity);
            ActionHistory.Add(Tuple.Create(GameController.Instance.CurrentDay, String.Format(ACTION_DESCRIPTION_EAT, quantity, resource.Name, quantity * Constants.ENERGY_GAINED_AFTER_EATING)));

        }

        public float Strength
        {
            get { return decoratedPerson.Strength; }
            set { decoratedPerson.Strength = value; }
        }

        public ICompany Employer
        {
            get { return decoratedPerson.Employer; }
            set { decoratedPerson.Employer = value; }
        }

        public decimal Salary
        {
            get { return decoratedPerson.Salary; }
            set { decoratedPerson.Salary = value; }
        }

        public Skillset Skillset
        {
            get { return decoratedPerson.Skillset; }
            set { decoratedPerson.Skillset = value; }
        }

        public bool AlreadyWorked
        {
            get { return decoratedPerson.AlreadyWorked; }
            set { decoratedPerson.AlreadyWorked = value; }
        }

        public bool AlreadyTrained
        {
            get { return decoratedPerson.AlreadyTrained; }
            set { decoratedPerson.AlreadyTrained = value; }
        }

        public bool CanResign
        {
            get { return decoratedPerson.CanResign; }
            set { decoratedPerson.CanResign = value; }
        }

        public int JobStartDay
        {
            get { return decoratedPerson.JobStartDay; }
            set { decoratedPerson.JobStartDay = value; }
        }

        public int Energy
        {
            get { return decoratedPerson.Energy; }
            set { decoratedPerson.Energy = value; }
        }

        public Country Country
        {
            get { return decoratedPerson.Country; }
            set { decoratedPerson.Country = value; }
        }

        public Inventory Inventory
        {
            get { return decoratedPerson.Inventory; }
            set { decoratedPerson.Inventory = value; }
        }

        public bool IsHumanControlled
        {
            get { return decoratedPerson.IsHumanControlled; }
            set { decoratedPerson.IsHumanControlled = value; }
        }

        public decimal Money
        {
            get { return decoratedPerson.Money; }
            set { decoratedPerson.Money = value; }
        }

        public string Name
        {
            get { return decoratedPerson.Name; }
            set { decoratedPerson.Name = value; }
        }

        public string DisplayProductivity()
        {
            return decoratedPerson.DisplayProductivity();
        }

        public float GetCurrentUsedSkillLevel()
        {
            return decoratedPerson.GetCurrentUsedSkillLevel();
        }

        public string DisplayCurrentEmployer()
        {
            return decoratedPerson.DisplayCurrentEmployer();
        }

        public bool CanWork()
        {
            return decoratedPerson.CanWork();
        }

        public bool CanTrain()
        {
            return decoratedPerson.CanTrain();
        }

        public int CalculateMaximumBuyable(List<Tuple<ResourceOffer, int>> offers)
        {
            return decoratedPerson.CalculateMaximumBuyable(offers);
        }

        public void EatUntilFull()
        {
            decoratedPerson.EatUntilFull();
        }
    }
}
