
namespace Peons.DependencyInjection
{
    public class StrategyContainer<TStrategy> : IStrategyContainer<TStrategy>
    {
        private readonly IDiContainer diContainer;

        public StrategyContainer(IDiContainer diContainer)
        {
            this.diContainer = diContainer;
        }

        public T Resolve<T>() where T : TStrategy
        {
            return this.diContainer.Resolve<T>();
        }
    }
}
