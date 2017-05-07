using Simul.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models.Decorators
{
    public class CompanyDecorator : ICompany, IDecorator
    {
        public List<Tuple<int, string>> actionHistory { get; set; }

        protected Company decoratedCompany;

        public CompanyDecorator(Company decoratedCompany)
        {
            actionHistory = new List<Tuple<int, string>>();
            this.decoratedCompany = decoratedCompany;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            decoratedCompany.Buy(resourceMarket, offer, quantity);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(Constants.ACTION_DESCRIPTION_BUY, quantity, offer.resource.name, resourceMarket.name)));
        }

        public void GiveTo(Player receiver, Resource resource, int quantity)
        {
            decoratedCompany.GiveTo(receiver, resource, quantity);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(Constants.ACTION_DESCRIPTION_GIVETO, quantity, resource.name, receiver.name)));
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedCompany.RemoveOffer(resourceMarket, offer);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(Constants.ACTION_DESCRIPTION_REMOVEOFFER, offer.quantity, offer.resource.name, resourceMarket.name)));
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            decoratedCompany.Sell(resourceMarket, offer);
            actionHistory.Add(Tuple.Create(GameController.Instance.currentDay, String.Format(Constants.ACTION_DESCRIPTION_SELL, offer.quantity, offer.resource.name, resourceMarket.name)));
        }

        public eWorkResult Produce(IPerson employee, decimal salary)
        {
            return decoratedCompany.Produce(employee, salary);
        }

        public int CalculateMaximumBuyable(List<Tuple<ResourceOffer, int>> offers)
        {
            return decoratedCompany.CalculateMaximumBuyable(offers);
        }

        public Country country
        {
            get
            {
                return decoratedCompany.country;
            }

            set
            {
                decoratedCompany.country = value;
            }
        }

        public Inventory inventory
        {
            get
            {
                return decoratedCompany.inventory;
            }

            set
            {
                decoratedCompany.inventory = value;
            }
        }

        public bool isHumanControlled
        {
            get
            {
                return decoratedCompany.isHumanControlled;
            }

            set
            {
                decoratedCompany.isHumanControlled = value;
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

        public string name
        {
            get
            {
                return decoratedCompany.name;
            }

            set
            {
                decoratedCompany.name = value;  
            }
        }

        public List<IPerson> employees
        {
            get
            {
                return decoratedCompany.employees;
            }

            set
            {
                decoratedCompany.employees = value;
            }
        }

        public Resource producedResource
        {
            get
            {
                return decoratedCompany.producedResource;
            }

            set
            {
                decoratedCompany.producedResource = value;
            }
        }

        public float progress
        {
            get
            {
                return decoratedCompany.progress;
            }

            set
            {
                decoratedCompany.progress = value;
            }
        }
    }
}
