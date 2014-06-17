using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Peons.Collections
{
	[TestFixture]
	class ReadOnlyDictionaryTests
	{
		ReadOnlyDictionary<object, object> unit;

		[Test]
		public void Keys_ReturnsDictionaryKeys()
		{
			var key1 = new object();
			var key2 = new object();
			var dummyDict = new Dictionary<object, object>
			{
				{ key1, new object() },
				{ key2, new object() }
			};
			unit = new ReadOnlyDictionary<object, object>(dummyDict);
			var output = unit.Keys;
			Assert.IsTrue(output.Contains(key1));
			Assert.IsTrue(output.Contains(key2));
			Assert.AreEqual(2, output.Count);
		}

		[Test]
		public void Values_ReturnsDictionaryKeys()
		{
			var value1 = new object();
			var value2 = new object();
			var dummyDict = new Dictionary<object, object>
			{
				{ new object(), value1 },
				{ new object(), value2 }
			};
			unit = new ReadOnlyDictionary<object, object>(dummyDict);
			var output = unit.Values;
			Assert.IsTrue(output.Contains(value1));
			Assert.IsTrue(output.Contains(value2));
			Assert.AreEqual(2, output.Count);
		}
	}
}
