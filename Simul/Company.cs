using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul
{
    public class Company : Player
    {
        public Resource producedResource { get; set; }
        public float progress { get; set; }
        public List<Contract> contracts { get; set; }

        public Company(string name, Resource producedResource, decimal money, Inventory inventory) : base(name, money, inventory)
        {
            this.producedResource = producedResource;
            this.contracts = new List<Contract>();
        }

        public void Produce(Contract contract)
        {
            
        }
    }
}
