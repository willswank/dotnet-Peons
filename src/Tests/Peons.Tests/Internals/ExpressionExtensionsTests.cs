using NUnit.Framework;
using System;
using System.Linq.Expressions;

namespace Peons.Internals
{
	[TestFixture]
	class ExpressionExtensionsTests
	{
		[Test]
		public void GetMemberName_MemberExpression_MemberName()
		{
			object argument = null;
			Expression<Func<object>> expression = () => argument;
			var output = expression.GetMemberName();
			Assert.AreEqual("argument", output);
		}

		[Test]
		public void GetMemberName_UnaryExpression_MemberName()
		{
			var output = this.GenericMethod<object>(null);
			Assert.AreEqual("argument", output);
		}

		private string GenericMethod<T>(T argument)
		{
			Expression<Func<object>> expression = () => argument;
			return expression.GetMemberName();
		}
	}
}
