using System;
using System.Linq.Expressions;

namespace Peons.DotNet.Internals
{
	public static class ExpressionExtensions
	{
		/// <summary>
		/// Extracts the member name from a MemberExpression or UnaryExpression
		/// </summary>
		/// <remarks>
		/// Adapted from http://www.peterjuhasz.net/Articles/Details/strongly-typed-argument-exception,
		/// and modified to work with generically typed members (unary
		/// expressions) according to http://stackoverflow.com/a/12420603
		/// </remarks>
		public static string GetMemberName(this Expression<Func<object>> argSelector)
		{
			MemberExpression expression;
			if (argSelector.Body is MemberExpression)
			{
				expression = argSelector.Body as MemberExpression;
			}
			else
			{
				var unaryExpression = argSelector.Body as UnaryExpression;
				expression = unaryExpression.Operand as MemberExpression;
			}
			return expression.Member.Name;
		}
	}
}
