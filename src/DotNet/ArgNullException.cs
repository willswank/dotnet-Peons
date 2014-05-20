using Peons.DotNet.Internals;
using System;
using System.Linq.Expressions;

namespace Peons.DotNet
{
	/// <summary>
	/// An exception indicating that a method does not accept null for an
	/// argument
	/// </summary>
	/// <remarks>
	/// This allows strong-typing of the parameter name.
	/// </remarks>
	public class ArgNullException : ArgumentNullException
	{
		public ArgNullException(Expression<Func<object>> paramSelector)
			: base(paramSelector.GetMemberName()) { }

		public ArgNullException(Expression<Func<object>> paramSelector, string message)
			: base(paramSelector.GetMemberName(), message) { }
	}
}
