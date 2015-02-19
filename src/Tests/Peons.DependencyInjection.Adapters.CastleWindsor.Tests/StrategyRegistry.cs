
namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class StrategyRegistry : IStrategyRegistry<IDummyStrategy>
    {
        public void ConstructBindings(IRegistryBuilder<IDummyStrategy> builder)
        {
            builder
                .Class<IDummyStrategyA, DummyStrategyA>(Scope.Transient)
                .Class<IDummyStrategyB, DummyStrategyB>();
        }
    }
}
