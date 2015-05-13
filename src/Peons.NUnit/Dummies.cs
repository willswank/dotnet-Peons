using System;
using System.Collections.Generic;
using System.Linq;

namespace Peons.NUnit
{
    public class Dummies
    {
		private const string SIMPLE_WHITESPACE_STRING = " ";
        private const string COMPLEX_WHITESPACE_STRING = "\t   ";
        private const string SIMPLE_DUMMY_STRING = "foobar";
        private const string COMPLEX_DUMMY_STRING = " foo!@#123() Ðë®¶\t";
		private static readonly string LONG_DUMMY_STRING = new string('a', 100000);

        private static readonly string[] STRINGS;
        private static readonly int[] INTS;
        private static readonly short[] SHORTS;
        private static readonly long[] LONGS;
        private static readonly decimal[] DECIMALS;
        private static readonly bool[] BOOLS;
        private static readonly DateTime[] DATETIMES;
        private static readonly object[] OBJECTS;

		private static readonly IEnumerable<string> NON_NULL_STRINGS;
        private static readonly IEnumerable<string> NON_VISIBLE_STRINGS;
		private static readonly IEnumerable<string> NULL_OR_EMPTY_STRINGS;
		private static readonly IEnumerable<string> NULL_OR_WHITE_SPACE_STRINGS;
		private static readonly IEnumerable<string> WHITE_SPACE_STRINGS;
        private static readonly IEnumerable<string> VISIBLE_STRINGS;

        private static readonly Dummies extendableInstance;

        static Dummies()
        {
			extendableInstance = new Dummies();

            STRINGS = new string[]
            {
                null,
                string.Empty,
                SIMPLE_DUMMY_STRING,
                COMPLEX_DUMMY_STRING,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING,
				LONG_DUMMY_STRING
            };

            INTS = new int[]
            {
                int.MinValue,
				int.MinValue / 2,
                -1,
                0,
                1,
                int.MaxValue / 2,
                int.MaxValue
            };

			SHORTS = new short[]
            {
                short.MinValue,
				short.MinValue / 2,
                -1,
                0,
                1,
                short.MaxValue / 2,
                short.MaxValue
            };

            LONGS = new long[]
            {
                long.MinValue,
                long.MinValue / 2,
                -1,
                0,
                1,
                long.MaxValue / 2,
                long.MaxValue
            };

            DECIMALS = new decimal[]
            {
                decimal.MinValue,
                decimal.MinValue / 2,
                decimal.MinusOne,
                decimal.Zero,
                decimal.One,
                decimal.MaxValue / 2,
                decimal.MaxValue
            };

            BOOLS = new bool[]
            {
                false,
                true
            };

            var nowTicks = System.DateTime.Now.Ticks;
            DATETIMES = new DateTime[]
            {
                System.DateTime.MinValue,
                new DateTime(nowTicks / 2),
                new DateTime(nowTicks - 1),
                new DateTime(nowTicks),
                new DateTime(nowTicks + 1),
                new DateTime(nowTicks + (System.DateTime.MaxValue.Ticks-nowTicks) / 2),
                System.DateTime.MaxValue
            };

            OBJECTS = new object[]
            {
                null,
                new object(),
                STRINGS,
                new { foo = INTS, bar = SIMPLE_DUMMY_STRING }
            };

			NON_NULL_STRINGS = new string[]
			{
				string.Empty,
                SIMPLE_DUMMY_STRING,
                COMPLEX_DUMMY_STRING,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING,
				LONG_DUMMY_STRING
			};

			NULL_OR_EMPTY_STRINGS = new string[]
			{
				null,
				string.Empty
			};

            NON_VISIBLE_STRINGS = new string[]
            {
                null,
                string.Empty,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING
            };

			NULL_OR_WHITE_SPACE_STRINGS = new string[]
			{
				null,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING
			};

			WHITE_SPACE_STRINGS = new string[]
			{
				SIMPLE_WHITESPACE_STRING,
				COMPLEX_WHITESPACE_STRING
			};

            VISIBLE_STRINGS = new String[]
            {
                SIMPLE_DUMMY_STRING,
                COMPLEX_DUMMY_STRING,
				LONG_DUMMY_STRING
            };
        }

		/// <summary>
		/// An instance of Dummies for extension methods
		/// </summary>
		public static Dummies Of
		{
			get { return extendableInstance; }
		}

        private Dummies() { }

        public IEnumerable<string> String()
        {
            return STRINGS.ToArray();
        }

        public IEnumerable<short> Short()
        {
            return SHORTS.ToArray();
        }

        public IEnumerable<int> Int()
        {
            return INTS.ToArray();
        }

        public IEnumerable<long> Long()
        {
            return LONGS.ToArray();
        }

        public IEnumerable<decimal> Decimal()
        {
            return DECIMALS.ToArray();
        }

        public IEnumerable<bool> Bool()
        {
            return BOOLS.ToArray();
        }

        public IEnumerable<DateTime> DateTime()
        {
            return DATETIMES.ToArray();
        }

        public IEnumerable<object> Object()
        {
            return OBJECTS.ToArray();
        }

        public IEnumerable<string> NonNullStrings()
        {
            return NON_NULL_STRINGS.ToArray();
        }

        public IEnumerable<string> NonVisibleStrings()
        {
            return NON_VISIBLE_STRINGS.ToArray();
        }

        public IEnumerable<string> NullOrEmptyStrings()
        {
            return NULL_OR_EMPTY_STRINGS.ToArray();
        }

        public IEnumerable<string> NullOrWhiteSpaceStrings()
        {
            return NULL_OR_WHITE_SPACE_STRINGS.ToArray();
        }

        public IEnumerable<string> WhiteSpaceStrings()
        {
            return WHITE_SPACE_STRINGS.ToArray();
        }

        public IEnumerable<string> VisibleStrings()
        {
            return VISIBLE_STRINGS.ToArray();
        }

        public IEnumerable<T> Enum<T>() where T : struct
        {
            var type = typeof(T);
            if (!type.IsSubclassOf(typeof(System.Enum)))
            {
                var message = string.Format("Type argument must be an enum, but was `{0}`.",
                    type.FullName);
                throw new ArgumentException(message);
            }
            return System.Enum.GetValues(type).Cast<T>().ToArray();
        }
    }
}
