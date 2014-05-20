using Peons.NUnit.Internals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peons.NUnit
{
    public static class VerifyProperty
    {
		public static IWithInputsSyntaxResult<T> WithInputs<T>(
				IEnumerable<T> inputs)
		{
			if (inputs == null)
				throw new ArgumentNullException("inputs");
			if (inputs.Count() == 0)
				throw new ArgumentException("No inputs were supplied");

			var builder = new Builder<T>();
			builder.Inputs = inputs;
			return new WithInputsSyntaxResult<T>(builder);
		}

		public static IWithInputsSyntaxResult<T> WithInputs<T>(T inputA,
				T inputB, params T[] moreInputs)
		{
			return WithInputs(moreInputs.Concat(new T[] { inputA, inputB }));
		}

		public static IWithInputsSyntaxResult<T> WithDummies<T>()
		{
			var builder = new Builder<T>();
			builder.Inputs = Dummies.Of<T>();
			return new WithInputsSyntaxResult<T>(builder);
		}

		public static IWithInputsSyntaxResult<T?> WithNullableDummies<T>()
				where T : struct
		{
			var builder = new Builder<T?>();
			builder.Inputs = Dummies.Of<T>().AndNull();
			return new WithInputsSyntaxResult<T?>(builder);
		}
    }
}
