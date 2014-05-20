using NUnit.Framework;
using System;
using System.Linq;

namespace Peons.NUnit
{
	[TestFixture]
    public class DummiesTests
    {
		[Test]
		public void GetEnumValues_ReturnsAllPossibleValuesOfTypeParameter()
		{
			var output = Dummies.GetEnumValues<DateTimeKind>();
			Assert.AreEqual(3, output.Count());
			Assert.IsTrue(output.Contains(DateTimeKind.Local));
			Assert.IsTrue(output.Contains(DateTimeKind.Unspecified));
			Assert.IsTrue(output.Contains(DateTimeKind.Utc));
		}

		[Test]
		public void Of_SupportedType_ReturnsDummies()
		{
			var output = Dummies.Of<int>();
			Assert.AreEqual(Dummies.Ints, output);
		}

		[Test]
		public void Of_SupportedEnumType_ReturnsDummies()
		{
			var output = Dummies.Of<DateTimeKind>();
			Assert.AreEqual(3, output.Count());
			Assert.IsTrue(output.Contains(DateTimeKind.Local));
			Assert.IsTrue(output.Contains(DateTimeKind.Unspecified));
			Assert.IsTrue(output.Contains(DateTimeKind.Utc));
		}

		[Test]
		public void Of_UnsupportedType_ThrowsException()
		{
			var action = new TestDelegate(() => Dummies.Of<DummylessType>());
			Assert.Throws<ArgumentException>(action);
		}

		struct DummylessType { }
    }
}
