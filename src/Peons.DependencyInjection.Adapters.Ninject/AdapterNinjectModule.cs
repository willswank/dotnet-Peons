using Ninject.Modules;
using System;
using System.Reflection;

namespace Peons.DependencyInjection.Adapters.Ninject
{
    public class AdapterNinjectModule : NinjectModule
    {
        private readonly IBindingsModule bindingsModule;
        private readonly MethodInfo toConstantMethodInfo;

        public AdapterNinjectModule(IBindingsModule bindings)
        {
            if (bindings == null)
                throw new ArgNullException(() => bindings);

            this.bindingsModule = bindings;
            var bindingToSyntaxType = typeof(global::Ninject.Syntax.IBindingToSyntax<object>);
            this.toConstantMethodInfo = bindingToSyntaxType.GetMethod("ToConstant");
        }

        public override void Load()
        {
            var builder = new BindingBuilder();
            this.bindingsModule.ConstructBindings(builder);
            var bindings = builder.Finish();
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
                    var toConstantMethod = toConstantMethodInfo
                        .MakeGenericMethod(constantType);
                    toConstantMethod.Invoke(toSyntaxStep, new object[] { binding.Constant });
                }
            }
        }
    }
}
