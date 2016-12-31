using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class ResourceOffer
    {
        public ResourceMarket market { get; set; }
        public Player owner { get; set; }
        public Resource resource { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }

        public ResourceOffer(ResourceMarket market, Player owner, Resource resource, int quantity, decimal unitPrice)
        {
            this.market = market;
            this.owner = owner;
            this.resource = resource;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }
    }
}
