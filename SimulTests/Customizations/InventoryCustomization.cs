using AutoFixture;
using AutoFixture.Kernel;
using Simul.Models;

namespace SimulTests.Customizations
{
    public class InventoryCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<Inventory>(x => x.FromFactory(
                new MethodInvoker(new GreedyConstructorQuery())));
        }
    }
}
