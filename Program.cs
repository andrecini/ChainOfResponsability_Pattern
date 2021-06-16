using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ChainOfResponsability_Pattern;

namespace ChainOfResponsability_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sejam Bem-Vindos ao teste do Padrão: Chain of Responsability...");

            Console.Write("\nDigite o seu login: ");
            string login = Console.ReadLine();

            //TODO: Verifica Entrada Login

            Console.Write("\nDigite o sua Senha: ");
            string senha = Console.ReadLine();

            //TODO: Verifica Entrada Login

            Usuario usuario = new Usuario();
            usuario.Login = login;
            usuario.Senha = senha;

            try
            {
                VerificadorLogin verificadorLogin = new VerificadorLogin();

                //Verifica o Login -> Verifica Senha -> Procura Usuário -> Devolve Usuário Final
                //              |                 '-> Senha Incorrta!
                //              '-> Usuário não encontrado!
                verificadorLogin.SetNext(new VerificadorSenha()).SetNext(new ProcuradorUsuarioLogado());

                var usuarioLogado = verificadorLogin.Handle(usuario);

                Console.WriteLine("\nLogado com Sucesso!");
                
                Thread.Sleep(2000);

                Console.WriteLine("\nSeu E-mail é: {0}", usuarioLogado.Email);

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }

            Thread.Sleep(4000);
        }
    }
}
