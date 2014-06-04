using Peons.Internals;
using System;
using System.Linq.Expressions;

namespace Peons
{
	/// <summary>
	/// An exception indicating that an enumerable argument has zero items
	/// </summary>
	/// <remarks>
	/// This allows strong-typing of the parameter name.
	/// </remarks>
	public class ArgEmptyException : ArgException
	{
		public ArgEmptyException(Expression<Func<object>> paramSelector)
			: base("The argument contains no items.", paramSelector) { }
	}
}
