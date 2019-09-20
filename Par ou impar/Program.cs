using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Digite um número");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
            Console.WriteLine("Seu número é Par");
            }

            else {
            Console.WriteLine("Seu número é Impar");
            }
        }
    }
}
