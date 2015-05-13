using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	[TestFixture]
	class CanSetBySyntaxResultTests
	{
		CanSetBySyntaxResult<object> unit;

		[SetUp]
		protected void Setup()
		{
			var builder = new Builder<object>();
			unit = new CanSetBySyntaxResult<object>(builder);
		}

		[Test]
		public void AndGetFrom_Null_ThrowsException()
		{
			var action = new TestDelegate(() => unit.AndGetFrom(null));
			Assert.Throws<ArgumentNullException>(action);
		}

		[Test]
		public void AndGetFrom_NonNullGetter_SucceedsWhenGetterGetsValueSetBySetter()
		{
			var inputObjects = new object[] { new object(), new object() };
			object setValue = null;
			var inputSetter = new Action<object>(v => setValue = v);
			var inputGetter = new Func<object>(() => setValue);

			unit.Builder.Inputs = inputObjects;
			unit.Builder.Setter = inputSetter;
			unit.AndGetFrom(inputGetter);
		}

		[Test]
		public void AndGetFrom_NonNullGetter_FailsWhenGetterGetsDifferentValueFromSetBySetter()
		{
			var inputObjects = new object[] { null };
			var inputSetter = new Action<object>(v => { });
			var inputGetter = new Func<object>(() => new object());

			unit.Builder.Inputs = inputObjects;
			unit.Builder.Setter = inputSetter;

			var action = new TestDelegate(() => unit.AndGetFrom(inputGetter));
			Assert.Throws<AssertionException>(action);
		}
	}
}
