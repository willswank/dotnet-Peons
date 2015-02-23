using System;

namespace Peons.DependencyInjection.Adapters
{
    public interface IBinding
    {
        Type RequestedType { get; }
        Type ResolvedType { get; }
        Scope Scope { get; }
        object Constant { get; }
    }
}
