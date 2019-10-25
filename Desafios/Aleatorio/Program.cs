using System;

namespace Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] vetor = new int[10];
            Random rm = new Random();

            for (i = 0; i < 10; i++)
            {
                vetor[i] = rm.Next(1, 100000000);
                System.Console.WriteLine($"{vetor[i]}");
            }

            Console.WriteLine("Os números pares e ímpares são: ");
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i] + " é par");
                }
                else
                {
                    Console.WriteLine(vetor[i] + " é ímpar");
                }
            }

        }
    }
}