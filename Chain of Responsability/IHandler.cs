namespace ChainOfResponsability_Pattern
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        Usuario Handle(Usuario usuario);
    }
}
