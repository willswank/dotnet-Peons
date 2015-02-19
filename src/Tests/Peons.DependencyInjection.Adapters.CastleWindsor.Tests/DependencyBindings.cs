
namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class DependencyBindings : IBindingsModule
    {
        public const int MEANING_OF_LIFE = 42;

        public void ConstructBindings(IBindingBuilder builder)
        {
            builder
                .Class<IDummyA, DummyA>(Scope.Transient)
                .Class<IDummyB, DummyB>()
                .Const<IDummyC>(DummyC.Instance);
        }
    }
}
