using Moq;
using Ninject;
using Ninject.Activation;
using Ninject.Parameters;
using Ninject.Syntax;
using NUnit.Framework;
using System.Collections.Generic;

namespace Peons.DiContainers.Ninject.Tests
{
    [TestFixture]
    public class NinjectContainerTests
    {
        NinjectContainer unit;

        Mock<IKernel> kernelMock;
        Mock<IRequest> requestMock;

        [SetUp]
        protected void Setup()
        {
            requestMock = new Mock<IRequest>();
            kernelMock = new Mock<IKernel>();
            kernelMock
                .Setup(m => m.CreateRequest(typeof(object), null, It.IsAny<IEnumerable<IParameter>>(), false, true))
                .Returns(requestMock.Object);
            unit = new NinjectContainer(kernelMock.Object);
        }

        [Test]
        public void Resolve_GetsFromKernel()
        {
            var expected = new object();
            kernelMock
                .Setup(m => m.Resolve(requestMock.Object))
                .Returns(() => new object[] { expected });
            var output = unit.Resolve<object>();
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void Bind_TrueSingletonScope_BindsInSingletonScopeAndReturnsContainer()
        {
            var scopeSyntaxMock = new Mock<IBindingWhenInNamedWithOrOnSyntax<object>>();
            var toSyntaxMock = new Mock<IBindingToSyntax<object>>();
            toSyntaxMock
                .Setup(m => m.To<object>())
                .Returns(scopeSyntaxMock.Object);
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toSyntaxMock.Object);
            var output = unit.Bind<object, object>(true);
            scopeSyntaxMock
                .Verify(m => m.InSingletonScope());
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Bind_NoArgs_BindsInSingletonScopeAndReturnsContainer()
        {
            var scopeSyntaxMock = new Mock<IBindingWhenInNamedWithOrOnSyntax<object>>();
            var toSyntaxMock = new Mock<IBindingToSyntax<object>>();
            toSyntaxMock
                .Setup(m => m.To<object>())
                .Returns(scopeSyntaxMock.Object);
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toSyntaxMock.Object);
            var output = unit.Bind<object, object>();
            scopeSyntaxMock
                .Verify(m => m.InSingletonScope());
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Bind_False_BindsInTransientScopeAndReturnsContainer()
        {
            var scopeSyntaxMock = new Mock<IBindingWhenInNamedWithOrOnSyntax<object>>();
            var toSyntaxMock = new Mock<IBindingToSyntax<object>>();
            toSyntaxMock
                .Setup(m => m.To<object>())
                .Returns(scopeSyntaxMock.Object);
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toSyntaxMock.Object);
            var output = unit.Bind<object, object>(false);
            scopeSyntaxMock
                .Verify(m => m.InTransientScope());
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Bind_Constant_BindsConstantAndReturnsContainer()
        {
            var input = new object();
            var toConstantSyntaxMock = new Mock<IBindingToSyntax<object>>();
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toConstantSyntaxMock.Object);
            var output = unit.Bind<object>(input);
            toConstantSyntaxMock
                .Verify(m => m.ToConstant(input));
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Register_BindingInSingletonScope_BindsInSingletonScopeAndReturnsContainer()
        {
            var scopeSyntaxMock = new Mock<IBindingWhenInNamedWithOrOnSyntax<object>>();
            var toSyntaxMock = new Mock<IBindingToSyntax<object>>();
            toSyntaxMock
                .Setup(m => m.To<object>())
                .Returns(scopeSyntaxMock.Object);
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toSyntaxMock.Object);
            var input = new Binding<object, object>(true);
            var output = unit.Register(input);
            scopeSyntaxMock
                .Verify(m => m.InSingletonScope());
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Register_BindingInTransientScope_BindsInTransientScopeAndReturnsContainer()
        {
            var scopeSyntaxMock = new Mock<IBindingWhenInNamedWithOrOnSyntax<object>>();
            var toSyntaxMock = new Mock<IBindingToSyntax<object>>();
            toSyntaxMock
                .Setup(m => m.To<object>())
                .Returns(scopeSyntaxMock.Object);
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toSyntaxMock.Object);
            var input = new Binding<object, object>(false);
            var output = unit.Register(input);
            scopeSyntaxMock
                .Verify(m => m.InTransientScope());
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Register_BindingWithConstant_BindsConstantAndReturnsContainer()
        {
            var inputConstant = new object();
            var toConstantSyntaxMock = new Mock<IBindingToSyntax<object>>();
            kernelMock
                .Setup(m => m.Bind<object>())
                .Returns(toConstantSyntaxMock.Object);
            var input = new Binding<object>(inputConstant);
            var output = unit.Register(input);
            toConstantSyntaxMock
                .Verify(m => m.ToConstant(inputConstant));
            Assert.AreEqual(unit, output);
        }

        [Test]
        public void Register_BindingModule_RegistersModuleAndReturnsContainer()
        {
            var moduleMock = new Mock<IBindingModule>();
            var input = moduleMock.Object;
            var output = unit.Register(input);
            moduleMock.Verify(m => m.RegisterWith(unit));
            Assert.AreEqual(unit, output);
        }
    }
}
