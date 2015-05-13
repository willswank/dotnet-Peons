using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	public class WithSyntaxResult<T> : SyntaxResult<T>,
			IWithSyntaxResult<T>
	{
		public WithSyntaxResult(Builder<T> builder) : base(builder) { }

		public ICanSetBySyntaxResult<T> CanSetBy(Action<T> setter)
		{
			if (setter == null)
				throw new ArgumentNullException("setter");

			Builder.Setter = setter;
			return new CanSetBySyntaxResult<T>(Builder);
		}
	}
}
