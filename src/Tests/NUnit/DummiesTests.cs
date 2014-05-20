using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using unit = Peons.NUnit.Dummies;

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

		/*[Test]
		public void GetEnumValuesAndNull_ReturnsAllPossibleValuesOfTypeParameterAndNull()
		{
			var output = Dummies.GetEnumValuesAndNull<DateTimeKind>();
			Assert.AreEqual(4, output.Count());
			Assert.IsTrue(output.Contains(DateTimeKind.Local));
			Assert.IsTrue(output.Contains(DateTimeKind.Unspecified));
			Assert.IsTrue(output.Contains(DateTimeKind.Utc));
			Assert.IsTrue(output.Contains(null));
		}*/

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

		/*[Test]
		public void OfNullable_SupportedType_ReturnsDummies()
		{
			var output = Dummies.OfNullable<int>();

			Assert.AreEqual(Dummies.NullableInts, output);
		}

		[Test]
		public void OfNullable_SupportedEnumType_ReturnsDummies()
		{
			var output = Dummies.OfNullable<DateTimeKind>();
			Assert.AreEqual(4, output.Count());
			Assert.IsTrue(output.Contains(DateTimeKind.Local));
			Assert.IsTrue(output.Contains(DateTimeKind.Unspecified));
			Assert.IsTrue(output.Contains(DateTimeKind.Utc));
			Assert.IsTrue(output.Contains(null));
		}

		[Test]
		public void OfNullable_UnsupportedType_ThrowsException()
		{
			var action = new TestDelegate(() => Dummies.OfNullable<DummylessType>());
			Assert.Throws<ArgumentException>(action);
		}*/

		struct DummylessType { }
    }
}
