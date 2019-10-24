using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Insira o valor de A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            b = int.Parse(Console.ReadLine());

            a += b;     
            b = a - b;
            a -= b;

            System.Console.WriteLine($"O valor de A é {a} o valor de B é {b}");
            
        }
    }
}
