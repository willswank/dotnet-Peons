using NUnit.Framework;
using System.Linq;

namespace Peons.DependencyInjection
{
    [TestFixture]
    public class BindingBuilderTests
    {
        BindingBuilder unit;

        [SetUp]
        protected void Setup()
        {
            unit = new BindingBuilder();
        }

        [Test]
        public void Done_NoBindings_EmptyArray()
        {
            var output = unit.Finish();
            Assert.AreEqual(0, output.Length);
        }

        [Test]
        public void Class_NoScope_IncludesExpectedBinding()
        {
            unit.Class<IDummyA, DummyA>();
            var output = unit.Finish();
            var binding = output.Single();
            Assert.AreEqual(typeof(IDummyA), binding.RequestedType);
            Assert.AreEqual(typeof(DummyA), binding.ResolvedType);
            Assert.AreEqual(Scope.Singleton, binding.Scope);
            Assert.IsNull(binding.Constant);
        }

        [Test]
        public void Class_SpecifiedScope_IncludesExpectedBinding()
        {
            var inputScope = Scope.Transient;
            unit.Class<IDummyA, DummyA>(inputScope);
            var output = unit.Finish();
            var binding = output.Single();
            Assert.AreEqual(typeof(IDummyA), binding.RequestedType);
            Assert.AreEqual(typeof(DummyA), binding.ResolvedType);
            Assert.AreEqual(inputScope, binding.Scope);
            Assert.IsNull(binding.Constant);
        }

        [Test]
        public void Class_MultipleCalls_IncludesExpectedBindings()
        {
            var inputScopeA = Scope.Singleton;
            var inputScopeB = Scope.Transient;
            unit
                .Class<IDummyA, DummyA>(inputScopeA)
                .Class<IDummyB, DummyB>(inputScopeB);
            var output = unit.Finish();
            Assert.AreEqual(2, output.Length);
            Assert.AreEqual(1, output
                .Where(b =>
                    typeof(IDummyA) == b.RequestedType
                    && typeof(DummyA) == b.ResolvedType
                    && inputScopeA == b.Scope
                    && null == b.Constant)
                .Count());
            Assert.AreEqual(1, output
                .Where(b =>
                    typeof(IDummyB) == b.RequestedType
                    && typeof(DummyB) == b.ResolvedType
                    && inputScopeB == b.Scope
                    && null == b.Constant)
                .Count());
        }

        [Test]
        public void Const_Null_ThrowsException()
        {
            var action = new TestDelegate(() =>
                unit.Const<IDummyA>(null));
            Assert.Throws<ArgNullException>(action);
        }

        [Test]
        public void Const_Value_IncludesExpectedBinding()
        {
            var input = new DummyA();
            unit.Const<IDummyA>(input);
            var output = unit.Finish();
            var binding = output.Single();
            Assert.AreEqual(input, binding.Constant);
            Assert.AreEqual(typeof(IDummyA), binding.RequestedType);
            Assert.IsNull(binding.ResolvedType);
            Assert.AreEqual(Scope.Singleton, binding.Scope);
        }

        [Test]
        public void Const_MultipleCalls_IncludesExpectedBindings()
        {
            var inputA = new DummyA();
            var inputB = new DummyB();
            unit
                .Const<IDummyA>(inputA)
                .Const<IDummyB>(inputB);
            var output = unit.Finish();
            Assert.AreEqual(2, output.Length);
            Assert.AreEqual(1, output
                .Where(b =>
                    typeof(IDummyA) == b.RequestedType
                    && null == b.ResolvedType
                    && Scope.Singleton == b.Scope
                    && inputA == b.Constant)
                .Count());
            Assert.AreEqual(1, output
                .Where(b =>
                    typeof(IDummyB) == b.RequestedType
                    && null == b.ResolvedType
                    && Scope.Singleton == b.Scope
                    && inputB == b.Constant)
                .Count());
        }

        interface IDummyA { }
        interface IDummyB { }
        class DummyA : IDummyA { }
        class DummyB : IDummyB { }
    }
}
