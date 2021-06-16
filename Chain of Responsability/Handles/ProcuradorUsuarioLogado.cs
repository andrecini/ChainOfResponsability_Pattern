namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe Handle responsável por devolver o Usuário cadastrado caso
    /// passe em todos os testes.
    /// </summary>
    public class ProcuradorUsuarioLogado : AbstractHandle
    {
        /// <summary>
        /// Método Sobrescrito que devolve o usuário final
        /// </summary>
        /// <param name="usuario">Usuário a ser logado</param>
        /// <returns>Usuário Final</returns>
        public override Usuario Handle(Usuario usuario)
        {
            RegistroDeUsuarios registro = RegistroDeUsuarios.GetInstance();

            return registro.Usuarios.Find(u => u.Login == usuario.Login);
        }
    }
}
