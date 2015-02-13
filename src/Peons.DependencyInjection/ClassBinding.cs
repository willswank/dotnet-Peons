using System;

namespace Peons.DependencyInjection
{
    public class ClassBinding<TRequested, TResolved> : IBinding
    {
        public ClassBinding(Scope scope = Scope.Singleton)
        {
            this.scope = scope;
        }

        public Type RequestedType
        {
            get { return typeof(TRequested); }
        }

        public Type ResolvedType
        {
            get { return typeof(TResolved); }
        }

        private readonly Scope scope;
        public Scope Scope
        {
            get { return this.scope; }
        }

        public object Constant
        {
            get { return null; }
        }
    }
}
