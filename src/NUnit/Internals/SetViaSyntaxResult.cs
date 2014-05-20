using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals
{
	public class SetViaSyntaxResult<T> : SyntaxResult<T>,
			ISetViaSyntaxResult<T>
	{
		public SetViaSyntaxResult(Builder<T> builder) : base(builder) { }

		public void GotVia(Func<T> getter)
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
