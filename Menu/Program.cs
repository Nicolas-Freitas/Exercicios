using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int oper;
            double total;
            string func;
        
        do{

            Console.WriteLine("Qual figura geométrica desejada?");
            Console.WriteLine("(1) Quadrado | (2) Triangulo | (3) Circulo | (4) Retângulo | (5) Trapézio | (6) Losango");
            oper = int.Parse(Console.ReadLine());

        switch (oper) {
                case 1:
                    Console.WriteLine("Digite o tamanho do lado:");
                    num1 = int.Parse(Console.ReadLine());
                    total = num1 * num1;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 2:
                    Console.WriteLine("Digite a base do triangulo:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura do triangulo:");
                    num2 = int.Parse(Console.ReadLine());
                    total = num1 * num2 / 2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 3: 
                    Console.WriteLine("Digite o raio do circulo");
                    num1 = int.Parse(Console.ReadLine());
                    total = num1 * num1 * 3.14;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 4:
                    Console.WriteLine("Digite a base: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura: ");
                    num2 = int.Parse(Console.ReadLine());
                    total = num1 * num2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 5:
                    Console.WriteLine("Digite o valor da base maior: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da base menor: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura: ");
                    num3 = int.Parse(Console.ReadLine());
                    total = (num1 + num2) * num3 / 2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;

                case 6:
                    Console.WriteLine("Digite o valor da diagonal maior: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da diagonal menor: ");
                    num2 = int.Parse(Console.ReadLine());
                    total = num1 * num2 / 2;
                    Console.WriteLine("O valor dessa operação é: {0}",total);
                break;



                default:
                    Console.WriteLine("Operação não reconhecida");
                    break;
                }
                Console.WriteLine("(1) para ir novamente ou (f) para sair");
                func = Console.ReadLine();}

                while(func == "1");
            }
        }
    }

