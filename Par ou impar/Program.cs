﻿using System;

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

            if (num % 3 == 0){
            Console.WriteLine("Esse número é multiplo de 3");
            }else{
            Console.WriteLine("O número não é multiplo de 3");
            }
            } while(num != 0); 
        }
    }
}
