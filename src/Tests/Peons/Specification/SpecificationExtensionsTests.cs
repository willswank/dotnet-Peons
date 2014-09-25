using Moq;
using NUnit.Framework;
using Peons.Internals.Specification;

namespace Peons.Specification
{
    [TestFixture]
    class SpecificationExtensionsTests
    {
        [Test]
        public void And_ReturnsAndSpecificationFromInputs()
        {
            var specAMock = new Mock<ISpecification<int>>();
            var specBMock = new Mock<ISpecification<int>>();
            var output = SpecificationExtensions.And(specAMock.Object, specBMock.Object)
                as AndSpecification<int>;
            Assert.AreEqual(specAMock.Object, output.SpecificationA);
            Assert.AreEqual(specBMock.Object, output.SpecificationB);
        }

        [Test]
        public void Or_ReturnsOrSpecificationFromInputs()
        {
            var specAMock = new Mock<ISpecification<int>>();
            var specBMock = new Mock<ISpecification<int>>();
            var output = SpecificationExtensions.Or(specAMock.Object, specBMock.Object)
                as OrSpecification<int>;
            Assert.AreEqual(specAMock.Object, output.SpecificationA);
            Assert.AreEqual(specBMock.Object, output.SpecificationB);
        }

        [Test]
        public void Not_ReturnsNotSpecificationFromInput()
        {
            var specMock = new Mock<ISpecification<int>>();
            var output = SpecificationExtensions.Not(specMock.Object)
                as NotSpecification<int>;
            Assert.AreEqual(specMock.Object, output.WrappedSpecification);
        }
    }
}
