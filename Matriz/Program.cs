using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
           
        Console.WriteLine("Matriz");
        int[] vetor = {1,2,3,4,5,6};

        for(int i=0; i<7; i++)
        Console.WriteLine(vetor[i]);

        if (vetor[i] % 2 == 0){

        Console.WriteLine("Esse número é par");
        }else{
        Console.WriteLine("Esse número é ímpar");
        }
        
        }
    }
}
