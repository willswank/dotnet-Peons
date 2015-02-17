
namespace Peons.DependencyInjection
{
    public interface IRegistryBuilder<TRestricted>
    {
        IRegistryBuilder<TRestricted> Class<TRequested, TResolved>(Scope scope = Scope.Singleton)
            where TRequested : TRestricted
            where TResolved : TRequested;
        IRegistryBuilder<TRestricted> Const<TRequested>(TRequested constant)
            where TRequested : TRestricted;
    }
}
