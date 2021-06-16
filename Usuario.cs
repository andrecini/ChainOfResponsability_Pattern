using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability_Pattern
{
    /// <summary>
    /// Classe Usuário com todas as Propriedades necessárias
    /// </summary>
    public class Usuario
    {
        //Variáveis Locais
        private string _login;
        private string _senha;
        private string _email;

        /// <summary>
        /// Propriedade Login encapsulada.
        /// </summary>
        public string Login
        {
            get => _login;
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Login preenchido incorretamente.");
                else
                    _login = value;
            }
        }

        /// <summary>
        /// Propriedade Senha+ encapsulada.
        /// </summary>
        public string Senha
        {
            get => _senha;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Login preenchido incorretamente.");
                else
                    _senha = value;
            }
        }

        /// <summary>
        /// Propriedade Email encapsulada.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Login preenchido incorretamente.");
                else
                    _email = value;
            }
        }
    }
}
