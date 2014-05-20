using Peons.DotNet.Internals;
using System;
using System.Linq.Expressions;

namespace Peons.DotNet
{
	/// <summary>
	/// An exception indicating that the value of an object is outside the range
	/// accepted by a method
	/// </summary>
	/// <remarks>
	/// This allows strong-typing of the parameter name.
	/// </remarks>
	public class ArgOutOfRangeException : ArgumentOutOfRangeException
	{
		public ArgOutOfRangeException(Expression<Func<object>> paramSelector)
			: base(paramSelector.GetMemberName()) { }

		public ArgOutOfRangeException(Expression<Func<object>> paramSelector, string message)
			: base(paramSelector.GetMemberName(), message) { }

		public ArgOutOfRangeException(Expression<Func<object>> paramSelector, object actualValue, string message)
			: base(paramSelector.GetMemberName(), paramSelector.Compile()(), message) { }
	}
}
