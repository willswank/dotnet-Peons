using System.Collections.Generic;

namespace Peons.DependencyInjection
{
    public abstract class RestrictedBindingBuilder<TRestricted> : IRestrictedBindingBuilder<TRestricted>
    {
        private readonly BindingBuilder builder;

        public RestrictedBindingBuilder()
        {
            this.builder = new BindingBuilder();
        }

        public IRestrictedBindingBuilder<TRestricted> Class<TRequested, TResolved>(Scope scope = Scope.Singleton)
            where TRequested : TRestricted
            where TResolved : TRequested
        {
            this.builder.Class<TRequested, TResolved>(scope);
            return this;
        }

        public IRestrictedBindingBuilder<TRestricted> Const<TRequested>(TRequested constant)
            where TRequested : TRestricted
        {
            this.builder.Const<TRequested>(constant);
            return this;
        }

        public IBinding[] Finish()
        {
            return this.builder.Finish();
        }
    }
}
