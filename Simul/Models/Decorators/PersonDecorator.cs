using Simul.Controllers;
using System;
using System.Collections.Generic;

namespace Simul.Models.Decorators
{
    public class PersonDecorator : IPerson, IDecorator
    {

        public List<(int day, string description)> ActionHistory { get; set; }
        protected Person decoratedPerson;

        public PersonDecorator(Person decoratedPerson)
        {
            ActionHistory = new List<(int, string)>();
            this.decoratedPerson = decoratedPerson;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            decoratedPerson.Buy(resourceMarket, offer, quantity);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_BUY, quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void GiveTo(Player receiver, Resource resource, int quantity)
        {
            decoratedPerson.GiveTo(receiver, resource, quantity);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_GIVETO, quantity, resource.Name, receiver.Name)));
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedPerson.RemoveOffer(resourceMarket, offer);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_REMOVEOFFER, offer.Quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void Resign(int currentDay)
        {
            ActionHistory.Add((GameController.Instance.CurrentDay, $"Resigned from {decoratedPerson.Employer.Name}"));
            decoratedPerson.Resign(currentDay);
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedPerson.Sell(resourceMarket, offer);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_SELL, offer.Quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void TakeJob(JobMarket jobMarket, JobOffer jobOffer, int currentDay)
        {
            decoratedPerson.TakeJob(jobMarket, jobOffer, currentDay);
            ActionHistory.Add((GameController.Instance.CurrentDay, $"Took job of {jobOffer.Employer.Name} with a salary of {jobOffer.Salary} from the market {jobMarket.Name}"));
        }

        public void Train()
        {
            decoratedPerson.Train();
            ActionHistory.Add((GameController.Instance.CurrentDay, "Trained"));
        }

        public WorkResult Work()
        {
            var workResult = decoratedPerson.Work();

            if (workResult != WorkResult.Success)
            {
                ActionHistory.Add((GameController.Instance.CurrentDay, $"Tried to work but can't : {workResult}"));
            }
            else
            {
                ActionHistory.Add((GameController.Instance.CurrentDay, "Worked"));
            }

            return workResult;
        }

        public void Eat(Resource resource, int quantity)
        {
            decoratedPerson.Eat(resource, quantity);
            ActionHistory.Add((GameController.Instance.CurrentDay, $"Ate {quantity} {resource.Name} for {quantity * Constants.ENERGY_GAINED_AFTER_EATING} energy"));

        }

        public void EatUntilFull()
        {
            decoratedPerson.EatUntilFull();
        }

        public decimal Strength
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

        public decimal GetCurrentUsedSkillLevel()
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

        public int CalculateMaximumBuyable(List<(ResourceOffer ressourceOffer, int quantityToBuy)> offers)
        {
            return decoratedPerson.CalculateMaximumBuyable(offers);
        }
    }
}
