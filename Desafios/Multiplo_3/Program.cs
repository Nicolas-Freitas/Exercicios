using System;

namespace Multiplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do{
            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse (Console.ReadLine());

            if (num % 3 == 0){
            Console.WriteLine("Multiplo de 3");
            }else{
            Console.WriteLine("Esse número é ímpar");
            }
            } while(num != 0); 
        }
    }
}
