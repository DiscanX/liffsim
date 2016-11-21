using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Offer
    {
        public Market market { get; set; }
        public Player owner { get; set; }
        public Resource resource { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }

        public Offer(Market market, Player owner, Resource resource, int quantity, decimal unitPrice)
        {
            this.market = market;
            this.owner = owner;
            this.resource = resource;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

    }
}
