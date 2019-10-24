using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;
            double imc;
            Console.WriteLine("Qual o seu peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua altura");
            altura = double.Parse(Console.ReadLine());
            
            imc = peso / (altura*altura);

            System.Console.WriteLine($"Seu IMC É:{imc}");
            
        }
    }
}
