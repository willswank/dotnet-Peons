using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	public abstract class SyntaxResult<T>
	{
		public Builder<T> Builder
		{
			get { return this.builder; }
		}
		private readonly Builder<T> builder;

		public SyntaxResult(Builder<T> builder)
		{
			if (builder == null)
				throw new ArgumentNullException("builder");

			this.builder = builder;
		}
	}
}
