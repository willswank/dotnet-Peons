using NUnit.Framework;

namespace Peons.DotNet
{
    [TestFixture]
    public class ArgNullExceptionTests
    {
        [Test]
        public void ctor_MemberExpression_CanGetMemberNameLater()
        {
			object argument = null;
            var output = new ArgNullException(() => argument);
			Assert.AreEqual("argument", output.ParamName);
        }

		[Test]
		public void ctor_UnaryExpression_CanGetMemberNameLater()
		{
			var output = GenericArgMethod<object>(null);
			Assert.AreEqual("argument", output.ParamName);
		}

		[Test]
		public void ctor_Message_CanGetLater()
		{
			object dummy = null;
			var expected = "foobar";
			var output = new ArgNullException(() => dummy, expected);
			var index = output.Message.IndexOf(expected);
			Assert.AreEqual(0, index);
		}

		private ArgNullException GenericArgMethod<T>(T argument)
		{
			return new ArgNullException(() => argument);
		}
    }
}
