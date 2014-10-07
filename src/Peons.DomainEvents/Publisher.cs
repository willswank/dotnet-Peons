using System;
using System.Collections.Generic;

namespace Peons.DomainEvents
{
    public abstract class Publisher<T> : IPublisher<T> where T : IEvent
    {
        protected abstract void AddHandler<TSubEvent>(IHandler<TSubEvent> handler) where TSubEvent : T;
        protected abstract IEnumerable<IHandler<TSubEvent>> GetHandlersFor<TSubEvent>() where TSubEvent : T;

        public void Publish<TSubEvent>(TSubEvent @event) where TSubEvent : T
        {
            if (@event == null)
                throw new ArgNullException(() => @event);

            var handlers = this.GetHandlersFor<TSubEvent>();
            foreach (var handler in this.GetHandlersFor<TSubEvent>())
            {
                handler.Handle(@event);
            }
        }

        public void Subscribe<TSubEvent>(IHandler<TSubEvent> handler) where TSubEvent : T
        {
            if (handler == null)
                throw new ArgNullException(() => handler);

            this.AddHandler(handler);
        }

        public void Subscribe<TSubEvent>(Action<TSubEvent> action) where TSubEvent : T
        {
            if (action == null)
                throw new ArgNullException(() => action);

            var handler = new GenericHandler<TSubEvent>(action);
            this.AddHandler(handler);
        }
    }
}
