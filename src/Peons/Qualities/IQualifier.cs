using System.Collections.Generic;

namespace Peons.Qualities
{
    public interface IQualifier<T>
    {
        IEnumerable<IQuality<T>> Qualities { get; }
        IEnumerable<IQuality<T>> Qualify(T target);
    }
}
