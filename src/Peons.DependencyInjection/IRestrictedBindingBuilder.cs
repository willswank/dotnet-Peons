
namespace Peons.DependencyInjection
{
    public interface IRestrictedBindingBuilder<TRestricted>
    {
        IRestrictedBindingBuilder<TRestricted> Class<TRequested, TResolved>(Scope scope = Scope.Singleton)
            where TRequested : TRestricted
            where TResolved : TRequested;
        IRestrictedBindingBuilder<TRestricted> Const<TRequested>(TRequested constant)
            where TRequested : TRestricted;
    }
}
