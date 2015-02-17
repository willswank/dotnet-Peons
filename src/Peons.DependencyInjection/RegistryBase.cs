using System.Collections.Generic;

namespace Peons.DependencyInjection
{
    public abstract class RegistryBase<TRestricted> : BindingBuilder, IRegistryBuilder<TRestricted>
    {
        public new IRegistryBuilder<TRestricted> Class<TRequested, TResolved>(Scope scope = Scope.Singleton)
            where TRequested : TRestricted
            where TResolved : TRequested
        {
            base.Class<TRequested, TResolved>(scope);
            return this;
        }

        public new IRegistryBuilder<TRestricted> Const<TRequested>(TRequested constant)
            where TRequested : TRestricted
        {
            base.Const<TRequested>(constant);
            return this;
        }
    }
}
