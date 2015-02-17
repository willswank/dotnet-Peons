using Castle.Windsor;

namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class CastleWindsorContainer : IDiContainer
    {
        private readonly IWindsorContainer container;

        public CastleWindsorContainer(IWindsorContainer container)
        {
            this.container = container;
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }
    }
}
