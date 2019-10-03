namespace Conta_Corrente
{
    public class ContaCorrente
    {
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo { get;set;}

        public ContaCorrente (int Agencia, int Numero, string Titular){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }
    }
}