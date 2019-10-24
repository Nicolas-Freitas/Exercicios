using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            double total;
            double totalA;
            double totalD;


            
            Console.WriteLine("Digite o valor da base: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da altura: ");
                num2 = int.Parse(Console.ReadLine());
                total = num1 * num2;
                totalA = (num1*2)  + (num2*2);
                totalD = Math.Sqrt((num1*num1) + (num2*num2));
                Console.WriteLine("O valor da área é: {0}",total);
                Console.WriteLine("O valor da diagonal é: {0}",totalD);
                Console.WriteLine("O valor da perímetro é: {0}",totalA);
        }
    }
}
