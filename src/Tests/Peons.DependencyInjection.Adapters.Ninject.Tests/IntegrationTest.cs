using Ninject;
using NUnit.Framework;

namespace Peons.DependencyInjection.Adapters.Ninject
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public void Run()
        {
            var expected = new object();

            var modules = new NinjectModuleCollector()
                .Native(new NativeModule(expected))
                .Adapted(new DependencyBindings())
                .Adapted(new StrategyRegistry())
                .Finish();
            var kernel = new StandardKernel(modules);
            var container = new NinjectContainer(kernel);

            var actual = container.Resolve<object>();
            Assert.AreEqual(expected, actual);

            var dummyA1 = container.Resolve<IDummyA>();
            var dummyA2 = container.Resolve<IDummyA>();
            Assert.AreNotSame(dummyA1, dummyA2);

            var dummyB1 = container.Resolve<IDummyB>();
            var dummyB2 = container.Resolve<IDummyB>();
            Assert.AreSame(dummyB1, dummyB2);

            var meaningOfLife = container.Resolve<int>();
            Assert.AreEqual(DependencyBindings.MEANING_OF_LIFE, meaningOfLife);

            var dummyStrategyA1 = container.Resolve<IDummyStrategyA>();
            var dummyStrategyA2 = container.Resolve<IDummyStrategyA>();
            Assert.AreNotSame(dummyStrategyA1, dummyStrategyA2);

            var dummyStrategyB1 = container.Resolve<IDummyStrategyB>();
            var dummyStrategyB2 = container.Resolve<IDummyStrategyB>();
            Assert.AreSame(dummyStrategyB1, dummyStrategyB2);
        }
    }
}
