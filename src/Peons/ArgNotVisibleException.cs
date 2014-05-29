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
		public ArgNotVisibleException(Expression<Func<object>> paramSelector, string actualValue)
			: base(paramSelector, actualValue, SelectMessage(paramSelector, actualValue))
		{
		}

		private const string MESSAGE_FORMAT = "The argument, {0}, must contain visible characters but was {1}.";

		private static string SelectMessage(Expression<Func<object>> paramSelector, string value)
		{
			if (value.HasVisibleCharacters())
			{
				throw new ArgOutOfRangeException(() => value, value,
						"An ArgStringNotVisibleException was thrown for a visible value.");
			}
			var name = paramSelector.GetMemberName();
			string valueCategory;
			if (value == null)
			{
				valueCategory = "null";
			}
			else if (value == string.Empty)
			{
				valueCategory = "empty";
			}
			else
			{
				valueCategory = "white space";
			}
			var message = string.Format(MESSAGE_FORMAT, name, valueCategory);
			return message;
		}
	}
}
