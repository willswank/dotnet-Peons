using Castle.MicroKernel.Registration;
using System.Collections.Generic;

namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class CastleWindsorInstallerCollector
    {
        private readonly List<IWindsorInstaller> modules;

        public CastleWindsorInstallerCollector()
        {
            modules = new List<IWindsorInstaller>();
        }

        public CastleWindsorInstallerCollector Native(IWindsorInstaller module)
        {
            if (module == null)
                throw new ArgNullException(() => module);

            this.modules.Add(module);
            return this;
        }

        public CastleWindsorInstallerCollector Module(IBindingsModule module)
        {
            if (module == null)
                throw new ArgNullException(() => module);

            var adaptedModule = CastleWindsorAdapterInstaller.FromModule(module);
            this.modules.Add(adaptedModule);
            return this;
        }

        public CastleWindsorInstallerCollector Registry<T>(IStrategyRegistry<T> registry)
        {
            if (registry == null)
                throw new ArgNullException(() => registry);

            var adaptedModule = CastleWindsorAdapterInstaller.FromRegistry<T>(registry);
            this.modules.Add(adaptedModule);
            return this;
        }

        public IWindsorInstaller[] Finish()
        {
            return modules.ToArray();
        }
    }
}
