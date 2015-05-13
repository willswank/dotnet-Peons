using NUnit.Framework;
using System;
using System.Linq;

namespace Peons.NUnit
{
	[TestFixture]
    public class DummiesTests
    {
		[Test]
		public void Enum_EnumType_ReturnsAllEnumValues()
		{
            var expectedValues = Enum.GetValues(typeof(DateTimeKind))
                .Cast<DateTimeKind>().ToArray();
			var output = Dummies.Of.Enum<DateTimeKind>();
			Assert.AreEqual(3, output.Count());
            foreach (var expectedValue in expectedValues)
            {
                Assert.IsTrue(output.Contains(expectedValue));
            }
		}

		[Test]
		public void Enum_NonEnumType_ThrowsException()
		{
			var action = new TestDelegate(() => Dummies.Of.Enum<NonEnumType>());
			Assert.Throws<ArgumentException>(action);
		}

		struct NonEnumType { }
    }
}
