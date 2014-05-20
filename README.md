Peons
=====

Lightweight helper classes for the .NET platform

Peons.DotNet
------------

Helpers targeting the base platform 

### ArgNullException ###

The built-in ArgumentNullException requires the parameter name to be passed as a
string.  ArgNullException wraps ArgumentNullException and discerns the argument
name from its local variable name.  This makes refactoring more reliable.

	public void Send(string message)
	{
		if (message == null)
		{
			throw new ArgNullException(() => message);
		}
		// ...
	}
	
### UnrecognizedValueException ###

An algorithm may switch on an enum type that could gain a new value in a later
version. Use UnrecognizedValueException in the default case to safely catch
values that weren't considered.

	switch (contribution.Status)
	{
		case ContributionStatus.NewlyRecorded;
			// ...
			break;
		case ContributionStatus.Processed:
			// ...
			break;
		default:
			throw new UnrecognizedValueException(contribution.Status);
	}
	
### String extensions ###

String extensions reverse the language of `string.IsNullOrEmpty` and
`string.IsNullOrWhiteSpace` for code that's more "fluent".

	message.IsNullOrEmpty()
	message.IsNullOrWhiteSpace()
	message.HasVisibleCharacters() // inverse of IsNullOrWhiteSpace()
	
Peons.NUnit
-----------

Helpers for unit testing with NUnit

### Dummies ###

Ranges of values for built-in types, covering broad ranges suitable for testing.

	Dummies.Strings
	Dummies.Ints
	Dummies.Shorts
	Dummies.Longs
	Dummies.Decimals
	Dummies.Bools
	Dummies.DateTimes
	Dummies.Objects
	
In principle, these include minimums, maximums, one, negative one, zero,
midpoint, null, and a variety of complex values, when applicable.

#### GetEnumValues<T>() ####

Gets an enumeration of all values possible for an enum type.

	var allHttpMethods = Dummies.GetEnumValues<HttpMethod>();
	
#### Of<T>() ####

An alternate syntax that maps to either Dummies.___s or GetEnumValues<T>().

	var integers = Dummies.Of<int>()
	var colors = Dummies.Of<ConsoleColor>();
	
### IEnumerable value type extensions ###

Allows easy conversion from an IEnumerable of a value type to an IEnumerable of
that value type as nullable.

	int? intsAndNull = Dummies.Ints.AndNull();
	HttpMethod methodsAndNull = Dummies.Of<HttpMethod>().AndNull();
	
### VerifyProperty ###

Fluent round-trip testing of getter/setter pairs.

	VerifyProperty
		.WithDummies<int>()
		.SetVia(v => order.Quantity = v)
		.GotVia(() => order.Quantity);
	
	VerifyProperty
		.WithNullableDummies<decimal>()
		.SetVia(v => order.Fee = v)
		.GotVia(() => order.Fee);
		
	VerifyProperty
		.WithInputs(requests)
		.SetVia(v => order.SpecialRequests = v)
		.GotVia(() => order.SpecialRequests);
		
Can also test property values assigned by the constructor.

	Order order = null;
	VerifyProperty
		.WithInputs(products)
		.SetVia(v => order = new Order(v))
		.GotVia(() => order.Product);