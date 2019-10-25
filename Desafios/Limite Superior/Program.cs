using System;

namespace Limite_Superior
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;

            Console.WriteLine ("10 primeiros ímpares: ");
            num2 = int.Parse(Console.ReadLine());
            
            for (num = 1; num < num2; num+=2) {

                if (num % 2 != 0) {
                    Console.WriteLine ($"{num}");
                }
            }
        }
    }
}
