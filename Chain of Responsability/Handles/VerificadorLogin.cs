using System;

namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe Handle Responsável por verificar se o Login existe nos Registros de Usuário
    /// </summary>
    public class VerificadorLogin : AbstractHandle
    {
        /// <summary>
        /// Método Sobrescrito que verifica se o usuário digitado existe
        /// nos registros de usuário.
        /// </summary>
        /// <param name="usuario">Usuário a ser logado</param>
        /// <returns>Usuário a ser logado</returns>
        public override Usuario Handle(Usuario usuario)
        {
            RegistroDeUsuarios registro = RegistroDeUsuarios.GetInstance();
            
            foreach (var u in registro.Usuarios)
            {
                if(u.Login == usuario.Login)
                    return base.Handle(usuario);
            }
            
            throw new Exception("Nenhum usuário encontrado com o login informado.");
        }
    }
}
