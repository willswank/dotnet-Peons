
namespace Peons.DependencyInjection
{
    public interface IStrategyResolver<TStrategy>
    {
        T Resolve<T>() where T : TStrategy;
    }
}
