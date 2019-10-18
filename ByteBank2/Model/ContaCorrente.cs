using System;
using System.Collections.Generic;
using System.Text;
namespace ByteBank2.Model
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular): base(Agencia,NumeroConta,Titular)
        {

        }

        public override bool Saque(double valor)
        {
            if(valor >= 0)
            {
                if (valor <= base.Saldo)
                {
                    this.Saldo -= valor;
                    return true;
                }
                else{
                    return false;
                }
            }
            return false;
        }
    }
}
