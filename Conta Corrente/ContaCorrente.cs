namespace Conta_Corrente
{
    public class ContaCorrente
    {
        public string Cliente;
        public int Agencia;
        public int Numero;
        public double Saldo { get;set;}

        public ContaCorrente (int Agencia, int Numero, string Cliente){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Cliente = Cliente;
            this.Saldo = 0.0;

        }
    }
}