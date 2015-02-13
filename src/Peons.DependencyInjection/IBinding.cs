using System;

namespace Peons.DependencyInjection
{
    public interface IBinding
    {
        Type RequestedType { get; }
        Type ResolvedType { get; }
        Scope Scope { get; }
        object Constant { get; }
    }
}
