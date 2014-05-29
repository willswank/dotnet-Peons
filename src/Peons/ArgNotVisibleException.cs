using Peons.Internals;
using System;
using System.Linq.Expressions;

namespace Peons
{
	/// <summary>
	/// An exception indicating that the value of a string argument is null,
	/// empty, or whitespace
	/// </summary>
	/// <remarks>
	/// This allows strong-typing of the parameter name.
	/// </remarks>
	public class ArgNotVisibleException : ArgOutOfRangeException
	{
		public ArgNotVisibleException(Expression<Func<object>> paramSelector)
			: this(paramSelector, paramSelector.Compile()())
		{
		}

		private ArgNotVisibleException(Expression<Func<object>> paramSelector, object value)
			: base(paramSelector, value, SelectMessage(paramSelector.GetMemberName(), value))
		{

		}

		private const string MESSAGE_FORMAT = "The argument, {0}, must contain visible characters but was {1}.";

		private static string SelectMessage(string memberName, object value)
		{
			string valueCategory;
			if (value == null)
			{
				valueCategory = "null";
			}
			else
			{
				var actualValue = value.ToString();
				if (actualValue.HasVisibleCharacters())
				{
					throw new ArgOutOfRangeException(() => value, actualValue,
							"An ArgStringNotVisibleException was thrown for a visible value.");
				}
				if (actualValue == null)
				{
					valueCategory = "null";
				}
				else if (actualValue == string.Empty)
				{
					valueCategory = "empty";
				}
				else
				{
					valueCategory = "white space";
				}
			}
			var message = string.Format(MESSAGE_FORMAT, memberName, valueCategory);
			return message;
		}
	}
}
