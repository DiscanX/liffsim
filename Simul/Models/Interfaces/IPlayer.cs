using System.Collections.Generic;

namespace Simul.Models
{
    public interface IPlayer
    {
        Country Country { get; set; }
        Inventory Inventory { get; set; }
        bool IsHumanControlled { get; set; }
        decimal Money { get; set; }
        string Name { get; set; }

        void Buy(ResourceMarket resourceMarket, ResourceOffer offer, int quantity);
        void GiveTo(Player receiver, Resource resource, int quantity);
        void RemoveOffer(ResourceMarket resourceMarket, ResourceOffer offer);
        void Sell(ResourceMarket resourceMarket, ResourceOffer offer);
        int CalculateMaximumBuyable(List<(ResourceOffer ressourceOffer, int quantity)> offers);
    }
}