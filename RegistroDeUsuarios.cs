using System.Collections.Generic;
using System.IO;

namespace ChainOfResponsability_Pattern
{
    public class RegistroDeUsuarios
    {
        #region Singleton
        private static RegistroDeUsuarios _instance;

        public static RegistroDeUsuarios GetInstance()
        {
            if(_instance == null)
                _instance = new RegistroDeUsuarios();
            return _instance;
        }
        
        private RegistroDeUsuarios()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + @"\usuarios.xml"))
                Usuarios = Serializador.Deserialize(@"\usuarios.xml");
            else
                throw new System.Exception("Arquivo de Usuários não encontrado. Cadastre alguém antes de Logar.");
        }
        #endregion

        public List<Usuario> Usuarios = new List<Usuario>();

        public string ListarUsuarios()
        {
            string usuariosListados = string.Empty;

            for (int i = 0; i < Usuarios.Count; i++)
            {
                usuariosListados += i.ToString() + " - " + Usuarios[i].Login + "\n";
            }

            return usuariosListados;
        }

        public int RetornaQuantidade()
        {
            return Usuarios.Count;
        }
    }
}
