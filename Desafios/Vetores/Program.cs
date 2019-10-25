using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int position;
            int i;

            System.Console.WriteLine("Insira os valores do vetor");
            position = int.Parse(Console.ReadLine());

            int[] vetor = new int [position];

            for (i = 0; i < position; i++){
                System.Console.WriteLine($"Digite o número {i+1}");
                vetor[i] = int.Parse(Console.ReadLine());
                System.Console.WriteLine(vetor[i]);
            }
        }
    }
}
