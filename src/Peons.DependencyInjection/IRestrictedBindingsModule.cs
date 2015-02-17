
namespace Peons.DependencyInjection
{
    public interface IRestrictedBindingsModule<TRestricted>
    {
        void ConstructBindings(IRestrictedBindingBuilder<TRestricted> builder);
    }
}
