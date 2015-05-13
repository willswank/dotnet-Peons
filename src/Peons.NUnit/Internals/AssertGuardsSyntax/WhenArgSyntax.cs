using NUnit.Framework;
using System;

namespace Peons.NUnit.Internals.AssertGuardsSyntax
{
    public class WhenArgSyntax<A>
    {
        private readonly WithDefaultsSyntax<A> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B>
    {
        private readonly WithDefaultsSyntax<A, B> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C>
    {
        private readonly WithDefaultsSyntax<A, B, C> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D>
    {
        private readonly WithDefaultsSyntax<A, B, C, D> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }

    public class WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>
    {
        private readonly WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> withDefaultsSyntax;
        private readonly Action instantiator;

        public WhenArgSyntax(WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> withDefaultsSyntax, Action instantiator)
        {
            this.withDefaultsSyntax = withDefaultsSyntax;
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> Throw<TException>()
            where TException : Exception
        {
            Assert.Throws<TException>(new TestDelegate(instantiator));
            return withDefaultsSyntax;
        }
    }
}
