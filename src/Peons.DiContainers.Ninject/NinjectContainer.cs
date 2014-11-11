using Ninject;
using Peons;

namespace Peons.DiContainers.Ninject
{
    public class NinjectContainer : IContainer
    {
        private readonly IKernel kernel;

        public NinjectContainer(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public T Resolve<T>()
        {
            return kernel.Get<T>();
        }

        public IBindingRegistrar Bind<TRequested, TResolved>(bool inSingletonScope = true) where TResolved : TRequested
        {
            var binding = new Binding<TRequested, TResolved>(inSingletonScope);
            return this.Register(binding);
        }

        public IBindingRegistrar Bind<TRequested>(TRequested constant)
        {
            var binding = new Binding<TRequested>(constant);
            return this.Register(binding);
        }

        public IBindingRegistrar Register<TRequested, TResolved>(IBinding<TRequested, TResolved> binding) where TResolved : TRequested
        {
            if (binding == null)
            {
                throw new ArgNullException(() => binding);
            }

            var bind = kernel.Bind<TRequested>().To<TResolved>();
            if (binding.InSingletonScope)
            {
                bind.InSingletonScope();
            }
            else
            {
                bind.InTransientScope();
            }
            return this;
        }

        public IBindingRegistrar Register<TRequested>(IBinding<TRequested> binding)
        {
            if (binding == null)
            {
                throw new ArgNullException(() => binding);
            }

            kernel.Bind<TRequested>().ToConstant(binding.Constant);
            return this;
        }

        public IBindingRegistrar Register(IBindingModule bindingModule)
        {
            if (bindingModule == null)
            {
                throw new ArgNullException(() => bindingModule);
            }

            bindingModule.RegisterWith(this);
            return this;
        }
    }
}
