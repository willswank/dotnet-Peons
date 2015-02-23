using System;

namespace Peons.DependencyInjection.Adapters
{
    public class ConstantBinding<TRequested> : IBinding
    {
        public ConstantBinding(TRequested constant)
        {
            if (constant == null)
                throw new ArgNullException(() => constant);

            this.constant = constant;
        }

        public Type RequestedType
        {
            get { return typeof(TRequested); }
        }

        public Type ResolvedType
        {
            get { return null; }
        }

        public Scope Scope
        {
            get { return Scope.Singleton; }
        }

        private readonly object constant;
        public object Constant
        {
            get { return constant; }
        }
    }
}
