using Simul.Controllers;
using System;
using System.Collections.Generic;

namespace Simul.Models.Decorators
{
    public class CompanyDecorator : ICompany, IDecorator
    {
        public List<(int day, string description)> ActionHistory { get; set; }

        protected Company decoratedCompany;

        public CompanyDecorator(Company decoratedCompany)
        {
            ActionHistory = new List<(int, string)>();
            this.decoratedCompany = decoratedCompany;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            decoratedCompany.Buy(resourceMarket, offer, quantity);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_BUY, quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void GiveTo(Player receiver, Resource resource, int quantity)
        {
            decoratedCompany.GiveTo(receiver, resource, quantity);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_GIVETO, quantity, resource.Name, receiver.Name)));
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedCompany.RemoveOffer(resourceMarket, offer);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_REMOVEOFFER, offer.Quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedCompany.Sell(resourceMarket, offer);
            ActionHistory.Add((GameController.Instance.CurrentDay, String.Format(Constants.ACTION_DESCRIPTION_SELL, offer.Quantity, offer.Resource.Name, resourceMarket.Name)));
        }

        public eWorkResult Produce(IPerson employee, decimal salary)
        {
            return decoratedCompany.Produce(employee, salary);
        }

        public int CalculateMaximumBuyable(List<(ResourceOffer ressourceOffer, int quantityToBuy)> offers)
        {
            return decoratedCompany.CalculateMaximumBuyable(offers);
        }

        public Country Country
        {
            get
            {
                return decoratedCompany.Country;
            }

            set
            {
                decoratedCompany.Country = value;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return decoratedCompany.Inventory;
            }

            set
            {
                decoratedCompany.Inventory = value;
            }
        }

        public bool IsHumanControlled
        {
            get
            {
                return decoratedCompany.IsHumanControlled;
            }

            set
            {
                decoratedCompany.IsHumanControlled = value;
            }
        }

        public decimal Money
        {
            get
            {
                return decoratedCompany.Money;
            }

            set
            {
                decoratedCompany.Money = value;
            }
        }

        public string Name
        {
            get
            {
                return decoratedCompany.Name;
            }

            set
            {
                decoratedCompany.Name = value;
            }
        }

        public List<IPerson> Employees
        {
            get
            {
                return decoratedCompany.Employees;
            }

            set
            {
                decoratedCompany.Employees = value;
            }
        }

        public Resource ProducedResource
        {
            get
            {
                return decoratedCompany.ProducedResource;
            }

            set
            {
                decoratedCompany.ProducedResource = value;
            }
        }

        public float Progress
        {
            get
            {
                return decoratedCompany.Progress;
            }

            set
            {
                decoratedCompany.Progress = value;
            }
        }
    }
}
