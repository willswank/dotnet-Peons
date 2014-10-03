using Moq;
using NUnit.Framework;
using System;

namespace Peons.Specification.Taxonomy
{
    [TestFixture]
    class DefinitionTests
    {
        Definition<object> unit;

        [Test]
        public void ctor_NullGenus_ThrowsException()
        {
            ISpecification<object> inputGenus = null;
            var action = new TestDelegate(()
                => new DummyDefinition(inputGenus, null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void WhyUnsatisfiedBy_GenusAndDifferentiaSatisfied_ReturnsNull()
        {
            var inputCandidate = new object();
            var satisfiedSpecMock = new Mock<ISpecification<object>>();
            var satisfiedDefinitionMock = new Mock<IDefinition<object>>();
            satisfiedSpecMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            satisfiedDefinitionMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns<ISpecification<object>>(null);
            var inputGenera = new ISpecification<object>[]
            {
                satisfiedSpecMock.Object,
                satisfiedDefinitionMock.Object
            };
            var satisfiedDifferentia = new Func<object, bool>(o => o == inputCandidate);
            foreach (var inputGenus in inputGenera)
            {
                unit = new DummyDefinition(inputGenus, satisfiedDifferentia);
                var output = unit.WhyUnsatisfiedBy(inputCandidate);
                Assert.IsNull(output);
            }
        }

        [Test]
        public void WhyUnsatisfiedBy_UnsatisfiedSpecGenus_ReturnsGenus()
        {
            var inputCandidate = new object();
            var unsatisfiedGenusMock = new Mock<ISpecification<object>>();
            unsatisfiedGenusMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            var unsatisfiedGenus = unsatisfiedGenusMock.Object;
            var unsatisfiedDifferentia = new Func<object, bool>(o => false);
            unit = new DummyDefinition(unsatisfiedGenus, unsatisfiedDifferentia);
            var output = unit.WhyUnsatisfiedBy(inputCandidate);
            Assert.AreEqual(unsatisfiedGenus, output);
        }

        [Test]
        public void WhyUnsatisfiedBy_UnsatisfiedDefinitionGenus_ReturnsGenusUnsatisfiedReason()
        {
            var inputCandidate = new object();
            var unsatisfiedReasonMock = new Mock<ISpecification<object>>();
            var unsatisfiedReason = unsatisfiedReasonMock.Object;
            var unsatisfiedGenusMock = new Mock<IDefinition<object>>();
            unsatisfiedGenusMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns(unsatisfiedReason);
            var unsatisfiedGenus = unsatisfiedGenusMock.Object;
            var unsatisfiedDifferentia = new Func<object, bool>(o => false);
            unit = new DummyDefinition(unsatisfiedGenus, unsatisfiedDifferentia);
            var output = unit.WhyUnsatisfiedBy(inputCandidate);
            Assert.AreEqual(unsatisfiedReason, output);
        }

        class DummyDefinition : Definition<object>
        {
            private readonly Func<object, bool> differentia;

            public DummyDefinition(ISpecification<object> genus, Func<object, bool> differentia)
                : base(genus)
            {
                this.differentia = differentia;
            }

            protected override bool HasOwnDifferentiaSatisfiedBy(object candidate)
            {
                return this.differentia(candidate);
            }
        }
    }
}
