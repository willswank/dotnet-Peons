Peons 1.18
==========

Peons are lightweight helper classes for the .NET platform.  They smooth over
awkward syntax and encapsulate common algorithms, so your code can speak more
eloquently.

Peons
-----

Helpers for fundamental .NET classes

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
		// ...
    
Exceptions include:

- ArgEmptyException
- ArgException
- ArgNotVisibleException
- ArgNullException
- ArgOutOfRangeException
	
### UnrecognizedValueException ###

When an algorithm switches on a set of expected values, use this exception to
catch unexpected values.

	switch (inputChar)
	{
		case 'Y';
            return true;
		case 'N':
			return false;
		default:
			throw new UnrecognizedValueException<bool,char>(inputChar);
	}
    
### IEnumerable extensions ###

Express idiomatic IEnumerable operations more fluently:

    if (authors.IsEmpty())
    {
        // ...
    }
    if (recipients.IsNullOrEmpty())
    {
        // ...
    }
	
### String extensions ###

String extensions reverse the language of `string.IsNullOrEmpty` and
`string.IsNullOrWhiteSpace` for code that's more "fluent".

	message.IsNullOrEmpty()
	message.IsNullOrWhiteSpace()
	message.HasVisibleCharacters() // inverse of IsNullOrWhiteSpace()
    
### Clock ###

Your code should not access the local clock directly.  Inject this dependency as
an `IClock` so you can test your time-sensitive algorithm.

    IClock clock = new LocalClock(); // inject this
    ...
    var currentTime = clock.Now();
    
Note: Although this is inferior to NodaTime, it's easier to retrofit into
existing products.

Peons.Logging
-------------

Defer dependence on a specific logging framework by using `ILogger` instead.

    logger.Info("There are {0} models.", 12);
    
ILogger has methods for Trace, Debug, Info, Warn, Error, and Fatal levels.
Various overloads allow exception logging and string formatting.  The actual
formatting operation is assumed to be deferred until the last possible moment.

`ILogger<T>` allows a different logger to be injected for each class `T`.

The adapters are in separate assemblies, such as Peons.Logging.Adapter.NLog,
and they should only be instantiated at the composition root.

Peons.Collections
-----------------

### Read-only set ###

A read-only set is a proper mathematical set; in other words, an enumerable that
contains no duplicates.

    var items = new int[] { 4, 8, 15, 16, 23, 42 };
    IReadOnlySet<int> = new ReadOnlyHashSet(items);
    
### Read-only list ###

A read-only list behaves like an ordered IEnumerable, or a frozen array or list.

    IReadOnlyList<char> items = new ReadOnlyList<char>('f', 'o', 'o');
    
    // or
    
    IReadOnlyList<char> items = new ReadOnlyList<char>(arrayToFreeze);
    
    // or
    
    IReadOnlyList<char> items = new ReadOnlyList<char>(listToFreeze);
    
### Read-only dictionary ###

A read-only dictionary is, well, just a frozen dictionary.

    var writableDictionary = new Dictionary<string,int>
    {
        { "foo", 4 },
        { "bar", 2 }
    };
    IReadOnlyDictionary<string, int> frozenDictionary
        = new ReadOnlyDictionary<string, int>(writableDictionary);
        
All read-only collections implement `IReadOnlyCollection`.
	
Peons.NUnit
-----------

Helpers for unit testing with NUnit

### Dummies ###

Ranges of values for built-in types, covering broad ranges suitable for testing.

	Dummies.Of.Strings()
	Dummies.Of.Ints()
	Dummies.Of.Shorts()
	Dummies.Of.Longs()
	Dummies.Of.Decimals()
	Dummies.Of.Bools()
	Dummies.Of.DateTimes()
	Dummies.Of.Objects()
	
In principle, these include minimums, maximums, one, negative one, zero,
midpoint, null, and a variety of complex values, when applicable.

#### Dummies of enum values ####

Gets an enumeration of all values possible for an enum type.

	Dummies.Of.Enum<HttpMethod>()
	
#### Extending Dummies ####

Some solutions may find it useful to attach dummies of their own, proprietary
classes.  This can be accomplished using extension methods and the `Dummies`
instance exposed by `Dummies.Of`.

### IEnumerable<T>.AndNull() ###

Converts an IEnumerable of a value type to an IEnumerable of that value type as
nullable.

	Dummies.Of.Ints().AndNull();
	Dummies.Of.Enum<HttpMethod>().AndNull();
    
### AssertGuard ###

