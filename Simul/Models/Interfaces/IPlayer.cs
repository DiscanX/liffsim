using System;
using System.Collections.Generic;

namespace Simul.Models
{
    public interface IPlayer
    {
        Country country { get; set; }
        Inventory inventory { get; set; }
        bool isHumanControlled { get; set; }
        decimal Money { get; set; }
        string name { get; set; }

        void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity);
        void GiveTo(Player receiver, Resource resource, int quantity);
        void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer);
        void Sell(ResourceMarket resourceMarket, ResourceOffer offer);
        int CalculateMaximumBuyable(List<Tuple<ResourceOffer, int>> offers);
    }
}