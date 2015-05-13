using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	public interface ICanSetBySyntaxResult<T>
	{
		void AndGetFrom(Func<T> getter);
	}
}
