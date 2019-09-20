using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            double total;
            int oper;

            Console.WriteLine("Digite o 1º Número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("(1) Soma | (2) Multiplicação | (3) Divisão | (4) Subtração |");
            Console.WriteLine("Qual o operador desejado");
            oper = int.Parse(Console.ReadLine());
            
            switch (oper) {
                case 1:
                    total = num1 + num2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 2:
                    total = num1 * num2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 3:
                    total = num1 / num2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 4:
                    total = num1 - num2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                default:
                    Console.WriteLine("Operação não reconhecida");
                    break;

                
            }

        
        }
    }
}
