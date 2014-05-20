using System;

namespace Peons.DotNet
{
	/// <summary>
	/// An exception indicating that a value was not accounted for while
	/// processing a certain type.
	/// </summary>
	/// <remarks>
	/// When switching according to an enum value, throw this exception for the
	/// default case, meaning that the enum has a value that was not considered.
	/// </remarks>
	public class UnrecognizedValueException<T> : UnrecognizedValueException<T, T>
	{
		public UnrecognizedValueException(T value) : base(value) { }
	}

	/// <summary>
	/// An exception indicating that a value was not accounted for while
	/// converting to a certain type.
	/// </summary>
	/// <remarks>
	/// When converting to an enum value from a different type, throw this
	/// exception for an unanticipated input value.
	/// </remarks>
	public class UnrecognizedValueException<TTarget, TValue>
			: ArgumentException
	{
		public const string MESSAGE_FORMAT
				= "The value \"{0}\" has not been accounted for for type {1}.";

		public UnrecognizedValueException(TValue value)
			: base(string.Format(MESSAGE_FORMAT, value, typeof(TTarget))) { }
	}
}
