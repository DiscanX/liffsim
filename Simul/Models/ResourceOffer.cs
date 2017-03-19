using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class ResourceOffer
    {
        public Player owner { get; set; }
        public Resource resource { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }

        public ResourceOffer(Player owner, Resource resource, int quantity, decimal unitPrice)
        {
            this.owner = owner;
            this.resource = resource;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }
    }
}
