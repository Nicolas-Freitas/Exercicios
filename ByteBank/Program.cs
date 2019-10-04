using System;
using ByteBank.Models;

namespace ByteBank
{
    class Program
    {
        private static bool senhaOk;

        static void Main(string[] args)
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("         ByteBank");
            System.Console.WriteLine("----------------------------");

            System.Console.WriteLine($"CPF:");
            string Cpf = Console.ReadLine();

            System.Console.WriteLine($"Nome:");
            string Nome = Console.ReadLine();

            System.Console.WriteLine($"Email:");
            string Email = Console.ReadLine();

            Login login1 = new Login(Nome, Cpf, Email);

            
                System.Console.WriteLine("Digite a Senha");
                string senha = Console.ReadLine();
                bool senhaOk = login1.TrocaSenha(senha);
                if (!senhaOk)
                {
                    System.Console.WriteLine("Senha não atende aos requsitos");
                }
                else
                {
                    System.Console.WriteLine("Senha Trocada com sucesso");
                }


            System.Console.WriteLine("Bem vindo a sua conta corrente");

            System.Console.WriteLine("Cadastro de conta corrente: ");
            System.Console.WriteLine();

            System.Console.WriteLine("Digite sua agência: ");
            int agencia = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite sua conta: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite seu titular: ");
            string Titular = Console.ReadLine();

            bool saldoInvalido = true;
            do
            {
                System.Console.WriteLine("Digite o saldo: ");
                double saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0)
                {
                    saldoInvalido = false;
                }
                else
                {
                    System.Console.WriteLine("O saldo não pode negativo");
                }
            }
            while (!saldoInvalido);

            System.Console.WriteLine("O que você deseja fazer?");
            System.Console.WriteLine("(1)Depositar  (2)Sacar (3)Transferir");

            string opcaoBanco = Console.ReadLine();

            switch (opcaoBanco)
            {
                case "1":
                    double saldo = double.Parse(Console.ReadLine());
                    if (saldo >= 0)
                    {
                        saldoInvalido = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Somente deposito");
                    }
                    break;
                case "2":
                    System.Console.WriteLine("Quanto você gostaria de sacar?");
                    break;
            }
        }
    }
}
