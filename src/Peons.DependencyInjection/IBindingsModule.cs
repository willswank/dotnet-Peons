
namespace Peons.DependencyInjection
{
    public interface IBindingsModule
    {
        void ConstructBindings(IBindingBuilder builder);
    }
}
