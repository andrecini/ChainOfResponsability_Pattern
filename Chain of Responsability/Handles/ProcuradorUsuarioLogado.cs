namespace ChainOfResponsability_Pattern
{
    public class ProcuradorUsuarioLogado : AbstractHandle
    {
        public override Usuario Handle(Usuario usuario)
        {
            RegistroDeUsuarios registro = RegistroDeUsuarios.GetInstance();

            return registro.Usuarios.Find(u => u.Login == usuario.Login);
        }
    }
}
