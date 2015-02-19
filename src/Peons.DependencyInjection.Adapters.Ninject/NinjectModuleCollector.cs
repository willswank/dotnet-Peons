using Ninject.Modules;
using System.Collections.Generic;

namespace Peons.DependencyInjection.Adapters.Ninject
{
    public class NinjectModuleCollector
    {
        private readonly List<INinjectModule> modules;

        public NinjectModuleCollector()
        {
            modules = new List<INinjectModule>();
        }

        public NinjectModuleCollector Native(INinjectModule module)
        {
            if (module == null)
                throw new ArgNullException(() => module);

            this.modules.Add(module);
            return this;
        }

        public NinjectModuleCollector Adapted(IBindingsModule module)
        {
            if (module == null)
                throw new ArgNullException(() => module);

            var adaptedModule = NinjectAdapterModule.FromModule(module);
            this.modules.Add(adaptedModule);
            return this;
        }

        public NinjectModuleCollector Adapted<T>(IStrategyRegistry<T> registry)
        {
            if (registry == null)
                throw new ArgNullException(() => registry);

            var adaptedModule = NinjectAdapterModule.FromRegistry<T>(registry);
            this.modules.Add(adaptedModule);
            return this;
        }

        public INinjectModule[] Finish()
        {
            return modules.ToArray();
        }
    }
}
