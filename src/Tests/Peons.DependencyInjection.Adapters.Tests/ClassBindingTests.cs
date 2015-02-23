using NUnit.Framework;

namespace Peons.DependencyInjection.Adapters
{
    [TestFixture]
    public class ClassBindingTests
    {
        [Test]
        public void Ctor_TypeArgs_CanGetLater()
        {
            var unit = new ClassBinding<object, int>();
            Assert.AreEqual(typeof(object), unit.RequestedType);
            Assert.AreEqual(typeof(int), unit.ResolvedType);
        }

        [Test]
        public void Ctor_Scope_CanGetLater()
        {
            var inputScopes = new Scope[] { Scope.Singleton, Scope.Transient };
            foreach (var input in inputScopes)
            {
                var unit = new ClassBinding<object, bool>(input);
                Assert.AreEqual(input, unit.Scope);
            }
        }

        [Test]
        public void Ctor_NoScope_DefaultsToDefault()
        {
            var unit = new ClassBinding<object, string>();
            Assert.AreEqual(Scope.Singleton, unit.Scope);
        }

        [Test]
        public void Ctor_AnyArgs_ConstantIsNull()
        {
            var unitA = new ClassBinding<object, string>();
            var unitB = new ClassBinding<object, int>(Scope.Transient);
            Assert.IsNull(unitA.Constant);
            Assert.IsNull(unitB.Constant);
        }
    }
}
