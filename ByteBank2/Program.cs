using System;
using ByteBank2.Model;

namespace ByteBank2 {
    class Program {
        static void Main (string[] args) {
            string cliente1 = "Alexandre";
            string cliente2 = "César";

            #region Testa Conta Corrente
            ContaCorrente contaBancaria = new ContaCorrente (1, 1, cliente1);
            ContaEspecial contaEspecial = new ContaEspecial (1, 2, cliente2);
            contaBancaria.Deposito (10);
            #endregion 
            }

            #region  Depositos em conta.
            public static void DepositarConta (ContaBancaria contaBancaria) {
                System.Console.WriteLine ("ByteBank - Depósito");
                System.Console.WriteLine ("--------------------------");
                System.Console.WriteLine ();
                string usuario = contaBancaria.Titular;
                System.Console.WriteLine ($"Conta:{contaBancaria.GetType()}");
                Console.WriteLine ($"Bem-vindo - {usuario}");
                Console.WriteLine ($"Agência: {contaBancaria.Agencia}   Conta: {contaBancaria}");
                Console.WriteLine ($"Saldo: {contaBancaria.Saldo}");
                
                #endregion
        }
    }
}