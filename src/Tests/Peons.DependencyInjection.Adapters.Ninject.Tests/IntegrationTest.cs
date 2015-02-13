using Ninject;
using NUnit.Framework;

namespace Peons.DependencyInjection.Adapters.Ninject.Tests
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public void Run()
        {
            var bindings = new DependencyBindings();
            var adapter = new AdapterNinjectModule(bindings);
            var kernel = new StandardKernel(adapter);
            var container = new NinjectContainer(kernel);

            var dummyA1 = container.Resolve<IDummyA>();
            var dummyA2 = container.Resolve<IDummyA>();
            Assert.AreNotSame(dummyA1, dummyA2);

            var dummyB1 = container.Resolve<IDummyB>();
            var dummyB2 = container.Resolve<IDummyB>();
            Assert.AreSame(dummyB1, dummyB2);

            var meaningOfLife = container.Resolve<int>();
            Assert.AreEqual(DependencyBindings.MEANING_OF_LIFE, meaningOfLife);
        }
    }
}
