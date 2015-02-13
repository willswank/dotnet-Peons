
namespace Peons.DependencyInjection
{
    public interface IDiContainer
    {
        T Resolve<T>();
    }
}
