using Moq;
using NUnit.Framework;

namespace Peons.DomainEvents.NinjectPublisher
{
    [TestFixture]
    public class NinjectPublisherTests
    {
        NinjectPublisher<IEvent> unit;

        [Test]
        public void Publish_CallsHandleOnAllSubscribedHandlers()
        {
            unit = new NinjectPublisher<IEvent>();
            var handlerAMock = new Mock<IHandler<IDummyEvent>>();
            var handlerBMock = new Mock<IHandler<IDummyEvent>>();
            var irrelevantHandlerMock = new Mock<IHandler<IEvent>>();
            unit.Subscribe(handlerAMock.Object);
            unit.Subscribe(handlerBMock.Object);
            unit.Subscribe(irrelevantHandlerMock.Object);
            var inputEventMock = new Mock<IDummyEvent>();
            var inputEvent = inputEventMock.Object;
            unit.Publish(inputEvent);
            handlerAMock.Verify(m => m.Handle(inputEvent), Times.Once);
            handlerBMock.Verify(m => m.Handle(inputEvent), Times.Once);
            irrelevantHandlerMock.Verify(m => m.Handle(It.IsAny<IEvent>()), Times.Never);
        }

        public interface IDummyEvent : IEvent { }
    }
}
