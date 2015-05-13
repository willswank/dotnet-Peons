using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	public class CanSetBySyntaxResult<T> : SyntaxResult<T>,
			ICanSetBySyntaxResult<T>
	{
		public CanSetBySyntaxResult(Builder<T> builder) : base(builder) { }

		public void AndGetFrom(Func<T> getter)
		{
			if (getter == null)
				throw new ArgumentNullException("getter");

			foreach (var input in Builder.Inputs)
			{
				Builder.Setter(input);
				var output = getter();
				Assert.AreEqual(input, output);
			}
		}
	}
}
