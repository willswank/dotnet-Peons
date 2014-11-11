namespace Peons.DiContainers
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}
