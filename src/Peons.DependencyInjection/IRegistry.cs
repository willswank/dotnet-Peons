
namespace Peons.DependencyInjection
{
    public interface IRegistry<TRestricted>
    {
        void ConstructBindings(IRegistryBuilder<TRestricted> builder);
    }
}
