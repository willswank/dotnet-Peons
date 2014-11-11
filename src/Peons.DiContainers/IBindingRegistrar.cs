namespace Peons.DiContainers
{
    public interface IBindingRegistrar
    {
        IBindingRegistrar Bind<TRequested, TResolved>(bool inSingletonScope = true) where TResolved : TRequested;
        IBindingRegistrar Bind<TRequested>(TRequested constant);
        IBindingRegistrar Register<TRequested, TResolved>(IBinding<TRequested, TResolved> binding) where TResolved : TRequested;
        IBindingRegistrar Register<TRequested>(IBinding<TRequested> binding);
        IBindingRegistrar Register(IBindingModule bindingModule);
    }
}
