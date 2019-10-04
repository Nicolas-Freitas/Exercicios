using System;
using ContaCorrente;

namespace ContaCorrente {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Bem vindo a sua conta corrente");

            System.Console.WriteLine ("Cadastro de conta corrente: ");
            System.Console.WriteLine ();

            System.Console.WriteLine ("Digite sua agência: ");
            int agencia = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua conta: ");
            int numero = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite seu titular: ");
            string cliente = Console.ReadLine ();

            bool saldoInvalido = true;
            do {
                System.Console.WriteLine ("Digite o saldo: ");
                double saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0){
                    saldoInvalido = false;
                }
                else{
                    System.Console.WriteLine("O saldo não pode negativo");
                }
            }
            while (!saldoInvalido);

            
        }
    }
}