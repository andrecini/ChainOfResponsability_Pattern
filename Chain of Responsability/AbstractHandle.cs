namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe Abstrata que implementa a interface IHandle
    /// </summary>
    public abstract class AbstractHandle : IHandler
    {
        //Váriavel para controle do Handle que será executado
        private IHandler _nextHandler;

        /// <summary>
        /// Método que será Sobrescrito nas Classes Handle
        /// </summary>
        /// <param name="usuario">Usuário à ser Logado</param>
        /// <returns>O mesmo usuário caso passe na verificação</returns>
        public virtual Usuario Handle(Usuario usuario)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(usuario);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Define o Próximo Handle à ser executado
        /// </summary>
        /// <param name="handler">Objeto do Próximo Handle</param>
        /// <returns>Objeto Handle</returns>
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }
    }
}
