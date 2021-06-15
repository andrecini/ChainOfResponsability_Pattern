using System;

namespace ChainOfResponsability_Pattern
{
    public class VerificadorSenha: AbstractHandle
    {
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
