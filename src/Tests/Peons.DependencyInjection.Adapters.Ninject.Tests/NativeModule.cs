using Ninject.Modules;

namespace Peons.DependencyInjection.Adapters.Ninject
{
    public class NativeModule : NinjectModule
    {
        private readonly object value;

        public NativeModule(object value)
        {
            this.value = value;
        }

        public override void Load()
        {
            Bind<object>().ToConstant(value);
        }
    }
}
