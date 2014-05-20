using System;
using System.Linq.Expressions;

namespace Wordsworth.Peons.DotNet
{
    /// <summary>
    /// The exception thrown when a method recieves an unsupported null argument
    /// </summary>
    /// <remarks>
    /// This allows strong-typing of the parameter name. Source:
    /// http://www.peterjuhasz.net/Articles/Details/strongly-typed-argument-exception
    /// </remarks>
    public class ArgNullException : System.ArgumentNullException
    {
        public ArgNullException(Expression<Func<object>> argumentSelector,
                string message)
            : base((argumentSelector.Body as MemberExpression).Member.Name,
                    message) { }

        public ArgNullException(Expression<Func<object>> argumentSelector)
            : this(argumentSelector, null) { }
    }
}
