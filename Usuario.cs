using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability_Pattern
{
    public class Usuario
    {
        private string _login;
        private string _senha;
        private string _email;

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
