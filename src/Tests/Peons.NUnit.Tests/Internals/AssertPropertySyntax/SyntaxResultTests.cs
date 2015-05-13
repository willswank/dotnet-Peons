using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	[TestFixture]
	class SyntaxResultTests
	{
		SyntaxResult<object> unit;

		[SetUp]
		protected void Setup()
		{
			unit = null;
		}

		[Test]
		public void ctor_NullBuilder_ThrowsException()
		{
			var action = new TestDelegate(() =>
					unit = new ConcreteSyntaxResult<object>(null));
			Assert.Throws<ArgumentNullException>(action);

		}

		[Test]
		public void ctor_NonNullBuilder_CanGetLater()
		{
			var input = new Builder<object>();
			unit = new ConcreteSyntaxResult<object>(input);
			var output = unit.Builder;
			Assert.AreEqual(input, output);
		}

		class ConcreteSyntaxResult<T> : SyntaxResult<T>
		{
			public ConcreteSyntaxResult(Builder<T> builder) : base(builder) { }
		}
	}
}
