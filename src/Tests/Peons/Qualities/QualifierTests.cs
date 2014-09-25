using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Peons.Qualities
{
    [TestFixture]
    class QualifierTests
    {
        Qualifier<int> unit;

        [Test]
        public void ctor_NullQualities_ThrowsException()
        {
            var action = new TestDelegate(() => unit = new Qualifier<int>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_Qualities_CanGetLater()
        {
            var input = new IQuality<int>[] { };
            unit = new Qualifier<int>(input);
            Assert.AreEqual(input, unit.Qualities);
        }

        [Test]
        public void ctor_Qualify_AppliesEachQualityToTarget()
        {
            var qualityMocks = new List<Mock<IQuality<int>>>();
            for (var i = 0; i < 5; i++)
            {
                qualityMocks.Add(new Mock<IQuality<int>>());
            }
            var inputQualities = qualityMocks.Select(m => m.Object);
            unit = new Qualifier<int>(inputQualities);
            var inputTarget = 42;
            unit.Qualify(inputTarget).ToArray();
            foreach (var mock in qualityMocks)
            {
                mock.Verify(m => m.AppliesTo(inputTarget));
            }
        }

        [Test]
        public void ctor_Qualify_ReturnsOnlyQualitiesThatApply()
        {
            var applicableQualityMock = new Mock<IQuality<int>>();
            applicableQualityMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(true);
            var nonApplicableQualityMock = new Mock<IQuality<int>>();
            nonApplicableQualityMock.Setup(m => m.AppliesTo(It.IsAny<int>()))
                .Returns(false);
            var inputQualities = new IQuality<int>[]
            {
                applicableQualityMock.Object,
                nonApplicableQualityMock.Object
            };
            unit = new Qualifier<int>(inputQualities);
            var output = unit.Qualify(42);
            Assert.IsTrue(output.Contains(applicableQualityMock.Object));
            Assert.IsFalse(output.Contains(nonApplicableQualityMock.Object));
        }
    }
}
