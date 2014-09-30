using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals
{
	[TestFixture]
	class WithInputsSyntaxResultTests
	{
		WithInputsSyntaxResult<object> unit;

		[SetUp]
		protected void Setup()
		{
			var builder = new Builder<object>();
			unit = new WithInputsSyntaxResult<object>(builder);
		}

		[Test]
		public void SetVia_Null_ThrowsException()
		{
			var action = new TestDelegate(() =>
					unit.SetVia(null));
			Assert.Throws<ArgumentNullException>(action);
		}

		[Test]
		public void SetVia_NonNullSetter_ReturnsSyntaxResultWithBuilderWithSetter()
		{
			var input = new Action<object>(o => {});
			var result = unit.SetVia(input);
			var output = (result as SyntaxResult<object>).Builder;
			Assert.AreEqual(input, output.Setter);
		}
	}
}
