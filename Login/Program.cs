using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;

            Console.WriteLine("Insira seu e-mail");
            login = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            password = Console.ReadLine();

            if((login == "admin")  && (password == "admin"))
                Console.WriteLine("Você é um ademir");
                else{
                    Console.WriteLine("Você é um usuario");
                }

        
        }
    }
}
