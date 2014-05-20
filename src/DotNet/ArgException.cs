using Peons.DotNet.Internals;
using System;
using System.Linq.Expressions;

namespace Peons.DotNet
{
	/// <summary>
	/// An exception indicating that a method does not accept the value passed
	/// for an argument
	/// </summary>
	/// <remarks>
	/// This allows strong-typing of the parameter name.
	/// </remarks>
	public class ArgException : System.ArgumentException
	{
		public ArgException(string message, Expression<Func<object>> paramSelector)
			: base(message, paramSelector.GetMemberName()) { }

		public ArgException(string message, Expression<Func<object>> paramSelector, Exception innerException)
			: base(message, paramSelector.GetMemberName(), innerException) { }
	}
}
