using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class NativeInstaller : IWindsorInstaller
    {
        private readonly object value;

        public NativeInstaller(object value)
        {
            this.value = value;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<object>().Instance(value));
        }
    }
}
