using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peons.DomainEvents
{
    [TestFixture]
    public class PublisherTests
    {
        Publisher<IDummyEvent> unit;

        [SetUp]
        protected void Setup()
        {
            unit = new DummyPublisher();
        }

        [Test]
        public void Publish_Null_ThrowException()
        {
            var action = new TestDelegate(() => unit.Publish<IDummyEvent>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Publish_Event_CallsHandleOnAllHandlersForEvent()
        {
            var handlerAMock = new Mock<IHandler<ISubDummyEvent>>();
            var handlerBMock = new Mock<IHandler<ISubDummyEvent>>();
            var irrelevantHandlerMock = new Mock<IHandler<IDummyEvent>>();
            var handlerA = handlerAMock.Object;
            var handlerB = handlerBMock.Object;
            var irrelevantHandler = irrelevantHandlerMock.Object;
            var handlers = ((DummyPublisher)unit).Handlers;
            handlers.Add(handlerA);
            handlers.Add(handlerB);
            handlers.Add(irrelevantHandler);
            var inputEvent = new Mock<ISubDummyEvent>().Object;
            unit.Publish(inputEvent);
            handlerAMock.Verify(m => m.Handle(inputEvent), Times.Once);
            handlerBMock.Verify(m => m.Handle(inputEvent), Times.Once);
            irrelevantHandlerMock.Verify(m => m.Handle(It.IsAny<IDummyEvent>()), Times.Never);
        }

        [Test]
        public void Subscribe_NullHandler_ThrowsException()
        {
            var action = new TestDelegate(() => unit.Subscribe((IHandler<IDummyEvent>)null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Subscribe_Handler_AddsToHandlers()
        {
            var handler = new Mock<IHandler<IDummyEvent>>().Object;
            unit.Subscribe(handler);
            var handlers = ((DummyPublisher)unit).Handlers;
            Assert.Contains(handler, handlers);
        }

        [Test]
        public void Subscribe_NullAction_ThrowsException()
        {
            var action = new TestDelegate(() => unit.Subscribe((Action<IDummyEvent>)null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Subscribe_Action_AddsToHandlersAsGenericHandler()
        {
            var executed = false;
            var action = new Action<IDummyEvent>(e => executed = true);
            unit.Subscribe(action);
            var handler = ((DummyPublisher)unit).Handlers.Single()
                as GenericHandler<IDummyEvent>;
            var dummyEvent = new Mock<IDummyEvent>().Object;
            handler.Handle(dummyEvent);
            Assert.IsTrue(executed);
        }

        public interface IDummyEvent : IEvent { }

        public interface ISubDummyEvent : IDummyEvent { }

        class DummyPublisher : Publisher<IDummyEvent>
        {
            public readonly List<object> handlers = new List<object>();
            public List<object> Handlers
            {
                get { return this.handlers; }
            }

            protected override void AddHandler<TSubEvent>(IHandler<TSubEvent> handler)
            {
                this.Handlers.Add(handler);
            }

            protected override IEnumerable<IHandler<TSubEvent>> GetHandlersFor<TSubEvent>()
            {
                return this.Handlers
                    .Select(h => h as IHandler<TSubEvent>)
                    .Where(h => h != null);
            }
        }

    }
}
