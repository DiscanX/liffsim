namespace Simul.Models
{
    public class ResourceOffer
    {
        public IPlayer Owner { get; }
        public Resource Resource { get; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public ResourceOffer(IPlayer owner, Resource resource, int quantity, decimal unitPrice)
        {
            Owner = owner;
            Resource = resource;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
