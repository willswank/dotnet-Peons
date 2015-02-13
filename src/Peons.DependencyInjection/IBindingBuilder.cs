
namespace Peons.DependencyInjection
{
    public interface IBindingBuilder
    {
        IBindingBuilder Class<TRequested, TResolved>(Scope scope = Scope.Singleton);
        IBindingBuilder Const<TRequested>(TRequested constant);
    }
}
