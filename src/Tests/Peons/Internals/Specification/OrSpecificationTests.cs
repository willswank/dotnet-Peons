﻿using Moq;
using NUnit.Framework;
using Peons.Specification;

namespace Peons.Internals.Specification
{
    [TestFixture]
    class OrSpecificationTests
    {
        OrSpecification<object> unit;

        [Test]
        public void ctor_NullSpecA_ThrowsException()
        {
            var specMock = new Mock<ISpecification<object>>();
            var action = new TestDelegate(() =>
                new OrSpecification<object>(null, specMock.Object));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_NullSpecB_ThrowsException()
        {
            var specMock = new Mock<ISpecification<object>>();
            var action = new TestDelegate(() =>
                new OrSpecification<object>(specMock.Object, null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_SpecA_CanGetLater()
        {
            var specAMock = new Mock<ISpecification<object>>();
            var specBMock = new Mock<ISpecification<object>>();
            unit = new OrSpecification<object>(specAMock.Object, specBMock.Object);
            Assert.AreEqual(specAMock.Object, unit.SpecificationA);
        }

        [Test]
        public void ctor_SpecB_CanGetLater()
        {
            var specAMock = new Mock<ISpecification<object>>();
            var specBMock = new Mock<ISpecification<object>>();
            unit = new OrSpecification<object>(specAMock.Object, specBMock.Object);
            Assert.AreEqual(specBMock.Object, unit.SpecificationB);
        }

        [Test]
        public void ctor_BothSpecsSatisfied_ReturnsTrue()
        {
            var inputCandidate = new object();
            var specAMock = new Mock<ISpecification<object>>();
            var specBMock = new Mock<ISpecification<object>>();
            specAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            specBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            unit = new OrSpecification<object>(specAMock.Object, specBMock.Object);
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsTrue(output);
        }

        [Test]
        public void ctor_SpecASatisfiedSpecBUnsatisfied_ReturnsTrue()
        {
            var inputCandidate = new object();
            var specAMock = new Mock<ISpecification<object>>();
            var specBMock = new Mock<ISpecification<object>>();
            specAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            specBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            unit = new OrSpecification<object>(specAMock.Object, specBMock.Object);
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsTrue(output);
        }

        [Test]
        public void ctor_SpecAUnatisfiedSpecBSatisfied_ReturnsTrue()
        {
            var inputCandidate = new object();
            var specAMock = new Mock<ISpecification<object>>();
            var specBMock = new Mock<ISpecification<object>>();
            specAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            specBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            unit = new OrSpecification<object>(specAMock.Object, specBMock.Object);
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsTrue(output);
        }

        [Test]
        public void ctor_BothSpecsUnsatisfied_ReturnsFalse()
        {
            var inputCandidate = new object();
            var specAMock = new Mock<ISpecification<object>>();
            var specBMock = new Mock<ISpecification<object>>();
            specAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            specBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            unit = new OrSpecification<object>(specAMock.Object, specBMock.Object);
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsFalse(output);
        }
    }
}
