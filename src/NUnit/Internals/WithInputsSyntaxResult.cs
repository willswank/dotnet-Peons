using System;

namespace Peons.NUnit.Internals
{
	public class WithInputsSyntaxResult<T> : SyntaxResult<T>,
			IWithInputsSyntaxResult<T>
	{
		public WithInputsSyntaxResult(Builder<T> builder) : base(builder) { }

		public ISetViaSyntaxResult<T> SetVia(Action<T> setter)
		{
			if (setter == null)
				throw new ArgumentNullException("setter");

			Builder.Setter = setter;
			return new SetViaSyntaxResult<T>(Builder);
		}
	}
}
