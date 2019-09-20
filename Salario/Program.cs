using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.WriteLine("Qual seu salario");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500){
                aumento = salario * 0.3;
                salario += aumento;
                Console.WriteLine("Parabéns, você ganhou um aumento!");
                Console.WriteLine("Seu novo salário é " + salario);
            } else {
                Console.Write("Desculpa, sem aumento salarial pra você!");
            }


            } 

        }
    }

