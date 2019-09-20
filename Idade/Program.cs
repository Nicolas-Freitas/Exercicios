using System;

namespace Idade
{
     class Program
    {
        static void Main(string[] args)
        {
           double nota1,nota2,nota3,nota4;
      
            Console.Write("Entre a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
        
            Console.Write("Entre a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
        
            Console.Write("Entre a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
        
            Console.Write("Entre a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
        

            double result = (nota1 + nota2 + nota3 + nota4) / 4;
            
            if (result>=7)
            {
            Console.WriteLine("Aluno aprovado sua média é: {0}  ", result);  
            }
            else
            {
                Console.WriteLine("Aluno reprovado sua média é: {0} ", result); 
            }
        }     
   }
}