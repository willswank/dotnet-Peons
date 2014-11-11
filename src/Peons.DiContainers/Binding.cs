namespace Peons.DiContainers
{
    public class Binding<TRequested, TResolved> : IBinding<TRequested, TResolved>
        where TResolved : TRequested
    {
        public Binding(bool inSingletonScope = true)
        {
            this.inSingletonScope = inSingletonScope;
        }

        private readonly bool inSingletonScope;
        public bool InSingletonScope
        {
            get { return this.inSingletonScope; }
        }
    }

    public class Binding<TRequested> : IBinding<TRequested>
    {
        public Binding(TRequested constant)
        {
            if (constant == null)
            {
                throw new ArgNullException(() => constant);
            }
            this.constant = constant;
        }

        private readonly TRequested constant;
        public TRequested Constant
        {
            get { return this.constant; }
        }
    }
}
