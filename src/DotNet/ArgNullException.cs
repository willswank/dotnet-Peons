using System;
using System.Linq.Expressions;

namespace Peons.DotNet
{
	/// <summary>
	/// An exception indicating that a method does not accept null for an
	/// argument
	/// </summary>
	/// <remarks>
	/// This allows strong-typing of the parameter name. Source:
	/// http://www.peterjuhasz.net/Articles/Details/strongly-typed-argument-exception
	/// Modified to work with generic type arguments, which are
	/// UnaryExpressions (http://stackoverflow.com/a/12420603)
	/// </remarks>
	public class ArgNullException : System.ArgumentNullException
	{
		public ArgNullException(Expression<Func<object>> argumentSelector,
				string message)
			: base(GetMemberName(argumentSelector), message) { }

		public ArgNullException(Expression<Func<object>> argumentSelector)
			: this(argumentSelector, null) { }

		private static string GetMemberName(
				Expression<Func<object>> argumentSelector)
		{
			MemberExpression expression;
			if (argumentSelector.Body is MemberExpression)
			{
				expression = argumentSelector.Body as MemberExpression;
			}
			else
			{
				var unaryExpression = argumentSelector.Body as UnaryExpression;
				expression = unaryExpression.Operand as MemberExpression;
			}
			return expression.Member.Name;
		}
	}
}
