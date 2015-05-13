namespace Peons.DomainEvents
{
    public interface IHandler<TEvent> where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}
