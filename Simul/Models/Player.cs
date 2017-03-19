using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public abstract class Player
    {
        public string name { get; set; }
        public Inventory inventory { get; set; }
        public bool isHumanControlled { get; set; }
        private decimal money;
        public decimal Money
        {
            get { return money; }
            set { if (money < 0) { throw new Exception("Money can't go below zero"); } else { money = value; } }
        }

        public Player(string name, decimal money, Inventory inventory, bool isHumanControlled = false)
        {
            this.name = name;
            this.Money = money;
            this.inventory = inventory;
            this.isHumanControlled = isHumanControlled;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            decimal totalPrice = quantity * offer.unitPrice;

            if (totalPrice > Money)
            {
                throw new Exception("The purchase is greater than the currency owned by the player");
            }

            if(quantity > offer.quantity)
            {
                throw new Exception("The quantity requested is greater than the quantity offered");
            }

            offer.owner.Money += totalPrice;
            Money -= totalPrice;

            if(quantity == offer.quantity)
            {
                resourceMarket.offers.Remove(offer);
            }
            else
            {
                offer.quantity -= quantity;
            }

            inventory.stocks[offer.resource] += quantity;
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            if(offer.owner != this)
            {
                throw new Exception("The player can only sell offers he owns");
            }

            if(!inventory.stocks.Any(x => x.Key == offer.resource))
            {
                throw new Exception("The resource is not owned by the player");
            }
            
            if(!inventory.stocks.Any(x => x.Key == offer.resource && x.Value > offer.quantity))
            {
                throw new Exception("The offer contains too much of this resource");
            }

            inventory.stocks[offer.resource] -= offer.quantity;
            resourceMarket.offers.Add(offer);
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            if (offer.owner != this)
            {
                throw new Exception("The player can only remove offers he owns");
            }

            resourceMarket.offers.Remove(offer);
            inventory.stocks[offer.resource] += offer.quantity;
        }

        public void GiveTo(Player receiver, Resource ressource, int quantite)
        {

        }
    }
}
