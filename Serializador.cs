using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe responsável por Serializar e Desserializar Registros de usuários
    /// </summary>
    public class Serializador
    {
        /// <summary>
        /// Serializa a Lista de Usuários.
        /// </summary>
        /// <param name="usuarios">Lista de usuários</param>
        /// <param name="fileName">Nome do Arquivo</param>
        public static void Serialize(List<Usuario> usuarios, string fileName)
        {
            FileStream stream = new FileStream(Directory.GetCurrentDirectory() + fileName, FileMode.Create);
            XmlSerializer serializador = new XmlSerializer(typeof(List<Usuario>));
            serializador.Serialize(stream, usuarios);
            stream.Close();
        }

        /// <summary>
        /// Desserializa a Lista de Usuários
        /// </summary>
        /// <param name="fileName">Nome do Arquivo</param>
        /// <returns>Lista de Usuários Desserializada</returns>
        public static List<Usuario> Deserialize(string fileName)
        {
            FileStream stream = new FileStream(Directory.GetCurrentDirectory() + fileName, FileMode.Open);
            XmlSerializer serializador = new XmlSerializer(typeof(List<Usuario>));
            var usuarios = (List<Usuario>)serializador.Deserialize(stream);
            stream.Close();

            return usuarios;
        }

    }
}
