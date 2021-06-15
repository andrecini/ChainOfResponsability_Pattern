namespace ChainOfResponsability_Pattern
{
    public abstract class AbstractHandle : IHandler
    {
        private IHandler _nextHandler;

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

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            return handler;
        }
    }
}