Assert that guard clauses work for methods with multiple guards concerns.

    AssertGuards
        .ForSignature<string, int>()
        .OfMethod((a,b) => new Foo(a,b))
        .WithDefaults("bar", 1)
        .WhenArgA(null)
            .Throw<ArgumentNullException>()
        .WhenArgA(string.Empty)
            .Throw<ArgumentException>()
        .WhenArgB(0)
            .Throw<ArgumentOutOfRangeException>();
	
### AssertProperty ###

Fluent round-trip testing of getter/setter pairs.

    AssertProperty
        .With(Dummies.Of.Int())
        .CanSetBy(order.Quantity = v)
        .AndGetFrom(() => order.Quantity);
				
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
    
Determining a user's IP address requires haphazard boilerplate.  The
`UserIpAddressSniffer` encapsulates this algorithm.

    IUserIpAddressSniffer sniffer = new UserIpAddressSniffer(context);
    string ipAddress = sniffer.GetUserIpAddress();
    
Peons.DomainEvents
------------------

Implementing domain events requires smelly boilerplate code in your domain
model.  Peons.DomainEvents provides the foundation to minimize this necessary
evil.

Yes, this requires that your domain model be dependent on the
Peons.DomainEvents assembly, but it is lightweight and addresses cross-cutting
concerns that would be a pain to re-implement in every domain model.

### Boilerplate ###

In your domain model, create an interface to be the base of all the domain's
events.  Remember to inherit from `Peons.DomainEvents.IEvent`.

    namespace Cats.Domain
    {
        public interface ICatEvent : Peons.DomainEvents.IEvent
        {
        }
    }

Then create a static `EventContext` class for your domain model.  You can
copy-paste the following boilerplate:

    using Peons.DomainEvents;
    using System;

    namespace Cats.Domain
    {
        public static class EventContext
        {
            private static IPublisher<ICatEvent> eventPublisher;

            public static void Initialize(IPublisher<ICatEvent> publisher)
            {
                if (eventPublisher != null)
                {
                    throw new ApplicationException("The domain events have already been initialized.");
                }
                eventPublisher = publisher;
            }

            public static void Subscribe<T>(IHandler<T> handler) where T : ICatEvent
            {
                if (eventPublisher != null)
                {
                    eventPublisher.Subscribe<T>(handler);
                }
            }

            public static void Subscribe<T>(Action<T> action) where T : ICatEvent
            {
                if (eventPublisher != null)
                {
                    eventPublisher.Subscribe(action);
                }
            }

            public static void Raise<T>(T @event) where T : ICatEvent
            {
                if (eventPublisher != null)
                {
                    eventPublisher.Publish(@event);
                }
            }
        }
    }
    
Adjust the boilerplate for the specifics of your domain.

- Update the namespace.
- Replace `ICatEvent` with your domain's event interface.
    
For the sake of unit testing, the `Subscribe()` and `Raise()` methods won't blow
up when the publisher is null.  The `Subscribe<T>(Action<T> action)` method is
also primarily for unit testing.

### Your domain ###

With the boilerplate covered, you can implement your specific domain events:

    namespace Cats.Domain
    {
        public class FellAsleepEvent : ICatEvent
        {
            public FellAsleepEvent(Cat cat)
            {
                this.cat = cat;
            }

            private readonly Cat cat;
            public Cat Cat
            {
                get { return this.cat; }
            }
        }
    }

And raise the events in your domain model:

    namespace Cats.Domain
    {
        public class Cat
        {
            public string Name { get; set; }
            
            // ... more members ...

            public void Sleep()
            {
                // ... do whatever here...
                
                EventContext.Raise(new FellAsleepEvent(this));
            }
        }
    }
    
### Event handlers ###

Later, in some "service" layer, you can implement a handler:

    using Cats.Domain;
    using Peons.DomainEvents;
    using System;

    namespace Cats.App
    {
        public class NapNotifier : IHandler<FellAsleepEvent>
        {
            public void Handle(FellAsleepEvent @event)
            {
                var cat = @event.Cat;
                Console.WriteLine("{0} is taking a nap.", cat.Name);
            }
        }
    }
    
### Initialization and subscription ###

At your app's composition root, remember to initialize your domain's event
context.

    EventContext.Initialize(new NinjectPublisher<ICatEvent>());
    
Note: The NinjectPublisher is in the `Peons.DomainEvents.NinjectPublisher`
assembly and namespace.  Your domain layer doesn't need to worry about
event-publishing infrastructure, so this dependency is decided by the consuming
layer.  You can also roll your own publisher by inheriting from `Publisher<T>`.

Assuming your event context is initialized, you can subscribe your handlers:

    EventContext.Subscribe(new NapNotifier());