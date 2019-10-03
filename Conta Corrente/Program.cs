using System;

namespace Conta_Corrente
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bem vindo ao Banco tujjhipfse");
            ContaCorrente conta1 =  new ContaCorrente();
            System.Console.WriteLine("Cadastro de conta Corrente");
            System.Console.WriteLine();
            
            System.Console.WriteLine("Digite o titular");
            string titular = Console.ReadLine();
            System.Console.WriteLine("Digite o número da agência");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número da conta");
            int conta = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Ok, é necessário realizar o primeiro deposito por favor insira o valor que deseja inserir: ");
            conta1.Saldo = int.Parse(Console.ReadLine());

            bool saldoValido = false;
            double saldo;
            do{
                System.Console.WriteLine("Digite o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0){
                    saldoValido = true;
                } else {
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!saldoValido);
        }
    }
}
