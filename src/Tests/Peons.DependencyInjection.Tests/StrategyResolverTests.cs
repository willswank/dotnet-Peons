using Moq;
using NUnit.Framework;

namespace Peons.DependencyInjection
{
    [TestFixture]
    public class StrategyResolverTests
    {
        [Test]
        public void Resolve_ResolvesStrategyUsingWrappedDiContainer()
        {
            var input = new object();
            var diContainerMock = new Mock<IDiContainer>();
            diContainerMock
                .Setup(m => m.Resolve<object>())
                .Returns(input);
            var unit = new StrategyResolver<object>(diContainerMock.Object);
            var output = unit.Resolve<object>();
            Assert.AreEqual(input, output);
        }
    }
}
