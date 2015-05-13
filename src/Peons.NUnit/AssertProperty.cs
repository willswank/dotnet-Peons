using Peons.NUnit.Internals.AssertPropertySyntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Peons.NUnit
{
    public static class AssertProperty
    {
		public static IWithSyntaxResult<T> With<T>(
				IEnumerable<T> inputs)
		{
			if (inputs == null)
				throw new ArgumentNullException("inputs");
			if (inputs.Count() == 0)
				throw new ArgumentException("No inputs were supplied");

			var builder = new Builder<T>();
			builder.Inputs = inputs;
			return new WithSyntaxResult<T>(builder);
		}

		public static IWithSyntaxResult<T> With<T>(T inputA, T inputB, params T[] moreInputs)
		{
			return With((new T[] { inputA, inputB }).Concat(moreInputs));
		}
    }
}
