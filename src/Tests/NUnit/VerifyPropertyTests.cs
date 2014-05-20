using Peons.NUnit.Internals;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peons.NUnit
{
    [TestFixture]
    public class VerifyPropertyTests
    {
		[Test]
		public void WithInputs_NullEnumerable_ThrowsException()
		{
			var action = new TestDelegate(() =>
					VerifyProperty.WithInputs((IEnumerable<object>)null));
			Assert.Throws<ArgumentNullException>(action);
		}

		[Test]
		public void WithInputs_EmptyEnumerable_ThrowsException()
		{
			var action = new TestDelegate(() =>
					VerifyProperty.WithInputs(new object[] { }));
			Assert.Throws<ArgumentException>(action);
		}

		[Test]
		public void WithInputs_NonEmptyEnumerable_ReturnsSyntaxResultWithBuilderWithInputs()
		{
			var inputs = new object[] { new object() };
			var result = VerifyProperty.WithInputs(inputs);
			var output = (result as SyntaxResult<object>).Builder;
			Assert.AreEqual(inputs, output.Inputs);
		}

		[Test]
		public void WithInputs_MultipleParams_ReturnsSyntaxResultWithBuilderWithAllInputs()
		{
			var inputA = new object();
			var inputB = new object();
			var inputC = new object();
			var result = VerifyProperty.WithInputs(inputA, inputB, inputC);
			var output = (result as SyntaxResult<object>).Builder;
			Assert.AreEqual(3, output.Inputs.Count());
			Assert.IsTrue(output.Inputs.Contains(inputA));
			Assert.IsTrue(output.Inputs.Contains(inputB));
			Assert.IsTrue(output.Inputs.Contains(inputC));
		}

		[Test]
		public void WithDummies_SupportedType_ReturnsSyntaxResultWithBuilderWithDummyInputs()
		{
			var result = VerifyProperty.WithDummies<int>();
			var output = (result as SyntaxResult<int>).Builder;
			Assert.AreEqual(Dummies.Ints, output.Inputs);
		}

		[Test]
		public void WithNullableDummies_SupportedType_ReturnsSyntaxResultWithBuilderWithDummyInputs()
		{
			var result = VerifyProperty.WithNullableDummies<int>();
			var output = (result as SyntaxResult<int?>).Builder;
			foreach (var item in Dummies.Ints.AndNull())
			{
				Assert.IsTrue(output.Inputs.Contains(item));
			}
			Assert.IsTrue(output.Inputs.Contains(null));
		}
    }
}
