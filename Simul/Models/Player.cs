using System;
using System.Collections.Generic;
using System.Linq;

namespace Simul.Models
{
    public abstract class Player : IPlayer
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public Inventory Inventory { get; set; }
        public bool IsHumanControlled { get; set; }

        private decimal _money;

        public decimal Money
        {
            get { return _money; }
            set { if (_money < 0) { throw new Exception("Money can't go below zero"); } else { _money = value; } }
        }

        protected Player(string name, Country country, decimal money, Inventory inventory, bool isHumanControlled = false)
        {
            Name = name;
            Country = country;
            Money = money;
            Inventory = inventory;
            IsHumanControlled = isHumanControlled;
        }

        public void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity)
        {
            var totalPrice = quantity * offer.UnitPrice;

            if (totalPrice > Money)
            {
                throw new Exception("The purchase is greater than the currency owned by the player");
            }

            if (quantity > offer.Quantity)
            {
                throw new Exception("The quantity requested is greater than the quantity offered");
            }

            if (Country != resourceMarket.Country)
            {
                throw new Exception("Can't buy from another's country market");
            }

            offer.Owner.Money += totalPrice;
            Money -= totalPrice;

            if (quantity == offer.Quantity)
            {
                resourceMarket.Offers.Remove(offer);
            }
            else
            {
                offer.Quantity -= quantity;
            }

            Inventory.Stocks[offer.Resource] += quantity;
        }

        public void Sell(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            if (offer.Owner.Name != Name)
            {
                throw new Exception("The player can only sell offers he owns");
            }

            if (!Inventory.Stocks.Any(x => x.Key == offer.Resource))
            {
                throw new Exception("The resource is not owned by the player");
            }

            if (Inventory.Stocks.Any(x => x.Key == offer.Resource && offer.Quantity > x.Value))
            {
                throw new Exception("The offer contains too much of this resource");
            }

            Inventory.Stocks[offer.Resource] -= offer.Quantity;

            var alreadyExistingOffer = resourceMarket.Offers.FirstOrDefault(x => x.Owner.Name == Name &&
                                                                                 x.Resource == offer.Resource &&
                                                                                 x.UnitPrice == offer.UnitPrice);
            if (alreadyExistingOffer != null)
            {
                alreadyExistingOffer.Quantity += offer.Quantity;
            }
            else
            {
                resourceMarket.Offers.Add(offer);
            }
        }

        public void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer)
        {
            if (offer.Owner != this)
            {
                throw new Exception("The player can only remove offers he owns");
            }

            resourceMarket.Offers.Remove(offer);
            Inventory.Stocks[offer.Resource] += offer.Quantity;
        }

        public void GiveTo(Player receiver, Resource resource, int quantity)
        {

        }

        public int CalculateMaximumBuyable(List<(ResourceOffer ressourceOffer, int quantityToBuy)> offers)
        {
            var maximumBuyable = 0;

            for (int i = 0; i < offers.Count; i++)
            {
                if (offers[i].quantityToBuy > offers[i].ressourceOffer.Quantity)
                {
                    throw new Exception("Can't buy more than what the quantity of the offer is");
                }

                if (offers[i].ressourceOffer.UnitPrice * offers[i].quantityToBuy > _money)
                {
                    maximumBuyable += (int)Math.Floor(_money / offers[i].ressourceOffer.UnitPrice);
                    break;
                }

                maximumBuyable += offers[i].quantityToBuy;
            }

            return maximumBuyable;
        }
    }
}
