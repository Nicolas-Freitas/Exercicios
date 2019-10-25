using System;

namespace Planetas
{
    class Program
    {   
        static void Main(string[] args)
        {
            double peso;
            
            System.Console.WriteLine("Digite seu peso em kg ");
            peso = int.Parse(Console.ReadLine());

            peso = peso *10;

            System.Console.WriteLine($"Seu peso em Mercúrio é {peso * 0.37}");
            System.Console.WriteLine($"Seu peso em Vênus é {peso *0.88}");
            System.Console.WriteLine($"Seu peso em Marte é {peso *0.38}");
            System.Console.WriteLine($"Seu peso em Júpiter é {peso *2.64}");
            System.Console.WriteLine($"Seu peso em Saturno é {peso *1.15}");
            System.Console.WriteLine($"Seu peso em Urano é {peso *1.17}");
        }
    }
}
