using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peons.Specification
{
    [TestFixture]
    class DependentSpecificationTests
    {
        DependentSpecification<object> unit;

        [Test]
        public void ctor_NullPrerequisites_ThrowsException()
        {
            ISpecification<object>[] input = null;
            var action = new TestDelegate(()
                => new DummyDependentSpecification(input));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_EmptyPrerequisites_ThrowsException()
        {
            ISpecification<object>[] input = new ISpecification<object>[] { };
            var action = new TestDelegate(()
                => new DummyDependentSpecification(input));
            Assert.Throws<ArgEmptyException>(action);
        }

        [Test]
        public void WhyUnsatisfiedBy_AllPrerequisitesSatisfied_ReturnsNull()
        {
            var inputCandidate = new object();
            var satisfiedIndependentSpecMock = new Mock<ISpecification<object>>();
            var satisfiedDependentSpecMock = new Mock<IDependentSpecification<object>>();
            satisfiedIndependentSpecMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            satisfiedDependentSpecMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns<ISpecification<object>>(null);
            var satisfiedIndependentSpec = satisfiedIndependentSpecMock.Object;
            var satisfiedDependentSpec = satisfiedDependentSpecMock.Object;
            
            // Various combinations of satisfied specs.

            var inputSpecSets = new ISpecification<object>[][]
            {
                new ISpecification<object>[]
                {
                    satisfiedIndependentSpec,
                    satisfiedDependentSpec,
                    satisfiedIndependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedDependentSpec,
                    satisfiedIndependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedIndependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedDependentSpec
                }
            };

            foreach (var inputSpecs in inputSpecSets)
            {
                unit = new DummyDependentSpecification(inputSpecs);
                var output = unit.WhyUnsatisfiedBy(inputCandidate);
                Assert.IsNull(output);
            }
        }

        [Test]
        public void WhyUnsatisfiedBy_UnsatisfiedPrerequisitesWithFirstBeingIndependent_ReturnsFirstUnsatisfiedPrerequisite()
        {
            var inputCandidate = new object();
            var unsatisfiedReasonMock = new Mock<ISpecification<object>>();
            var unsatisfiedReason = unsatisfiedReasonMock.Object;
            var satisfiedIndependentSpecMock = new Mock<ISpecification<object>>();
            var unsatisfiedIndependentSpecMock = new Mock<ISpecification<object>>();
            var satisfiedDependentSpecMock = new Mock<IDependentSpecification<object>>();
            var unsatisfiedDependentSpecMock = new Mock<IDependentSpecification<object>>();
            satisfiedIndependentSpecMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            unsatisfiedIndependentSpecMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            satisfiedDependentSpecMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns<ISpecification<object>>(null);
            unsatisfiedDependentSpecMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns(unsatisfiedReason);
            var satisfiedIndependentSpec = satisfiedIndependentSpecMock.Object;
            var unsatisfiedIndependentSpec = unsatisfiedIndependentSpecMock.Object;
            var satisfiedDependentSpec = satisfiedDependentSpecMock.Object;
            var unsatisfiedDependentSpec = unsatisfiedDependentSpecMock.Object;

            // Various combinations of prerequisites first dissatisfied by an
            // independent spec.

            var inputSpecSets = new ISpecification<object>[][]
            {
                new ISpecification<object>[]
                {
                    unsatisfiedIndependentSpec
                },
                new ISpecification<object>[]
                {
                    unsatisfiedIndependentSpec,
                    unsatisfiedDependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedIndependentSpec,
                    satisfiedDependentSpec,
                    unsatisfiedIndependentSpec,
                    unsatisfiedDependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedDependentSpec,
                    unsatisfiedIndependentSpec,
                    satisfiedDependentSpec
                }
            };

            foreach (var inputSpecs in inputSpecSets)
            {
                unit = new DummyDependentSpecification(inputSpecs);
                var output = unit.WhyUnsatisfiedBy(inputCandidate);
                Assert.AreEqual(unsatisfiedIndependentSpec, output);
            }
        }

        [Test]
        public void WhyUnsatisfiedBy_UnsatisfiedPrerequisitesWithFirstBeingDependent_ReturnsReasonForFirstUnsatisfiedPrerequisite()
        {
            var inputCandidate = new object();
            var unsatisfiedReasonMock = new Mock<ISpecification<object>>();
            var unsatisfiedReason = unsatisfiedReasonMock.Object;
            var satisfiedIndependentSpecMock = new Mock<ISpecification<object>>();
            var unsatisfiedIndependentSpecMock = new Mock<ISpecification<object>>();
            var satisfiedDependentSpecMock = new Mock<IDependentSpecification<object>>();
            var unsatisfiedDependentSpecMock = new Mock<IDependentSpecification<object>>();
            satisfiedIndependentSpecMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(true);
            unsatisfiedIndependentSpecMock
                .Setup(m => m.IsSatisfiedBy(inputCandidate))
                .Returns(false);
            satisfiedDependentSpecMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns<ISpecification<object>>(null);
            unsatisfiedDependentSpecMock
                .Setup(m => m.WhyUnsatisfiedBy(inputCandidate))
                .Returns(unsatisfiedReason);
            var satisfiedIndependentSpec = satisfiedIndependentSpecMock.Object;
            var unsatisfiedIndependentSpec = unsatisfiedIndependentSpecMock.Object;
            var satisfiedDependentSpec = satisfiedDependentSpecMock.Object;
            var unsatisfiedDependentSpec = unsatisfiedDependentSpecMock.Object;

            // Various combinations of prerequisites first dissatisfied by an
            // independent spec.

            var inputSpecSets = new ISpecification<object>[][]
            {
                new ISpecification<object>[]
                {
                    unsatisfiedDependentSpec
                },
                new ISpecification<object>[]
                {
                    unsatisfiedDependentSpec,
                    unsatisfiedIndependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedDependentSpec,
                    satisfiedIndependentSpec,
                    unsatisfiedDependentSpec,
                    unsatisfiedIndependentSpec
                },
                new ISpecification<object>[]
                {
                    satisfiedDependentSpec,
                    unsatisfiedDependentSpec,
                    satisfiedIndependentSpec
                }
            };

            foreach (var inputSpecs in inputSpecSets)
            {
                unit = new DummyDependentSpecification(inputSpecs);
                var output = unit.WhyUnsatisfiedBy(inputCandidate);
                Assert.AreEqual(unsatisfiedReason, output);
            }
        }

        class DummyDependentSpecification : DependentSpecification<object>
        {
            private readonly Func<object, bool> individualSatisfactionTest;

            public DummyDependentSpecification(ISpecification<object>[] prerequisites)
                : this(prerequisites, null)
            {
            }

            public DummyDependentSpecification(ISpecification<object>[] prerequisites, Func<object, bool> individualSatisfactionTest)
                : base(prerequisites)
            {
                this.individualSatisfactionTest = individualSatisfactionTest;
            }

            protected override bool IsIndividuallySatisfiedBy(object candidate)
            {
                if (this.individualSatisfactionTest == null)
                {
                    return true;
                }
                return this.individualSatisfactionTest(candidate);
            }
        }
    }
}
