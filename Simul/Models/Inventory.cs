using Simul.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simul.Models
{
    public class Inventory
    {
        public Dictionary<Resource, int> stocks { get; set; }

        public Inventory()
        {
            stocks = new Dictionary<Resource, int>();

            foreach(Resource resource in ContentReader.GetResources())
            {
                stocks.Add(resource, 0);
            }
        }

        public Inventory(Dictionary<Resource, int> stocks)
        {
            this.stocks = stocks;
        }
    }
}
