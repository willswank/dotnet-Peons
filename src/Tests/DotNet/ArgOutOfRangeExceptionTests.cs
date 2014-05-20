using NUnit.Framework;

namespace Peons.DotNet
{
	[TestFixture]
	class ArgOutOfRangeExceptionTests
	{
		[Test]
		public void ctor_MemberExpression_CanGetLater()
		{
			object argument = null;
			var output = new ArgOutOfRangeException(() => argument);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_MemberExpressionAndMessage_CanGetLater()
		{
			var expectedMessage = "foobar";
			object argument = null;
			var output = new ArgOutOfRangeException(() => argument, expectedMessage);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_MemberExpressionAndActualValueAndMessage_CanGetLater()
		{
			var expectedMessage = "foo";
			string argument = "bar";
			var output = new ArgOutOfRangeException(() => argument, argument, expectedMessage);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
			Assert.AreEqual(argument, output.ActualValue);
		}

		[Test]
		public void ctor_UnaryExpression_CanGetLater()
		{
			object input = null;
			var output = this.GenericMethod(input);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_UnaryExpressionAndMessage_CanGetLater()
		{
			var expectedMessage = "foobar";
			object input = null;
			var output = this.GenericMethod(input, expectedMessage);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_UnaryExpressionAndActualValueAndMessage_CanGetLater()
		{
			var expectedMessage = "foo";
			string input = "bar";
			var output = this.GenericMethod(input, input, expectedMessage);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
			Assert.AreEqual(input, output.ActualValue);
		}
		
		public ArgOutOfRangeException GenericMethod<T>(T argument)
		{
			return new ArgOutOfRangeException(() => argument);
		}

		public ArgOutOfRangeException GenericMethod<T>(T argument, string message)
		{
			return new ArgOutOfRangeException(() => argument, message);
		}

		public ArgOutOfRangeException GenericMethod<T>(T argument, object actualValue, string message)
		{
			return new ArgOutOfRangeException(() => argument, actualValue, message);
		}
	}
}
