using System;

namespace mcbonalds
{
    class Program
    {
        static void Main(string[] args)
        {
                Cliente cliente1 = new Cliente("Alexandre","55 11 5555-5555","alexandre@gmail.com");

                Console.WriteLine("Nome: " + cliente1.Nome);
                Console.WriteLine("Telefone: " + cliente1.Telefone);
                Console.WriteLine("Email: " + cliente1.Email);
                Console.WriteLine();
                
        }
    }
}
