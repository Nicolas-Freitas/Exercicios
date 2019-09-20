using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do{
            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse (Console.ReadLine());

            if (num % 2 == 0){
            Console.WriteLine("Esse número é par");
            }else{
            Console.WriteLine("Esse número é ímpar");
            }
            } while(num != 0); 
        }
    }
}
