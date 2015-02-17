
namespace Peons.DependencyInjection
{
    public interface IStrategyContainer<TStrategy>
    {
        T Resolve<T>() where T : TStrategy;
    }
}
