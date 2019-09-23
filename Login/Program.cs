using System;

namespace usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string password;

            Console.WriteLine("Insira seu e-mail");
            usuario = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            password = Console.ReadLine();

            if((usuario == "admin")  && (password == "admin"))
                Console.WriteLine("Você é um ademir");
                else{
                    Console.WriteLine("Você é um usuario");
                }

        
        }
    }
}
