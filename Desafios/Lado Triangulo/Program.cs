using System;

namespace Lado_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            System.Console.WriteLine("Insira três arestas de um triângulo");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());

            if (num1 + num2 > num3){
                if ((num1 == num2)&&(num2 == num3)){
                    System.Console.WriteLine("Triângulo equilátero");
                }
                if ((num1 == num2)&&(num2 != num3)){
                    System.Console.WriteLine("Triângulo Isósceles");
                }
                if ((num1 != num2)&&(num2 != num3)){
                    System.Console.WriteLine("Triângulo Escaleno");
                }
            }
            else{
                System.Console.WriteLine("Isso não é um triângulo");
            }
            
        }
    }
}
