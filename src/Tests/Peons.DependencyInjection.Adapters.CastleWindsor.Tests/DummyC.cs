
namespace Peons.DependencyInjection.Adapters.CastleWindsor
{
    public class DummyC : IDummyC
    {
        public static DummyC Instance = new DummyC();

        private DummyC()
        {
        }
    }
}
