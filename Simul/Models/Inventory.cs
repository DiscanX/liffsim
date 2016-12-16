using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Inventory
    {
        public Dictionary<Resource, int> resources { get; set; }

        public Inventory()
        {
            this.resources = new Dictionary<Resource, int>();
        }

        public Inventory(Dictionary<Resource, int> resources)
        {
            this.resources = resources;
        }
    }
}
