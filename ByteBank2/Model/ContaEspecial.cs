using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Model
{
    public class ContaEspecial : ContaBancaria
    {
        public double Limite;
        public ContaEspecial(int Agencia, int NumeroConta, string Titular):base(Agencia,NumeroConta,Titular)
        {
            Limite = 0.0;
        }

        public override bool Saque(double valor)
        {
            if (valor >= 0)
            {
                if (valor <= base.Saldo + Limite)
                {
                    Saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool setLimite(double valor)
        {
            if(valor >= 0)
            {
                Limite = valor;
                return true;
            }
            return false;
        }
    }
}