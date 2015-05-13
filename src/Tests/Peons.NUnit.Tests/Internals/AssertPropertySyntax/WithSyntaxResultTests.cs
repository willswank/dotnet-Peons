using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	[TestFixture]
	class WithSyntaxResultTests
	{
		WithSyntaxResult<object> unit;

		[SetUp]
		protected void Setup()
		{
			var builder = new Builder<object>();
			unit = new WithSyntaxResult<object>(builder);
		}

		[Test]
		public void SetBy_Null_ThrowsException()
		{
			var action = new TestDelegate(() =>
					unit.CanSetBy(null));
			Assert.Throws<ArgumentNullException>(action);
		}

		[Test]
		public void SetBy_NonNullSetter_ReturnsSyntaxResultWithBuilderWithSetter()
		{
			var input = new Action<object>(o => {});
			var result = unit.CanSetBy(input);
			var output = (result as SyntaxResult<object>).Builder;
			Assert.AreEqual(input, output.Setter);
		}
	}
}
