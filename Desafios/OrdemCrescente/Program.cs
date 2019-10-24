using System;
using System.Collections.Generic;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            System.Console.WriteLine("Insira três números:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            Console.Clear();
            System.Console.WriteLine("Aqui estão seus números organizados em ordem crescente!");

            List<int> lista = new List<int>();

            lista.Add(num1);
            lista.Add(num2);
            lista.Add(num3);

            lista.Sort();

            foreach (int item in lista)
                Console.WriteLine(item);
        }
    }
}
