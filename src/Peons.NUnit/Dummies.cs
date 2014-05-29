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
		private const string LONG_DUMMY_STRING = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

        public static readonly IEnumerable<string> Strings;
        public static readonly IEnumerable<int> Ints;
		public static readonly IEnumerable<short> Shorts;
        public static readonly IEnumerable<long> Longs;
        public static readonly IEnumerable<decimal> Decimals;
        public static readonly IEnumerable<bool> Bools;
        public static readonly IEnumerable<DateTime> DateTimes;
        public static readonly IEnumerable<object> Objects;

		private static readonly Dummies extendableInstance;

		public static readonly IEnumerable<string> NonNullStrings;
        public static readonly IEnumerable<string> NullEmptyOrWhiteSpaceStrings;
		public static readonly IEnumerable<string> NullOrEmptyStrings;
		public static readonly IEnumerable<string> NullOrWhiteSpaceStrings;
		public static readonly IEnumerable<string> WhiteSpaceStrings;
        public static readonly IEnumerable<string> VisibleStrings;

		private Dummies() { }

        static Dummies()
        {
			extendableInstance = new Dummies();

            Strings = new string[]
            {
                null,
                string.Empty,
                SIMPLE_DUMMY_STRING,
                COMPLEX_DUMMY_STRING,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING,
				LONG_DUMMY_STRING
            };

            Ints = new int[]
            {
                int.MinValue,
				int.MinValue / 2,
                -1,
                0,
                1,
                int.MaxValue / 2,
                int.MaxValue
            };

			Shorts = new short[]
            {
                short.MinValue,
				short.MinValue / 2,
                -1,
                0,
                1,
                short.MaxValue / 2,
                short.MaxValue
            };

            Longs = new long[]
            {
                long.MinValue,
                long.MinValue / 2,
                -1,
                0,
                1,
                long.MaxValue / 2,
                long.MaxValue
            };

            Decimals = new decimal[]
            {
                decimal.MinValue,
                decimal.MinValue / 2,
                decimal.MinusOne,
                decimal.Zero,
                decimal.One,
                decimal.MaxValue / 2,
                decimal.MaxValue
            };

            Bools = new bool[]
            {
                false,
                true
            };

            var nowTicks = DateTime.Now.Ticks;
            DateTimes = new DateTime[]
            {
                DateTime.MinValue,
                new DateTime(nowTicks / 2),
                new DateTime(nowTicks - 1),
                new DateTime(nowTicks),
                new DateTime(nowTicks + 1),
                new DateTime(nowTicks + (DateTime.MaxValue.Ticks-nowTicks) / 2),
                DateTime.MaxValue
            };

            Objects = new object[]
            {
                null,
                new object(),
                Strings,
                new { foo = Ints, bar = SIMPLE_DUMMY_STRING }
            };

			NonNullStrings = new string[]
			{
				string.Empty,
                SIMPLE_DUMMY_STRING,
                COMPLEX_DUMMY_STRING,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING,
				LONG_DUMMY_STRING
			};

			NullOrEmptyStrings = new string[]
			{
				null,
				string.Empty
			};

            NullEmptyOrWhiteSpaceStrings = new string[]
            {
                null,
                string.Empty,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING
            };

			NullOrWhiteSpaceStrings = new string[]
			{
				null,
                SIMPLE_WHITESPACE_STRING,
                COMPLEX_WHITESPACE_STRING
			};

			WhiteSpaceStrings = new string[]
			{
				SIMPLE_WHITESPACE_STRING,
				COMPLEX_WHITESPACE_STRING
			};

            VisibleStrings = new String[]
            {
                SIMPLE_DUMMY_STRING,
                COMPLEX_DUMMY_STRING,
				LONG_DUMMY_STRING
            };
        }

        public static IEnumerable<T> GetEnumValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

		/// <summary>
		/// An instance of Dummies for extension methods
		/// </summary>
		public static Dummies For
		{
			get { return extendableInstance; }
		}

		public static IEnumerable<T> Of<T>()
		{
			IEnumerable<T> dummies;
			var type = typeof(T);

			if (type.IsSubclassOf(typeof(System.Enum)))
				dummies = GetEnumValues<T>();
			else if (type == typeof(string))
				dummies = Strings as IEnumerable<T>;
			else if (type == typeof(int))
				dummies = Ints as IEnumerable<T>;
			else if (type == typeof(short))
				dummies = Shorts as IEnumerable<T>;
			else if (type == typeof(long))
				dummies = Longs as IEnumerable<T>;
			else if (type == typeof(decimal))
				dummies = Decimals as IEnumerable<T>;
			else if (type == typeof(bool))
				dummies = Bools as IEnumerable<T>;
			else if (type == typeof(DateTime))
				dummies = DateTimes as IEnumerable<T>;
			else if (type == typeof(object))
				dummies = Objects as IEnumerable<T>;

			else
			{
				throw new ArgumentException(string.Format("Unable to determine dummies for type `{0}`.",
						type));
			}

			return dummies;
		}
    }
}
