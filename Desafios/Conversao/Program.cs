using System;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int C;
            int F;
            Console.WriteLine("Quantos graus você deseja converter para F");
            C = int.Parse(Console.ReadLine());

            F = (C*9/5) + 32;
            System.Console.WriteLine($"O resultado é {F}");
            
            
        }
    }
}
