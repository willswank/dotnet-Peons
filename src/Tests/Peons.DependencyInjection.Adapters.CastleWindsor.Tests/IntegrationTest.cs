using Castle.Windsor;
using NUnit.Framework;

namespace Peons.DependencyInjection.Adapters.CastleWindsor.Tests
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public void Run()
        {
            var bindings = new DependencyBindings();
            var adapter = new AdapterCastleWindsorInstaller(bindings);
            var windsorContainer = new WindsorContainer();
            windsorContainer.Install(adapter);
            var container = new CastleWindsorContainer(windsorContainer);

            var dummyA1 = container.Resolve<IDummyA>();
            var dummyA2 = container.Resolve<IDummyA>();
            Assert.AreNotSame(dummyA1, dummyA2);

            var dummyB1 = container.Resolve<IDummyB>();
            var dummyB2 = container.Resolve<IDummyB>();
            Assert.AreSame(dummyB1, dummyB2);

            var dummyC1 = container.Resolve<IDummyC>();
            var dummyC2 = container.Resolve<IDummyC>();
            Assert.AreSame(dummyC1, dummyC2);
        }
    }
}
