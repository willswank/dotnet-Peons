using Castle.Windsor;
using NUnit.Framework;

namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    [TestFixture]
    public class IntegrationTest
    {
        [Test]
        public void Run()
        {
            var expected = new object();

            var installers = new CastleWindsorInstallerCollector()
                .Native(new NativeInstaller(expected))
                .Module(new DependencyBindings())
                .Registry(new StrategyRegistry())
                .Finish();
            var windsorContainer = new WindsorContainer();
            windsorContainer.Install(installers);
            var container = new CastleWindsorContainer(windsorContainer);

            var actual = container.Resolve<object>();
            Assert.AreEqual(expected, actual);

            var dummyA1 = container.Resolve<IDummyA>();
            var dummyA2 = container.Resolve<IDummyA>();
            Assert.AreNotSame(dummyA1, dummyA2);

            var dummyB1 = container.Resolve<IDummyB>();
            var dummyB2 = container.Resolve<IDummyB>();
            Assert.AreSame(dummyB1, dummyB2);

            var dummyC1 = container.Resolve<IDummyC>();
            var dummyC2 = container.Resolve<IDummyC>();
            Assert.AreSame(dummyC1, dummyC2);

            var dummyStrategyA1 = container.Resolve<IDummyStrategyA>();
            var dummyStrategyA2 = container.Resolve<IDummyStrategyA>();
            Assert.AreNotSame(dummyStrategyA1, dummyStrategyA2);

            var dummyStrategyB1 = container.Resolve<IDummyStrategyB>();
            var dummyStrategyB2 = container.Resolve<IDummyStrategyB>();
            Assert.AreSame(dummyStrategyB1, dummyStrategyB2);
        }
    }
}
