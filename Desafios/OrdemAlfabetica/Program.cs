using System;
using System.Collections.Generic;


namespace OrdemAlfabetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;
            Console.WriteLine("Insira o primeiro nome:");
            nome1 = Console.ReadLine();
            System.Console.WriteLine("Insira o segundo nome:");
            nome2 = Console.ReadLine();
            Console.Clear();
            System.Console.WriteLine("Aqui estão seus nomes em ordem alfabética!");

            List<string> lista = new List<string>();

            lista.Add(nome1);
            lista.Add(nome2);

            lista.Sort();

            foreach (string item in lista)
                Console.WriteLine(item);
        }
    }
}
