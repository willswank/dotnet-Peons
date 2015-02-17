using System.Collections.Generic;

namespace Peons.DependencyInjection
{
    public class BindingBuilder : IBindingBuilder
    {
        private readonly List<IBinding> bindings;

        public BindingBuilder()
        {
            this.bindings = new List<IBinding>();
        }

        public IBindingBuilder Class<TRequested, TResolved>(Scope scope = Scope.Singleton)
            where TResolved : TRequested
        {
            var binding = new ClassBinding<TRequested, TResolved>(scope);
            this.bindings.Add(binding);
            return this;
        }

        public IBindingBuilder Const<TRequested>(TRequested constant)
        {
            if (constant == null)
                throw new ArgNullException(() => constant);

            var binding = new ConstantBinding<TRequested>(constant);
            this.bindings.Add(binding);
            return this;
        }

        public IBinding[] Finish()
        {
            return bindings.ToArray();
        }
    }
}
