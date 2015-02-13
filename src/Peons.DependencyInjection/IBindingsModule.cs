using System.Collections.Generic;

namespace Peons.DependencyInjection
{
    public interface IBindingsModule
    {
        void ConstructBindings(IBindingBuilder builder);
    }
}
