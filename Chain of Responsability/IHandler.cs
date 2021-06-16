namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Interface que será implementada nas Classe Abstrata
    /// </summary>
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        Usuario Handle(Usuario usuario);
    }
}
