using Ninject;

namespace Peons.DependencyInjection.Adapters.Ninject
{
    public class NinjectContainer : IDiContainer
    {
        private readonly IKernel kernel;

        public NinjectContainer(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public T Resolve<T>()
        {
            return this.kernel.Get<T>();
        }
    }
}
