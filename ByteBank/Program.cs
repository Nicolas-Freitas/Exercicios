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
            
            Login login1 = new Login(Nome,Cpf,Email);

            do{
                System.Console.WriteLine("Digite a Senha");
                string senha = Console.ReadLine();
                bool senhaOk = login1.TrocaSenha(senha);
                if(!senhaOk){
                    System.Console.WriteLine("Senha não atende aos requsitos");
                } else {
                    System.Console.WriteLine("Senha Trocada com sucesso");
                }
            }while(!senhaOk);
        


        }
    }
}
