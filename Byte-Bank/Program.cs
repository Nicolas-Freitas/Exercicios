using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, seja Bem vindo ao Byte-Bank.");

            Conta conta = new Conta();

            System.Console.WriteLine("Por favor insira seu nome.");
            conta.Nome = Console.ReadLine();
            System.Console.WriteLine("Por favor insira seu e-mail.");
            conta.Email = Console.ReadLine();
            System.Console.WriteLine("Por favor insira seu CPF.");
            conta.Cpf = Console.ReadLine();
            System.Console.WriteLine("Por favor insira sua senha.");
            Console.WriteLine("1) The length of '{0}' is {1}", conta.Senha, conta.Senha.Length);
            conta.Senha = Console.ReadLine();


        }
    }
}
