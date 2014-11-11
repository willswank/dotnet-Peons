using NUnit.Framework;

namespace Peons.DiContainers.Tests
{
    [TestFixture]
    public class BindingTests
    {
        [Test]
        public void ctor_SingletonScope_CanGetLater()
        {
            var inputs = new bool[] { true, false };
            foreach (var input in inputs)
            {
                var output = new Binding<object, object>(input);
                Assert.AreEqual(input, output.InSingletonScope);
            }
        }

        [Test]
        public void ctor_NoArgs_SetsSingletonScopeToTrue()
        {
            var output = new Binding<object, object>();
            Assert.IsTrue(output.InSingletonScope);
        }

        [Test]
        public void ctor_NullConstant_ThrowsException()
        {
            var action = new TestDelegate(() => new Binding<object>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void ctor_Constant_CanGetLater()
        {
            var input = new object();
            var output = new Binding<object>(input);
            Assert.AreEqual(input, output.Constant);
        }
    }
}
