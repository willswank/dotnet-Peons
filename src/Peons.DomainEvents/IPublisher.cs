using System;

namespace Peons.DomainEvents
{
    public interface IPublisher<T> where T : IEvent
    {
        void Publish<TSubEvent>(TSubEvent @event) where TSubEvent : T;
        void Subscribe<TSubEvent>(IHandler<TSubEvent> handler) where TSubEvent : T;
        void Subscribe<TSubEvent>(Action<TSubEvent> action) where TSubEvent : T;
    }
}
