using System.Collections.Generic;
using System.IO;

namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe que detém os registro de usuários
    /// </summary>
    public class RegistroDeUsuarios
    {
        #region Singleton
        //Váriavel para o controle de instância única
        private static RegistroDeUsuarios _instance;

        /// <summary>
        /// Método para Retornar instância única 
        /// </summary>
        /// <returns>Instância única da Classe Registro de Usuários</returns>
        public static RegistroDeUsuarios GetInstance()
        {
            if(_instance == null)
                _instance = new RegistroDeUsuarios();
            return _instance;
        }
        
        //Construtor Privado para que a Classe seja instânciada apenas
        //com o método GetInstance.
        private RegistroDeUsuarios()
        {
            if(File.Exists(Directory.GetCurrentDirectory() + @"\usuarios.xml"))
                Usuarios = Serializador.Deserialize(@"\usuarios.xml");
            else
                throw new System.Exception("Arquivo de Usuários não encontrado. Cadastre alguém antes de Logar.");
        }
        #endregion

        /// <summary>
        /// Lista com todos os usuários registrados
        /// </summary>
        public List<Usuario> Usuarios = new List<Usuario>();

        /// <summary>
        /// Método para Listar todos os usuários registrados
        /// </summary>
        /// <returns>String com usuários listados</returns>
        public string ListarUsuarios()
        {
            string usuariosListados = string.Empty;

            for (int i = 0; i < Usuarios.Count; i++)
            {
                usuariosListados += i.ToString() + " - " + Usuarios[i].Login + "\n";
            }

            return usuariosListados;
        }

        /// <summary>
        /// Método para Controle da quantidade de usuários
        /// </summary>
        /// <returns>Número de Usuários</returns>
        public int RetornaQuantidade()
        {
            return Usuarios.Count;
        }
    }
}
