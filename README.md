Peons libraries
===============

Peons are lightweight helper classes for the .NET platform.  They smooth over
awkward syntax and encapsulate common algorithms, so your code can speak more
eloquently.

Peons
-----

Helpers targeting the base platform 

### Argument exceptions ###

The built-in argument exceptions require the parameter name to be passed as a
string.  Peon's "Arg" exceptions wrap the built-in exceptions and discern the
argument name from its local variable name.  This makes refactoring more
reliable.

	public void Send(string message)
	{
		if (message == null)
		{
			throw new ArgNullException(() => message);
		}
		if (message.Length > 50)
		{
			throw new ArgOutOfRangeException(() => message,
					"The length must not exceed 50 characters");
		}
		if (message.Contains("it"))
		{
			throw new ArgException("The Knights Who Say 'Ni' disapprove.",
					() => message);
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
    
### Object extensions ###

When an object's property may be null, and the object's relationship with that
property is a "has-a" relationship, the code can profess this using `Has()`.

    person.Has(p => p.Nickname)
    
### Clock ###

Your code should not access the local clock directly.  Inject this dependency as
an `IClock` so you can test your time-sensitive algorithm.

    IClock clock = new LocalClock(); // inject this
    ...
    var currentTime = clock.Now();
    
Note: Although this is inferior to NodaTime, it's easier to retrofit into
existing products.

Peons.Collections
-----------------

### Read-only set ###

A read-only set is a proper mathematical set; in other words, an enumerable that
contains no duplicates.

    var items = new int[] { 4, 8, 15, 16, 23, 42 };
    IReadOnlySet<int> = new ReadOnlyHashSet(items);
    
### Read-only dictionary ###

A read-only dictionary is, well, just a frozen dictionary.

    var writableDictionary = new Dictionary<string,int>
    {
        { "foo", 4 },
        { "bar", 2 }
    };
    IReadOnlyDictionary<string, int> frozenDictionary
        = new ReadOnlyDictionary<string, int>(writableDictionary);
        
All read-only sets and dictionaries are also `IReadOnlyCollection`s.

Peons.Specification
-------------------

### Simple specifications ###

A specification is a rule that either passes or fails when applied to an object.
Implement your own business rules as `ISpecification`s to gain the syntactic
benefits.

    public class OldSpecification : ISpecification<Dog>
    {
        public bool IsSatisfiedBy(Dog candidate)
        {
            return candidate.Age > 13;
        }
    }

    public class AmputeeSpecification : ISpecification<Dog>
    {
        public bool IsSatisfiedBy(Dog candidate)
        {
            return candidate.LegCount < 4;
        }
    }

    public class SquirrelMurdererSpecification : ISpecification<Dog>
    {
        public bool IsSatisfiedBy(Dog candidate)
        {
            return candidate.MurderedSquirrelCount > 0;
        }
    }

    public class CatMurdererSpecification : ISpecification<Dog>
    {
        public bool IsSatisfiedBy(Dog candidate)
        {
            return candidate.MurderedCatCount > 0;
        }
    }
    
... and elsewhere ...

    var oldSpecification = new OldSpecification();
    var amputeeSpecification = new AmputeeSpecification();
    var squirrelMurdererSpecification = new SquirrelMurdererSpecification();
    var catMurdererSpecification = new CatMurdererSpecification();
    
    if (oldSpecification.IsSatisfiedBy(myDog))
    {
        Console.Write("Just lay around.");
    }
    if (amputeeSpecification.Not().IsSatisfiedBy(myDog))
    {
        Console.Write("Time for a walk.");
    }
    if (oldSpecification.And(amputeeSpecification).IsSatisfiedBy(myDog))
    {
        Console.Write("Poor dog...");
    }
    if (squirrelMurdererSpecification.Or(catMurdererSpecification).IsSatisfiedBy(myDog))
    {
        Console.Write("Vicious!");
    }
    
### Specification series ###
    
A `SpecificationSeries` lets you define an ordered list of specifications which,
when unsatisfied, report the earliest unsatisfied specification.

    public class FriendlyTabbyCatSpecifications : SpecificationSeries<Pet>
    {
        public FriendlyTabbyCatSpecifications() : base(new ISpecification<Pet>[]
        {
            new CatSpecification(),
            new TabbySpecification(),
            new FriendlySpecification()
        }){}
    }
    
... and elsewhere ...
    
    var specifications = new FriendlyTabbyCatSpecifications();
    
    var whyNot = specifications.GetFirstUnsatisfiedBy(myPet);
    
    if (whyNot is CatSpecification)
    {
        Console.Write("Not even a cat!");
    }
    else if (whyNot is TabbySpecification)
    {
        Console.Write("Not a tabby, yo.");
    }
    else if (whyNot is FriendlySpecification)
    {
        Console.Write("Close but no cigar.  This cat's mean!");
    }
    else if (whyNot == null)
    {
        Console.Write("It's a match!");
    }
    
### Specification set ###
    
A `SpecificationSet` lets you formally define a specification made up of many
others.

    public class NerdSpecification : SpecificationSet<Person>
    {
        public NerdSpecification() : base(new ISpecification<Person>[]
        {
            new ReadsComicsSpecification(),
            new WatchesBattlestarSpecification(),
            new PlaysPortalSpecification(),
            new UsesPeonsSpecification()
        }){}
    }
    
... and elsewhere ...
    
    var specification = new NerdSpecification();
    
    var why = specification.GetAllSatisfiedBy(me);
    var whyNot = specification.GetAllUnsatisfiedBy(me);
    
    if (why.Count() > whyNot.Count())
    {
        Console.Write("I am more nerd than not.");
    }
    if (specifications.IsSatisfiedBy(me))
    {
        Console.Write("I'm all nerd.");
    }
	
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
	
#### For... ####

Some solutions may find it useful to attach dummies of their own, proprietary
classes.  This can be accomplished using extension methods and the `Dummies`
instance exposed by `Dummies.For`.

	// Given an extension method Whatever and class Whatever
	IEnumerable<Whatever> dummies = Dummies.For.Whatever;
	
### IEnumerable<T>.AndNull() ###

Converts an IEnumerable of a value type to an IEnumerable of that value type as
nullable.

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
		
Peons.NUnit.DataSets
--------------------

Building dummy data in DataSets is a pain.  Peons.NUnit.DataSets has chainable
extension methods to assist.  Once you've defined a table and columns, you can
insert data as follows:

	dummyDataSet.Tables["Beer"]
		.AddRow()
		.FillValueTypeDefaults()
		.Set("id", 1)
		.Set("name", "Asahi")
		.Set("price", 8.99);
		
`AddRow()` creates a row and adds it back to the table.
`FillValueTypeDefaults()` ensures default, non-DBNull values for all of the
row's value-type columns.  `Set()` is concise and converts `null` to `DBNull`.

Peons.NUnit.NodaTime
--------------------

Provides dummies of NodaTime Instants.

	IEnumerable<Instant> dummies = Dummies.For.Instant();

Peons.Web
---------

Using `HttpContext.Current` to obtain the HTTP context violates Inversion of
Control and renders methods untestable.  `HttpContextProvider` wraps this
functionality with an interface and returns a mockable `HttpContextBase`.

	IHttpContextProvider provider = new HttpContextProvider();
	HttpContextBase context = provider.GetCurrentHttpContext();