using NUnit.Framework;

namespace Peons
{
    [TestFixture]
	public class UnrecognizedValueExceptionTests
    {
        [Test]
		public void ctor_TargetType_IsInMessage()
		{
			var output = new UnrecognizedValueException<object, string>(null);
			Assert.IsTrue(output.Message.Contains(typeof(object).ToString()));
		}

		[Test]
		public void ctor_Value_IsInMessage()
		{
			var expected = "foobar";
			var output = new UnrecognizedValueException<object, string>(expected);
			Assert.IsTrue(output.Message.Contains(expected));
		}
    }
}
