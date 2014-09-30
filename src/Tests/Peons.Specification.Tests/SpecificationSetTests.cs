using Moq;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Peons.Specification
{
    [TestFixture]
    class SpecificationSetTests
    {
        SpecificationSet<object> unit;

        [Test]
        public void ctor_Null_ThrowsException()
        {
            var action = new TestDelegate(() =>
                unit = new DummySpecificationSet(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_Empty_ThrowsException()
        {
            var input = new ISpecification<object>[] { };
            var action = new TestDelegate(() =>
                unit = new DummySpecificationSet(input));
            Assert.Throws<ArgEmptyException>(action);
        }

        [Test]
        public void GenericGetEnumerator_ReturnsEnumeratorOverCtorSuppliedSpecifications()
        {
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummySpecificationSet(inputSpecifications.ToArray());
            var output = unit.GetEnumerator();
            var index = 0;
            while (output.MoveNext())
            {
                var spec = output.Current;
                Assert.AreEqual(inputSpecifications[index], spec);
                index++;
            }
        }

        [Test]
        public void GetEnumerator_ReturnsEnumeratorOverCtorSuppliedSpecifications()
        {
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummySpecificationSet(inputSpecifications.ToArray());
            var output = ((IEnumerable)unit).GetEnumerator();
            var index = 0;
            while (output.MoveNext())
            {
                var spec = output.Current;
                Assert.AreEqual(inputSpecifications[index], spec);
                index++;
            }
        }

        [Test]
        public void IsSatisfiedBy_AllSatisfied_ReturnsTrue()
        {
            var inputCandidate = new object();
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 3; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                mock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                    .Returns(true);
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummySpecificationSet(inputSpecifications.ToArray());
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsTrue(output);
        }

        [Test]
        public void IsSatisfiedBy_AnyUnsatisfied_ReturnsFalse()
        {
            var inputCandidate = new object();
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 3; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                var satisfied = i != 1;
                mock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                    .Returns(satisfied);
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummySpecificationSet(inputSpecifications.ToArray());
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsFalse(output);
        }

        [Test]
        public void IsSatisfiedBy_AllUnsatisfied_ReturnsFalse()
        {
            var inputCandidate = new object();
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 3; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                mock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                    .Returns(false);
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummySpecificationSet(inputSpecifications.ToArray());
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsFalse(output);
        }

        [Test]
        public void GetAllSatisfiedBy_ReturnsAllSatisfiedCtorSuppliedSpecifications()
        {
            var inputCandidate = new object();

            var unsatisfiedSpecAMock = new Mock<ISpecification<object>>();
            var unsatisfiedSpecBMock = new Mock<ISpecification<object>>();
            var satisfiedSpecAMock = new Mock<ISpecification<object>>();
            var satisfiedSpecBMock = new Mock<ISpecification<object>>();
            var satisfiedSpecCMock = new Mock<ISpecification<object>>();

            unsatisfiedSpecAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            unsatisfiedSpecBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            satisfiedSpecAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            satisfiedSpecBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            satisfiedSpecCMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);

            var inputSpecifications = new ISpecification<object>[]
            {
                unsatisfiedSpecAMock.Object,
                unsatisfiedSpecBMock.Object,
                satisfiedSpecAMock.Object,
                satisfiedSpecBMock.Object,
                satisfiedSpecCMock.Object
            };
            unit = new DummySpecificationSet(inputSpecifications);
            var output = unit.GetAllSatisfiedBy(inputCandidate);
            Assert.AreEqual(3, output.Count());
            Assert.IsTrue(output.Contains(satisfiedSpecAMock.Object));
            Assert.IsTrue(output.Contains(satisfiedSpecBMock.Object));
            Assert.IsTrue(output.Contains(satisfiedSpecCMock.Object));
        }

        [Test]
        public void GetAllUnsatisfiedBy_ReturnsAllUnsatisfiedCtorSuppliedSpecifications()
        {
            var inputCandidate = new object();

            var unsatisfiedSpecAMock = new Mock<ISpecification<object>>();
            var unsatisfiedSpecBMock = new Mock<ISpecification<object>>();
            var satisfiedSpecAMock = new Mock<ISpecification<object>>();
            var satisfiedSpecBMock = new Mock<ISpecification<object>>();
            var satisfiedSpecCMock = new Mock<ISpecification<object>>();

            unsatisfiedSpecAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            unsatisfiedSpecBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            satisfiedSpecAMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            satisfiedSpecBMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            satisfiedSpecCMock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);

            var inputSpecifications = new ISpecification<object>[]
            {
                unsatisfiedSpecAMock.Object,
                unsatisfiedSpecBMock.Object,
                satisfiedSpecAMock.Object,
                satisfiedSpecBMock.Object,
                satisfiedSpecCMock.Object
            };
            unit = new DummySpecificationSet(inputSpecifications);
            var output = unit.GetAllUnsatisfiedBy(inputCandidate);
            Assert.AreEqual(2, output.Count());
            Assert.IsTrue(output.Contains(unsatisfiedSpecAMock.Object));
            Assert.IsTrue(output.Contains(unsatisfiedSpecBMock.Object));
        }

        class DummySpecificationSet : SpecificationSet<object>
        {
            public DummySpecificationSet(IEnumerable<ISpecification<object>> specifications)
                : base(specifications) { }
        }
    }
}
