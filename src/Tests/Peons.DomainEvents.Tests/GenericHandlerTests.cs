using Moq;
using NUnit.Framework;
using System;

namespace Peons.DomainEvents
{
    [TestFixture]
    class GenericHandlerTests
    {
        GenericHandler<IEvent> unit;

        [Test]
        public void ctor_Null_ThrowsException()
        {
            var action = new TestDelegate(() => new GenericHandler<IEvent>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Handle_Null_ThrowsException()
        {
            var dummyAction = new Action<IEvent>(e => { });
            unit = new GenericHandler<IEvent>(dummyAction);
            var action = new TestDelegate(() => unit.Handle(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Handle_Event_CallsActionOnEvent()
        {
            IEvent passedEvent = null;
            var dummyAction = new Action<IEvent>(e => passedEvent = e);
            unit = new GenericHandler<IEvent>(dummyAction);
            var inputEvent = new Mock<IEvent>().Object;
            unit.Handle(inputEvent);
            Assert.AreEqual(passedEvent, inputEvent);
        }
    }
}
