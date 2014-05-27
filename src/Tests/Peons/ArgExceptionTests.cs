using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peons
{
	[TestFixture]
	class ArgExceptionTests
	{
		[Test]
		public void ctor_MessageAndMemberExpression_CanGetLater()
		{
			var expectedMessage = "foobar";
			object argument = null;
			var output = new ArgException(expectedMessage, () => argument);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_MessageAndMemberExpressionAndInnerException_CanGetLater()
		{
			var expectedMessage = "foobar";
			object argument = null;
			var expectedException = new Exception();
			var output = new ArgException(expectedMessage, () => argument, expectedException);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
			Assert.AreEqual(expectedException, output.InnerException);
		}

		[Test]
		public void ctor_MessageAndUnaryExpression_CanGetLater()
		{
			var expectedMessage = "foobar";
			object input = null;
			var output = this.GenericMethod(expectedMessage, input);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_MessageAndUnaryExpressionAndInnerException_CanGetLater()
		{
			var expectedMessage = "foobar";
			object input = null;
			var expectedException = new Exception();
			var output = this.GenericMethod(expectedMessage, input, expectedException);
			var index = output.Message.IndexOf(expectedMessage);
			Assert.AreEqual(0, index);
			Assert.AreEqual("argument", output.ParamName);
			Assert.AreEqual(expectedException, output.InnerException);
		}

		public ArgException GenericMethod<T>(string message, T argument)
		{
			return new ArgException(message, () => argument);
		}

		public ArgException GenericMethod<T>(string message, T argument, Exception innerException)
		{
			return new ArgException(message, () => argument, innerException);
		}
	}
}
