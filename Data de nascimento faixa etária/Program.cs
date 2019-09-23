using System;

namespace Data_de_nascimento_faixa_etária
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 2019;
            int anoNasc = 0;
            int idade;



            Console.WriteLine("Qual ano você nasceu?");
            anoNasc = int.Parse(Console.ReadLine());
            idade = anoAtual - anoNasc;

            Console.WriteLine("Sua idade atual é de: " + idade + " anos");

            if (idade <= 2){
                Console.WriteLine("Recém-Nascido");
            } 

            else if ((idade >= 3) && (idade < 11)){
                Console.WriteLine("Criança");
            } 

            else if ((idade >= 12) && (idade < 19)){
                Console.WriteLine("Adolescente");
            } 

            else if ((idade >= 20) && (idade < 65)){
                Console.WriteLine("Adulto");
            } 

            else if (idade >= 65){
                Console.WriteLine("Idoso");
            } 
            
            }
        }
    }

