using NUnit.Framework;

namespace Peons
{
    [TestFixture]
    class ObjectExtensionsTests
    {
        [Test]
        public void Exists_Null_False()
        {
            object input = null;
            var output = input.Exists();
            Assert.IsFalse(output);
        }

        [Test]
        public void Exists_NonNull_True()
        {
            object input = new object();
            var output = input.Exists();
            Assert.IsTrue(output);
        }
    }
}
