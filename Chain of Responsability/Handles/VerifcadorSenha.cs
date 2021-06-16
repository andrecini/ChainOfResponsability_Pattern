using System;

namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe Handle responsável por Verificar se a senha digitada está correta
    /// </summary>
    public class VerificadorSenha: AbstractHandle
    {
        /// <summary>
        /// Método Sobrescrito que verifica se a senha foi digitada corretamente.
        /// </summary>
        /// <param name="usuario">Usuário a ser logado</param>
        /// <returns>Usuário a ser logado</returns>
        public override Usuario Handle(Usuario usuario)
        {
            RegistroDeUsuarios registro = RegistroDeUsuarios.GetInstance();

            foreach (var u in registro.Usuarios)
            {
                if (u.Senha == usuario.Senha)
                    return base.Handle(usuario);
            }

            throw new Exception("A Senha informada está incorreta.");
        }
    }
}
