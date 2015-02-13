using NUnit.Framework;

namespace Peons.DependencyInjection
{
    [TestFixture]
    public class ConstantBindingTests
    {
        [Test]
        public void Ctor_Null_ThrowsException()
        {
            var action = new TestDelegate(()
                => new ConstantBinding<object>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Ctor_Constant_CanGetLater()
        {
            var inputConstants = new int[] { 4, 8, 15, 16, 23, 42 };
            foreach (var input in inputConstants)
            {
                var unit = new ConstantBinding<object>(input);
                var output = (int)unit.Constant;
                Assert.AreEqual(input, output);
            }
        }

        [Test]
        public void Ctor_RequestedTypeArg_CanGetLater()
        {
            var unitA = new ConstantBinding<object>(new object());
            var unitB = new ConstantBinding<int>(42);
            Assert.AreEqual(typeof(object), unitA.RequestedType);
            Assert.AreEqual(typeof(int), unitB.RequestedType);
        }

        [Test]
        public void Ctor_AnyArgs_ResolvedTypeIsNullAndScopeIsDefault()
        {
            var units = new IBinding[]
            {
                new ConstantBinding<object>(new object()),
                new ConstantBinding<int>(42),
                new ConstantBinding<string>(string.Empty)
            };
            foreach (var unit in units)
            {
                Assert.AreEqual(null, unit.ResolvedType);
                Assert.AreEqual(Scope.Singleton, unit.Scope);
            }
        }
    }
}
