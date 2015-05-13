using NUnit.Framework;
using System;

namespace Peons.NUnit
{
    [TestFixture]
    class AssertGuardsTests
    {
        [Test]
        public void With1Arg_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object>()
                    .OfMethod((a) => new UnitWith1Arg(a))
                    .WithDefaults(new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With1Arg_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object>()
                .OfMethod((a) => new UnitWith1Arg(a))
                .WithDefaults(new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With2Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object>()
                    .OfMethod((a, b) => new UnitWith2Args(a, b))
                    .WithDefaults(new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With2Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object>()
                .OfMethod((a, b) => new UnitWith2Args(a, b))
                .WithDefaults(new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With3Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object>()
                    .OfMethod((a, b, c) => new UnitWith3Args(a, b, c))
                    .WithDefaults(new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With3Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object>()
                .OfMethod((a, b, c) => new UnitWith3Args(a, b, c))
                .WithDefaults(new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With4Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object>()
                    .OfMethod((a, b, c, d) => new UnitWith4Args(a, b, c, d))
                    .WithDefaults(new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With4Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object>()
                .OfMethod((a, b, c, d) => new UnitWith4Args(a, b, c, d))
                .WithDefaults(new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With5Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e) => new UnitWith5Args(a, b, c, d, e))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With5Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object>()
                .OfMethod((a, b, c, d, e) => new UnitWith5Args(a, b, c, d, e))
                .WithDefaults(new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With6Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f) => new UnitWith6Args(a, b, c, d, e, f))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With6Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f) => new UnitWith6Args(a, b, c, d, e, f))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With7Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g) => new UnitWith7Args(a, b, c, d, e, f, g))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With7Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g) => new UnitWith7Args(a, b, c, d, e, f, g))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With8Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h) => new UnitWith8Args(a, b, c, d, e, f, g, h))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With8Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h) => new UnitWith8Args(a, b, c, d, e, f, g, h))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With9Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i) => new UnitWith9Args(a, b, c, d, e, f, g, h, i))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With9Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i) => new UnitWith9Args(a, b, c, d, e, f, g, h, i))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With10Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i, j) => new UnitWith10Args(a, b, c, d, e, f, g, h, i, j))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With10Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i, j) => new UnitWith10Args(a, b, c, d, e, f, g, h, i, j))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>()
                .WhenArgJ(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With11Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i, j, k) => new UnitWith11Args(a, b, c, d, e, f, g, h, i, j, k))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With11Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i, j, k) => new UnitWith11Args(a, b, c, d, e, f, g, h, i, j, k))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>()
                .WhenArgJ(null)
                    .Throw<ArgumentNullException>()
                .WhenArgK(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With12Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l) => new UnitWith12Args(a, b, c, d, e, f, g, h, i, j, k, l))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With12Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l) => new UnitWith12Args(a, b, c, d, e, f, g, h, i, j, k, l))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>()
                .WhenArgJ(null)
                    .Throw<ArgumentNullException>()
                .WhenArgK(null)
                    .Throw<ArgumentNullException>()
                .WhenArgL(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With13Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l, m) => new UnitWith13Args(a, b, c, d, e, f, g, h, i, j, k, l, m))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With13Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l, m) => new UnitWith13Args(a, b, c, d, e, f, g, h, i, j, k, l, m))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>()
                .WhenArgJ(null)
                    .Throw<ArgumentNullException>()
                .WhenArgK(null)
                    .Throw<ArgumentNullException>()
                .WhenArgL(null)
                    .Throw<ArgumentNullException>()
                .WhenArgM(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With14Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l, m, n) => new UnitWith14Args(a, b, c, d, e, f, g, h, i, j, k, l, m, n))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With14Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l, m, n) => new UnitWith14Args(a, b, c, d, e, f, g, h, i, j, k, l, m, n))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>()
                .WhenArgJ(null)
                    .Throw<ArgumentNullException>()
                .WhenArgK(null)
                    .Throw<ArgumentNullException>()
                .WhenArgL(null)
                    .Throw<ArgumentNullException>()
                .WhenArgM(null)
                    .Throw<ArgumentNullException>()
                .WhenArgN(null)
                    .Throw<ArgumentNullException>();
        }

        [Test]
        public void With15Args_WhenExpectedExceptionNotThrown_ThrowException()
        {
            var action = new TestDelegate(() =>
            {
                AssertGuards
                    .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>()
                    .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => new UnitWith15Args(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o))
                    .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                    .WhenArgA(new object())
                        .Throw<ArgumentNullException>();
            });
            Assert.Throws<AssertionException>(action);
        }

        [Test]
        public void With15Args_WhenExpectedExceptionsThrown_Okay()
        {
            AssertGuards
                .ForSignature<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>()
                .OfMethod((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => new UnitWith15Args(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o))
                .WithDefaults(new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object(), new object())
                .WhenArgA(null)
                    .Throw<ArgumentNullException>()
                .WhenArgB(null)
                    .Throw<ArgumentNullException>()
                .WhenArgC(null)
                    .Throw<ArgumentNullException>()
                .WhenArgD(null)
                    .Throw<ArgumentNullException>()
                .WhenArgE(null)
                    .Throw<ArgumentNullException>()
                .WhenArgF(null)
                    .Throw<ArgumentNullException>()
                .WhenArgG(null)
                    .Throw<ArgumentNullException>()
                .WhenArgH(null)
                    .Throw<ArgumentNullException>()
                .WhenArgI(null)
                    .Throw<ArgumentNullException>()
                .WhenArgJ(null)
                    .Throw<ArgumentNullException>()
                .WhenArgK(null)
                    .Throw<ArgumentNullException>()
                .WhenArgL(null)
                    .Throw<ArgumentNullException>()
                .WhenArgM(null)
                    .Throw<ArgumentNullException>()
                .WhenArgN(null)
                    .Throw<ArgumentNullException>()
                .WhenArgO(null)
                    .Throw<ArgumentNullException>();
        }

        class UnitWith1Arg
        {
            public UnitWith1Arg(object a)
            {
                if (a == null)
                {
                    throw new ArgumentNullException("a");
                }
            }
        }

        class UnitWith2Args : UnitWith1Arg
        {
            public UnitWith2Args(object a, object b)
                : base(a)
            {
                if (b == null)
                {
                    throw new ArgumentNullException("b");
                }
            }
        }

        class UnitWith3Args : UnitWith2Args
        {
            public UnitWith3Args(object a, object b, object c)
                : base(a, b)
            {
                if (c == null)
                {
                    throw new ArgumentNullException("c");
                }
            }
        }

        class UnitWith4Args : UnitWith3Args
        {
            public UnitWith4Args(object a, object b, object c, object d)
                : base(a, b, c)
            {
                if (d == null)
                {
                    throw new ArgumentNullException("d");
                }
            }
        }

        class UnitWith5Args : UnitWith4Args
        {
            public UnitWith5Args(object a, object b, object c, object d, object e)
                : base(a, b, c, d)
            {
                if (e == null)
                {
                    throw new ArgumentNullException("e");
                }
            }
        }

        class UnitWith6Args : UnitWith5Args
        {
            public UnitWith6Args(object a, object b, object c, object d, object e, object f)
                : base(a, b, c, d, e)
            {
                if (f == null)
                {
                    throw new ArgumentNullException("f");
                }
            }
        }

        class UnitWith7Args : UnitWith6Args
        {
            public UnitWith7Args(object a, object b, object c, object d, object e, object f, object g)
                : base(a, b, c, d, e, f)
            {
                if (g == null)
                {
                    throw new ArgumentNullException("g");
                }
            }
        }

        class UnitWith8Args : UnitWith7Args
        {
            public UnitWith8Args(object a, object b, object c, object d, object e, object f, object g, object h)
                : base(a, b, c, d, e, f, g)
            {
                if (h == null)
                {
                    throw new ArgumentNullException("h");
                }
            }
        }

        class UnitWith9Args : UnitWith8Args
        {
            public UnitWith9Args(object a, object b, object c, object d, object e, object f, object g, object h, object i)
                : base(a, b, c, d, e, f, g, h)
            {
                if (h == null)
                {
                    throw new ArgumentNullException("h");
                }
                if (i == null)
                {
                    throw new ArgumentNullException("i");
                }
            }
        }

        class UnitWith10Args : UnitWith9Args
        {
            public UnitWith10Args(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j)
                : base(a, b, c, d, e, f, g, h, i)
            {
                if (j == null)
                {
                    throw new ArgumentNullException("j");
                }
            }
        }

        class UnitWith11Args : UnitWith10Args
        {
            public UnitWith11Args(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j, object k)
                : base(a, b, c, d, e, f, g, h, i, j)
            {
                if (k == null)
                {
                    throw new ArgumentNullException("k");
                }
            }
        }

        class UnitWith12Args : UnitWith11Args
        {
            public UnitWith12Args(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j, object k, object l)
                : base(a, b, c, d, e, f, g, h, i, j, k)
            {
                if (l == null)
                {
                    throw new ArgumentNullException("l");
                }
            }
        }

        class UnitWith13Args : UnitWith12Args
        {
            public UnitWith13Args(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j, object k, object l, object m)
                : base(a, b, c, d, e, f, g, h, i, j, k, l)
            {
                if (m == null)
                {
                    throw new ArgumentNullException("m");
                }
            }
        }

        class UnitWith14Args : UnitWith13Args
        {
            public UnitWith14Args(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j, object k, object l, object m, object n)
                : base(a, b, c, d, e, f, g, h, i, j, k, l, m)
            {
                if (n == null)
                {
                    throw new ArgumentNullException("n");
                }
            }
        }

        class UnitWith15Args : UnitWith14Args
        {
            public UnitWith15Args(object a, object b, object c, object d, object e, object f, object g, object h, object i, object j, object k, object l, object m, object n, object o)
                : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n)
            {
                if (o == null)
                {
                    throw new ArgumentNullException("o");
                }
            }
        }
    }
}
