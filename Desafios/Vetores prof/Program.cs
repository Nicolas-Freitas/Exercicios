using System;

namespace Vetores_prof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[5];
            for(int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Nome: ");
                vetor[i] = Console.ReadLine();
            }

            System.Console.WriteLine("Troca: ");
            string troca = Console.ReadLine();
            
            for (int y = 4; y >= 0; y--)
            {
                
                if(vetor[y] == troca)
                {
                    System.Console.WriteLine("Novo:");
                    vetor[y] = troca;
                    break;
                }
                System.Console.WriteLine("Não encontrei o ");
            }
        }
    }
}
