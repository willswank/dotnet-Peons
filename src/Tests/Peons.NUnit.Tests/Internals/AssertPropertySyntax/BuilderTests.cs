using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	[TestFixture]
	class BuilderTests
	{
		Builder<object> unit;

		[SetUp]
		protected void Setup()
		{
			unit = new Builder<object>();
		}

		[Test]
		public void Inputs_AnyEnumerable_CanSetAndGet()
		{
			var input = Dummies.Of.Object();
			unit.Inputs = input;
			var output = unit.Inputs;
			Assert.AreEqual(input, output);
		}

		[Test]
		public void Setter_AnyAction_CanSetAndGet()
		{
			var input = new Action<object>(o => {});
			unit.Setter = input;
			var output = unit.Setter;
			Assert.AreEqual(input, output);
		}
	}
}
