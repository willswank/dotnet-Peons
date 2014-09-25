using Moq;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Peons.Specification
{
    [TestFixture]
    class OrderedSpecificationSetTests
    {
        OrderedSpecificationSet<object> unit;

        [Test]
        public void ctor_Null_ThrowsException()
        {
            var action = new TestDelegate(() =>
                unit = new DummyOrderedSpecificationSet(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_Empty_ThrowsException()
        {
            var input = new ISpecification<object>[] { };
            var action = new TestDelegate(() =>
                unit = new DummyOrderedSpecificationSet(input));
            Assert.Throws<ArgEmptyException>(action);
        }

        [Test]
        public void Indexer_ReturnsCtorSuppliedSpecificationsAtSameIndex()
        {
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummyOrderedSpecificationSet(inputSpecifications.ToArray());
            for (var i = 0; i < 5; i++)
            {
                var output = unit[i];
                Assert.AreEqual(inputSpecifications[i], output);
            }
        }

        [Test]
        public void Length_ReturnsCtorSuppliedSpecificationsLength()
        {
            var dummySpecificationSetA = new List<ISpecification<object>>();
            for (var i = 0; i < 3; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                dummySpecificationSetA.Add(mock.Object);
            }
            var dummySpecificationSetB = new List<ISpecification<object>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                dummySpecificationSetB.Add(mock.Object);
            }
            var inputs = new ISpecification<object>[][]
            {
                dummySpecificationSetA.ToArray(),
                dummySpecificationSetB.ToArray()
            };
            foreach (var inputSet in inputs)
            {
                unit = new DummyOrderedSpecificationSet(inputSet);
                Assert.AreEqual(inputSet.Length, unit.Length);
            }
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
            unit = new DummyOrderedSpecificationSet(inputSpecifications.ToArray());
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
            unit = new DummyOrderedSpecificationSet(inputSpecifications.ToArray());
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
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                mock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                    .Returns(true);
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummyOrderedSpecificationSet(inputSpecifications.ToArray());
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsTrue(output);
        }

        [Test]
        public void IsSatisfiedBy_AnyUnsatisfied_ReturnsFalse()
        {
            var inputCandidate = new object();
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                var satisfied = i != 3;
                mock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                    .Returns(satisfied);
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummyOrderedSpecificationSet(inputSpecifications.ToArray());
            var output = unit.IsSatisfiedBy(inputCandidate);
            Assert.IsFalse(output);
        }

        [Test]
        public void GetFirstUnsatisfiedBy_AnyUnsatisfied_ReturnsFirst()
        {
            var inputCandidate = new object();
            var firstUnsatisfiedIndex = 2;
            var secondUnsatisfiedIndex = 3;
            var inputSpecifications = new List<ISpecification<object>>();
            for (var i = 0; i < 5; i++)
            {
                var mock = new Mock<ISpecification<object>>();
                var satisfied = i != firstUnsatisfiedIndex
                    && i != secondUnsatisfiedIndex;
                mock.Setup(m => m.IsSatisfiedBy(inputCandidate))
                    .Returns(satisfied);
                inputSpecifications.Add(mock.Object);
            }
            unit = new DummyOrderedSpecificationSet(inputSpecifications.ToArray());
            var output = unit.GetFirstUnsatisfiedBy(inputCandidate);
            Assert.AreEqual(inputSpecifications[2], output);
        }

        class DummyOrderedSpecificationSet : OrderedSpecificationSet<object>
        {
            public DummyOrderedSpecificationSet(ISpecification<object>[] specifications)
                : base(specifications) { }
        }
    }
}
