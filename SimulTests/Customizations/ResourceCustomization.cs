using AutoFixture;
using AutoFixture.Kernel;
using Simul.Models;

namespace SimulTests.Customizations
{
    public class ResourceCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new TypeRelay(typeof(Resource), typeof(PrimaryResource)));
        }
    }
}
