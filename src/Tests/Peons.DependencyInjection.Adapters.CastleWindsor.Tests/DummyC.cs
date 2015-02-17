
namespace Peons.DependencyInjection.Adapters.CastleWindsor.Tests
{
    public class DummyC : IDummyC
    {
        public static DummyC Instance = new DummyC();

        private DummyC()
        {
        }
    }
}
