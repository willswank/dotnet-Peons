using Ninject.Modules;
using System.Reflection;

namespace Peons.DependencyInjection.Adapters.Ninject
{
    public class NinjectAdapterModule : NinjectModule
    {
        private static readonly MethodInfo TO_CONSTANT_METHODINFO;

        static NinjectAdapterModule()
        {
            var bindingToSyntaxType = typeof(global::Ninject.Syntax.IBindingToSyntax<object>);
            TO_CONSTANT_METHODINFO = bindingToSyntaxType.GetMethod("ToConstant");
        }

        public static NinjectAdapterModule FromModule(IBindingsModule module)
        {
            if (module == null)
                throw new ArgNullException(() => module);

            var name = module.GetType().FullName;
            var builder = new BindingBuilder();
            module.ConstructBindings(builder);
            var bindings = builder.Finish();
            return new NinjectAdapterModule(bindings, name);
        }

        public static NinjectAdapterModule FromRegistry<T>(IStrategyRegistry<T> registry)
        {
            if (registry == null)
                throw new ArgNullException(() => registry);

            var name = registry.GetType().FullName;
            var builder = new RegistryBuilder<T>();
            registry.ConstructBindings(builder);
            var bindings = builder.Finish();
            return new NinjectAdapterModule(bindings, name);
        }

        private readonly IBinding[] bindings;

        private NinjectAdapterModule(IBinding[] bindings, string name)
        {
            this.bindings = bindings;
            this.name = name;
        }

        private readonly string name;
        public override string Name
        {
            get
            {
                return this.name;
            }
        }

        public override void Load()
        {
            foreach (var binding in bindings)
            {
                var toSyntaxStep = Bind(binding.RequestedType);
                if (binding.Constant == null)
                {
                    var scopeStep = toSyntaxStep.To(binding.ResolvedType);
                    switch (binding.Scope)
                    {
                        case Scope.Singleton:
                            scopeStep.InSingletonScope();
                            break;
                        case Scope.Transient:
                            scopeStep.InTransientScope();
                            break;
                        default:
                            throw new UnrecognizedValueException<Scope>(binding.Scope);
                    }
                }
                else
                {
                    var constantType = binding.Constant.GetType();
                    var toConstantMethod = TO_CONSTANT_METHODINFO
                        .MakeGenericMethod(constantType);
                    toConstantMethod.Invoke(toSyntaxStep, new object[] { binding.Constant });
                }
            }
        }
    }
}
