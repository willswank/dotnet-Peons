using NodaTime;
using System.Collections.Generic;

using INSTANT = NodaTime.Instant;

namespace Peons.NUnit.NodaTime
{
    public static class DummiesExtensions
    {
		private static readonly IEnumerable<Instant> instants;

		static DummiesExtensions()
		{
			var nowTicks = SystemClock.Instance.Now.Ticks;
			instants = new Instant[]
			{
				
				INSTANT.MinValue,
				new Instant(((nowTicks - long.MinValue) / 2) + long.MinValue),
				new Instant(nowTicks - 1),
				new Instant(nowTicks),
				new Instant(nowTicks + 1),
				new Instant(((long.MaxValue - nowTicks) / 2) + nowTicks),
				INSTANT.MaxValue
			};
		}

		public static IEnumerable<Instant> Instant(this Dummies dummies)
		{
			return instants;
		}
    }
}
