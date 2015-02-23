
namespace Peons.DependencyInjection
{
    public interface IStrategyRegistry<TRestricted>
    {
        void ConstructBindings(IRegistryBuilder<TRestricted> bindings);
    }
}
