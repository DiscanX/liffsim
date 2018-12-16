using Simul.Helpers;
using System.Collections.Generic;

namespace Simul.Models
{
    public class Inventory
    {
        public Dictionary<Resource, int> Stocks { get; set; }

        public Inventory()
        {
            Stocks = new Dictionary<Resource, int>();

            foreach (Resource resource in ContentReader.GetResources())
            {
                Stocks.Add(resource, 5);
            }
        }

        public Inventory(Dictionary<Resource, int> stocks)
        {
            Stocks = stocks;
        }
    }
}
