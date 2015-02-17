
namespace Peons.DependencyInjection
{
    public interface IBindingBuilder
    {
        IBindingBuilder Class<TRequested, TResolved>(Scope scope = Scope.Singleton)
            where TResolved : TRequested;
        IBindingBuilder Const<TRequested>(TRequested constant);
    }
}
