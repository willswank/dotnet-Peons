using NUnit.Framework;
using System;
using System.Linq.Expressions;

namespace Wordsworth.Peons.DotNet
{
    [TestFixture]
    public class ArgNullExceptionTests
    {
        [Test]
        public void ctor_MemberExpression_CanGetParamNameLater()
        {
            // Arrange

            object foobar = null;
            Expression<Func<object>> input = () => foobar;
            string expected = (input.Body as MemberExpression).Member.Name;

            // Act

            var actual = new ArgNullException(input);

            // Assert

            Assert.AreEqual(expected, actual.ParamName);
        }
    }
}
