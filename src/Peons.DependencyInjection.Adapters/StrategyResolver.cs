
namespace Peons.DependencyInjection.Adapters
{
    public class StrategyResolver<TStrategy> : IStrategyResolver<TStrategy>
    {
        private readonly IDiContainer diContainer;

        public StrategyResolver(IDiContainer diContainer)
        {
            this.diContainer = diContainer;
        }

        public T Resolve<T>() where T : TStrategy
        {
            return this.diContainer.Resolve<T>();
        }
    }
}
