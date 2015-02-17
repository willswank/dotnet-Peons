using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class AdapterCastleWindsorInstaller : IWindsorInstaller
    {
        private readonly IBindingsModule bindingsModule;

        public AdapterCastleWindsorInstaller(IBindingsModule bindingsModule)
        {
            this.bindingsModule = bindingsModule;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var builder = new BindingBuilder();
            this.bindingsModule.ConstructBindings(builder);
            var bindings = builder.Finish();
            foreach (var binding in bindings)
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
