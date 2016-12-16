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
        public decimal money { get; set; }
        public Inventory inventory { get; set; }

        public Player(string name, decimal money, Inventory inventory)
        {
            this.name = name;
            this.money = money;
            this.inventory = inventory;
        }

        public string DisplayMoney()
        {
            return money.ToString();
        }

        public void Buy(ResourceOffer offer, int quantity)
        {
            decimal totalPrice = offer.quantity * offer.unitPrice;

            if (totalPrice > money)
            {
                throw new Exception("The purchase is greater than the currency owned by the player");
            }

            if(quantity > offer.quantity)
            {
                throw new Exception("The quantity requested is greater than the quantity offered");
            }

            offer.owner.money += totalPrice;
            money -= totalPrice;

            if(quantity == offer.quantity)
            {
                offer.market.DeleteOffer(offer);
            }
            else
            {
                offer.quantity -= quantity;
            }

            inventory.resources[offer.resource] += quantity;
        }

        public void Sell(ResourceOffer offer)
        {
            if(offer.owner != this)
            {
                throw new Exception("The player can only sell offers he owns");
            }

            if(!inventory.resources.Any(x => x.Key == offer.resource))
            {
                throw new Exception("The resource is not owned by the player");
            }
            
            if(!inventory.resources.Any(x => x.Key == offer.resource && x.Value > offer.quantity))
            {
                throw new Exception("The offer contains too much of this resource");
            }

            inventory.resources[offer.resource] -= offer.quantity;
            offer.market.AddOffer(offer);
        }

        public void RemoveOffer(ResourceOffer offer)
        {
            if (offer.owner != this)
            {
                throw new Exception("The player can only remove offers he owns");
            }

            offer.market.DeleteOffer(offer);
            inventory.resources[offer.resource] += offer.quantity;
        }

        public void GiveTo(Player receiver, Resource ressource, int quantite)
        {

        }
    }
}
