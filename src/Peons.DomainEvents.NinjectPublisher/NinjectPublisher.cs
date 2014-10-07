using Ninject;
using System.Collections.Generic;

namespace Peons.DomainEvents.NinjectPublisher
{
    public class NinjectPublisher<T> : Publisher<T> where T : IEvent
    {
        private readonly IKernel kernel = new StandardKernel();

        protected override void AddHandler<TSubEvent>(IHandler<TSubEvent> handler)
        {
            kernel.Bind<IHandler<TSubEvent>>().ToConstant(handler);
        }

        protected override IEnumerable<IHandler<TSubEvent>> GetHandlersFor<TSubEvent>()
        {
            var handlers = kernel.GetAll<IHandler<TSubEvent>>();
            return handlers;
        }
    }
}
