using Autofac;

namespace Simul.Config
{
    public static class AutofacConfiguration
    {
        public static IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}

