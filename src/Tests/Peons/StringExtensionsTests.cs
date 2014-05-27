using NUnit.Framework;
using System;

namespace Peons
{
	[TestFixture]
	class StringExtensionsTests
	{
		[Test]
		public void IsNullOrWhiteSpace_Null_True()
		{
			// Arrange

			string input = null;

			// Act

			var actual = input.IsNullOrWhiteSpace();

			// Assert

			Assert.IsTrue(actual);
		}

		[Test]
		public void IsNullOrWhiteSpace_EmptyString_True()
		{
			// Arrange

			string input = String.Empty;

			// Act

			var actual = input.IsNullOrWhiteSpace();

			// Assert

			Assert.IsTrue(actual);
		}

		[Test]
		public void IsNullOrWhiteSpace_StringWithSpacesAndTabs_True()
		{
			// Arrange

			string input = "  \t   ";

			// Act

			var actual = input.IsNullOrWhiteSpace();

			// Assert

			Assert.IsTrue(actual);
		}

		[Test]
		public void IsNullOrWhiteSpace_StringsWithVisibleChars_False()
		{
			// Arrange

			var inputs = new string[]
			{
				"foo",
				"    bar",
				"42     ",
				"  13      ",
				"."
			};

			foreach (var input in inputs)
			{
				// Act

				var actual = input.IsNullOrWhiteSpace();

				// Assert

				Assert.IsFalse(actual);
			}
		}

		[Test]
		public void IsNullOrEmpty_Null_True()
		{
			// Arrange

			string input = null;

			// Act

			var actual = input.IsNullOrEmpty();

			// Assert

			Assert.IsTrue(actual);
		}

		[Test]
		public void IsNullOrEmpty_EmptyString_True()
		{
			// Arrange

			string input = string.Empty;

			// Act

			var actual = input.IsNullOrEmpty();

			// Assert

			Assert.IsTrue(actual);
		}

		[Test]
		public void IsNullOrEmpty_StringsWithSpacesOrTabs_False()
		{
			// Arrange

			var inputs = new string[]
			{
				" ",
				"   ",
				"\t"
			};

			foreach (var input in inputs)
			{
				// Act

				var actual = input.IsNullOrEmpty();

				// Assert

				Assert.IsFalse(actual);
			}
		}

		[Test]
		public void IsNullOrEmpty_StringsWithVisibleChars_False()
		{
			// Arrange

			var inputs = new string[]
			{
				"foo",
				"    bar",
				"42     ",
				"  13      ",
				"."
			};

			foreach (var input in inputs)
			{
				// Act

				var actual = input.IsNullOrEmpty();

				// Assert

				Assert.IsFalse(actual);
			}
		}

		[Test]
		public void HasVisibleCharacters_Null_False()
		{
			// Arrange

			string input = null;

			// Act

			var actual = input.HasVisibleCharacters();

			// Assert

			Assert.IsFalse(actual);
		}

		[Test]
		public void HasVisibleCharacters_EmptyString_False()
		{
			// Arrange

			string input = string.Empty;

			// Act

			var actual = input.HasVisibleCharacters();

			// Assert

			Assert.IsFalse(actual);
		}

		[Test]
		public void HasVisibleCharacters_StringWithSpacesOrTabs_False()
		{
			// Arrange

			var inputs = new string[]
			{
				" ",
				"   ",
				"\t"
			};

			foreach (var input in inputs)
			{
				// Act

				var actual = input.HasVisibleCharacters();

				// Assert

				Assert.IsFalse(actual);
			}
		}

		[Test]
		public void HasVisibleCharacters_StringWithVisibleCharacters_True()
		{
			// Arrange

			var inputs = new string[]
			{
				"foo",
				"    bar",
				"42     ",
				"  13      ",
				"."
			};

			foreach (var input in inputs)
			{
				// Act

				var actual = input.HasVisibleCharacters();

				// Assert

				Assert.IsTrue(actual);
			}
		}
	}
}
