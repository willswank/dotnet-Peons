using NUnit.Framework;
using Peons.NUnit;

namespace Peons
{
	[TestFixture]
	class ArgNotVisibleExceptionTests
	{
		ArgNotVisibleException unit;

		const string MESSAGE_FORMAT = "The argument, {0}, must contain visible characters but was {1}.";

		[Test]
		public void ctor_VisibleActualValue_ThrowsException()
		{
			foreach (var input in Dummies.VisibleStrings)
			{
				var action = new TestDelegate(() =>
						new ArgNotVisibleException(() => input, input));
				Assert.Throws<ArgOutOfRangeException>(action);
			}
		}

		[Test]
		public void ctor_NullActualValue_ExplainedInMessage()
		{
			string input = null;
			unit = new ArgNotVisibleException(() => input, input);
			string expected = string.Format(MESSAGE_FORMAT, "input", "null");
			Assert.IsTrue(unit.Message.Contains(expected));
		}

		[Test]
		public void ctor_EmptyActualValue_ExplainedInMessage()
		{
			string input = string.Empty;
			unit = new ArgNotVisibleException(() => input, input);
			string expected = string.Format(MESSAGE_FORMAT, "input", "empty");
			Assert.IsTrue(unit.Message.Contains(expected));
		}

		[Test]
		public void ctor_WhiteSpaceActualValue_ExplainedInMessage()
		{
			foreach (var input in Dummies.WhiteSpaceStrings)
			{
				unit = new ArgNotVisibleException(() => input, input);
				string expected = string.Format(MESSAGE_FORMAT, "input", "white space");
				Assert.IsTrue(unit.Message.Contains(expected));
			}
		}
	}
}
