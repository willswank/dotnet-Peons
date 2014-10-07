using System;

namespace Peons.DomainEvents
{
    public class GenericHandler<T> : IHandler<T> where T : IEvent
    {
        private readonly Action<T> action;

        public GenericHandler(Action<T> action)
        {
            if (action == null)
                throw new ArgNullException(() => action);

            this.action = action;
        }

        public void Handle(T @event)
        {
            if (@event == null)
                throw new ArgNullException(() => @event);

            this.action(@event);
        }
    }
}
