using System;

namespace Peons.NUnit.Internals.AssertGuardsSyntax
{
    public class WithDefaultsSyntax<A>
    {
        private readonly Action<A> instantiator;
        private readonly A a;

        public WithDefaultsSyntax(Action<A> instantiator, A a)
        {
            this.instantiator = instantiator;
            this.a = a;
        }

        public WhenArgSyntax<A> WhenArgA(A a)
        {
            return new WhenArgSyntax<A>(this, () => instantiator(a));
        }
    }

    public class WithDefaultsSyntax<A, B>
    {
        private readonly Action<A, B> instantiator;
        private readonly A a;
        private readonly B b;

        public WithDefaultsSyntax(Action<A, B> instantiator, A a, B b)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
        }

        public WhenArgSyntax<A, B> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B>(this, () => instantiator(a, b));
        }

        public WhenArgSyntax<A, B> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B>(this, () => instantiator(a, b));
        }
    }

    public class WithDefaultsSyntax<A, B, C>
    {
        private readonly Action<A, B, C> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;

        public WithDefaultsSyntax(Action<A, B, C> instantiator, A a, B b, C c)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public WhenArgSyntax<A, B, C> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C>(this, () => instantiator(a, b, c));
        }

        public WhenArgSyntax<A, B, C> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C>(this, () => instantiator(a, b, c));
        }

        public WhenArgSyntax<A, B, C> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C>(this, () => instantiator(a, b, c));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D>
    {
        private readonly Action<A, B, C, D> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;

        public WithDefaultsSyntax(Action<A, B, C, D> instantiator, A a, B b, C c, D d)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public WhenArgSyntax<A, B, C, D> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D>(this, () => instantiator(a, b, c, d));
        }

        public WhenArgSyntax<A, B, C, D> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D>(this, () => instantiator(a, b, c, d));
        }

        public WhenArgSyntax<A, B, C, D> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D>(this, () => instantiator(a, b, c, d));
        }

        public WhenArgSyntax<A, B, C, D> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D>(this, () => instantiator(a, b, c, d));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E>
    {
        private readonly Action<A, B, C, D, E> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;

        public WithDefaultsSyntax(Action<A, B, C, D, E> instantiator, A a, B b, C c, D d, E e)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public WhenArgSyntax<A, B, C, D, E> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E>(this, () => instantiator(a, b, c, d, e));
        }

        public WhenArgSyntax<A, B, C, D, E> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E>(this, () => instantiator(a, b, c, d, e));
        }

        public WhenArgSyntax<A, B, C, D, E> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E>(this, () => instantiator(a, b, c, d, e));
        }

        public WhenArgSyntax<A, B, C, D, E> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E>(this, () => instantiator(a, b, c, d, e));
        }

        public WhenArgSyntax<A, B, C, D, E> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E>(this, () => instantiator(a, b, c, d, e));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F>
    {
        private readonly Action<A, B, C, D, E, F> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F> instantiator, A a, B b, C c, D d, E e, F f)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
        }

        public WhenArgSyntax<A, B, C, D, E, F> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F>(this, () => instantiator(a, b, c, d, e, f));
        }

        public WhenArgSyntax<A, B, C, D, E, F> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F>(this, () => instantiator(a, b, c, d, e, f));
        }

        public WhenArgSyntax<A, B, C, D, E, F> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F>(this, () => instantiator(a, b, c, d, e, f));
        }

        public WhenArgSyntax<A, B, C, D, E, F> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F>(this, () => instantiator(a, b, c, d, e, f));
        }

        public WhenArgSyntax<A, B, C, D, E, F> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F>(this, () => instantiator(a, b, c, d, e, f));
        }

        public WhenArgSyntax<A, B, C, D, E, F> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F>(this, () => instantiator(a, b, c, d, e, f));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G>
    {
        private readonly Action<A, B, C, D, E, F, G> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G> instantiator, A a, B b, C c, D d, E e, F f, G g)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G>(this, () => instantiator(a, b, c, d, e, f, g));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H>
    {
        private readonly Action<A, B, C, D, E, F, G, H> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H> instantiator, A a, B b, C c, D d, E e, F f, G g, H h)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H>(this, () => instantiator(a, b, c, d, e, f, g, h));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I>(this, () => instantiator(a, b, c, d, e, f, g, h, i));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;
        private readonly J j;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I, J> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J> WhenArgJ(J j)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;
        private readonly J j;
        private readonly K k;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I, J, K> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgJ(J j)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K> WhenArgK(K k)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;
        private readonly J j;
        private readonly K k;
        private readonly L l;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgJ(J j)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgK(K k)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L> WhenArgL(L l)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L, M> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;
        private readonly J j;
        private readonly K k;
        private readonly L l;
        private readonly M m;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L, M> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
            this.m = m;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgJ(J j)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgK(K k)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgL(L l)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M> WhenArgM(M m)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;
        private readonly J j;
        private readonly K k;
        private readonly L l;
        private readonly M m;
        private readonly N n;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
            this.m = m;
            this.n = n;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgJ(J j)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgK(K k)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgL(L l)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgM(M m)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N> WhenArgN(N n)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }
    }

    public class WithDefaultsSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>
    {
        private readonly Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> instantiator;
        private readonly A a;
        private readonly B b;
        private readonly C c;
        private readonly D d;
        private readonly E e;
        private readonly F f;
        private readonly G g;
        private readonly H h;
        private readonly I i;
        private readonly J j;
        private readonly K k;
        private readonly L l;
        private readonly M m;
        private readonly N n;
        private readonly O o;

        public WithDefaultsSyntax(Action<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> instantiator, A a, B b, C c, D d, E e, F f, G g, H h, I i, J j, K k, L l, M m, N n, O o)
        {
            this.instantiator = instantiator;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
            this.k = k;
            this.l = l;
            this.m = m;
            this.n = n;
            this.o = o;
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgA(A a)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgB(B b)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgC(C c)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgD(D d)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgE(E e)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgF(F f)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgG(G g)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgH(H h)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgI(I i)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgJ(J j)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgK(K k)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgL(L l)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgM(M m)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgN(N n)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O> WhenArgO(O o)
        {
            return new WhenArgSyntax<A, B, C, D, E, F, G, H, I, J, K, L, M, N, O>(this, () => instantiator(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }
    }
}
