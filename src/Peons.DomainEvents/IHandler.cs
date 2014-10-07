namespace Peons.DomainEvents
{
    public interface IHandler<T> where T : IEvent
    {
        void Handle(T @event);
    }
}
