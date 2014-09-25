namespace Peons.Qualities
{
    public interface IQuality<T>
    {
        bool AppliesTo(T target);
    }
}
