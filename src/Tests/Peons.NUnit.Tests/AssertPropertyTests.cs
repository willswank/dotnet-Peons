using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Peons.NUnit.Internals;
using Peons.NUnit.Internals.AssertPropertySyntax;

namespace Peons.NUnit
{
    [TestFixture]
    public class AssertPropertyTests
    {
		[Test]
		public void With_NullEnumerable_ThrowsException()
		{
			var action = new TestDelegate(() =>
					AssertProperty.With((IEnumerable<object>)null));
			Assert.Throws<ArgumentNullException>(action);
		}

		[Test]
		public void With_EmptyEnumerable_ThrowsException()
		{
			var action = new TestDelegate(() =>
					AssertProperty.With(new object[] { }));
			Assert.Throws<ArgumentException>(action);
		}

		[Test]
		public void With_NonEmptyEnumerable_ReturnsSyntaxResultWithBuilderWith()
		{
			var inputs = new object[] { new object() };
			var result = AssertProperty.With(inputs);
			var output = (result as SyntaxResult<object>).Builder;
			Assert.AreEqual(inputs, output.Inputs);
		}

		[Test]
		public void With_MultipleParams_ReturnsSyntaxResultWithBuilderWithAllInputs()
		{
			var inputA = new object();
			var inputB = new object();
			var inputC = new object();
			var result = AssertProperty.With(inputA, inputB, inputC);
			var output = (result as SyntaxResult<object>).Builder;
			Assert.AreEqual(3, output.Inputs.Count());
			Assert.IsTrue(output.Inputs.Contains(inputA));
			Assert.IsTrue(output.Inputs.Contains(inputB));
			Assert.IsTrue(output.Inputs.Contains(inputC));
		}
    }
}
