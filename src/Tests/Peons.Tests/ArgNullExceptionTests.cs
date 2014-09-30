using NUnit.Framework;

namespace Peons
{
    [TestFixture]
    public class ArgNullExceptionTests
    {
        [Test]
        public void ctor_MemberExpression_CanGetParamNameLater()
        {
			object argument = null;
            var output = new ArgNullException(() => argument);
			Assert.AreEqual("argument", output.ParamName);
        }

		[Test]
		public void ctor_UnaryExpression_CanGetParamNameLater()
		{
			var output = GenericArgMethod<object>(null);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_MemberExpressionAndMessage_CanGetLater()
		{
			object argument = null;
			var expectedMessage = "foobar";
			var output = new ArgNullException(() => argument, expectedMessage);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual("argument", output.ParamName);
			Assert.AreEqual(0, index);
		}

		[Test]
		public void ctor_UnaryExpressionAndMessage_CanGetLater()
		{
			object input = null;
			var expectedMessage = "foobar";
			var output = this.GenericArgMethod(input, expectedMessage);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual("argument", output.ParamName);
			Assert.AreEqual(0, index);
		}

		private ArgNullException GenericArgMethod<T>(T argument)
		{
			return new ArgNullException(() => argument);
		}

		private ArgNullException GenericArgMethod<T>(T argument, string message)
		{
			return new ArgNullException(() => argument, message);
		}
	}
}
