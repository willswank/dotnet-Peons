using NUnit.Framework;

namespace Peons
{
    [TestFixture]
    class ObjectExtensionsTests
    {
        [Test]
        public void Has_FunctionResultingInNonNull_True()
        {
            var input = new DummyClass { DummyProperty = new object() };
            var output = input.Has(i => i.DummyProperty);
            Assert.IsTrue(output);
        }

        [Test]
        public void Has_FunctionResultingInNull_False()
        {
            var input = new DummyClass();
            var output = input.Has(i => i.DummyProperty);
            Assert.IsFalse(output);
        }

        class DummyClass
        {
            public object DummyProperty { get; set; }
        }
    }
}
