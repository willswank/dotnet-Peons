using Moq;
using NUnit.Framework;
using Peons.Specification;

namespace Peons.Specification.Internals
{
    [TestFixture]
    class NotSpecificationTests
    {
        NotSpecification<object> unit;

        [Test]
        public void ctor_NullSpec_ThrowsException()
        {
            var action = new TestDelegate(() =>
                new NotSpecification<object>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_Spec_CanGetLater()
        {
            var specMock = new Mock<ISpecification<object>>();
            unit = new NotSpecification<object>(specMock.Object);
            Assert.AreEqual(specMock.Object, unit.WrappedSpecification);
        }

        [Test]
        public void ctor_SpecSatisfied_ReturnsFalse()
        {
            var inputCandidate = new object();
            var specMock = new Mock<ISpecification<object>>();
            specMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            unit = new NotSpecification<object>(specMock.Object);
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsFalse(output);
        }

        [Test]
        public void ctor_SpecUnsatisfied_ReturnsTrue()
        {
            var inputCandidate = new object();
            var specMock = new Mock<ISpecification<object>>();
            specMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            unit = new NotSpecification<object>(specMock.Object);
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsTrue(output);
        }
    }
}
