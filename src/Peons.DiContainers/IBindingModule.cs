namespace Peons.DiContainers
{
    public interface IBindingModule
    {
        void RegisterWith(IBindingRegistrar registrar);
    }
}
