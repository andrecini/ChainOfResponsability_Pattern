using System;

namespace ChainOfResponsability_Pattern
{
    public class VerificadorLogin : AbstractHandle
    {
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
