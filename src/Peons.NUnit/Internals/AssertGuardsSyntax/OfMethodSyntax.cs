using System;

namespace Peons.NUnit.Internals.AssertGuardsSyntax
{
    public class OfMethodSyntax<A>
    {
        private readonly Action<A> instantiator;

        public OfMethodSyntax(Action<A> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A> WithDefaults(A a)
        {
            return new WithDefaultsSyntax<A>(instantiator, a);
        }
    }

    public class OfMethodSyntax<A, B>
    {
        private readonly Action<A, B> instantiator;

        public OfMethodSyntax(Action<A, B> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B> WithDefaults(A a, B b)
        {
            return new WithDefaultsSyntax<A, B>(instantiator, a, b);
        }
    }

    public class OfMethodSyntax<A, B, C>
    {
        private readonly Action<A, B, C> instantiator;

        public OfMethodSyntax(Action<A, B, C> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C> WithDefaults(A a, B b, C c)
        {
            return new WithDefaultsSyntax<A, B, C>(instantiator, a, b, c);
        }
    }

    public class OfMethodSyntax<A, B, C, D>
    {
        private readonly Action<A, B, C, D> instantiator;

        public OfMethodSyntax(Action<A, B, C, D> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D> WithDefaults(A a, B b, C c, D d)
        {
            return new WithDefaultsSyntax<A, B, C, D>(instantiator, a, b, c, d);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E>
    {
        private readonly Action<A, B, C, D, E> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E> WithDefaults(A a, B b, C c, D d, E e)
        {
            return new WithDefaultsSyntax<A, B, C, D, E>(instantiator, a, b, c, d, e);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F>
    {
        private readonly Action<A, B, C, D, E, F> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F> WithDefaults(A a, B b, C c, D d, E e, F f)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F>(instantiator, a, b, c, d, e, f);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G>
    {
        private readonly Action<A, B, C, D, E, F, G> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G> WithDefaults(A a, B b, C c, D d, E e, F f, G g)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G>(instantiator, a, b, c, d, e, f, g);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H>
    {
        private readonly Action<A, B, C, D, E, F, G, H> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H>(instantiator, a, b, c, d, e, f, g, h);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I>(instantiator, a, b, c, d, e, f, g, h, i);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I, J>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I, J> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J>(instantiator, a, b, c, d, e, f, g, h, i, j);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I, J, K>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I, J, K> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K>(instantiator, a, b, c, d, e, f, g, h, i, j, k);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I, J, K, L>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(instantiator, a, b, c, d, e, f, g, h, i, j, k, l);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L, M> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L, M> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(instantiator, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(instantiator, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }
    }

    public class OfMethodSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> instantiator;

        public OfMethodSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> instantiator)
        {
            this.instantiator = instantiator;
        }

        public WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WithDefaults(A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o)
        {
            return new WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(instantiator, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }
    }
}
