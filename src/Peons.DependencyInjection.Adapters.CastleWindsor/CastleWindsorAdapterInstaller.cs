using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class CastleWindsorAdapterInstaller : IWindsorInstaller
    {
        public static CastleWindsorAdapterInstaller FromModule(IBindingsModule module)
        {
            if (module == null)
                throw new ArgNullException(() => module);

            var builder = new BindingBuilder();
            module.ConstructBindings(builder);
            var bindings = builder.Finish();
            return new CastleWindsorAdapterInstaller(bindings);
        }

        public static CastleWindsorAdapterInstaller FromRegistry<T>(IStrategyRegistry<T> registry)
        {
            if (registry == null)
                throw new ArgNullException(() => registry);

            var builder = new RegistryBuilder<T>();
            registry.ConstructBindings(builder);
            var bindings = builder.Finish();
            return new CastleWindsorAdapterInstaller(bindings);
        }

        private readonly IBinding[] bindings;

        private CastleWindsorAdapterInstaller(IBinding[] bindings)
        {
            this.bindings = bindings;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            foreach (var binding in this.bindings)
            {
                ComponentRegistration<object> component;
                var forSyntaxStep = Component.For(binding.RequestedType);
                if (binding.Constant == null)
                {
                    var implementedByStep = forSyntaxStep
                        .ImplementedBy(binding.ResolvedType);
                    switch (binding.Scope)
                    {
                        case Scope.Singleton:
                            component = implementedByStep.LifeStyle.Singleton;
                            break;
                        case Scope.Transient:
                            component = implementedByStep.LifeStyle.Transient;
                            break;
                        default:
                            throw new UnrecognizedValueException<Scope>(binding.Scope);
                    }
                }
                else
                {
                    component = forSyntaxStep.Instance(binding.Constant);
                }
                container.Register(component);
            }
        }
    }
}
