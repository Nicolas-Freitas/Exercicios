namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular {get;set;}
        public int Agencia {get;set;}
        public int Numero {get;set;}
        private double _saldo {get;set;}

        public double Saldo{
            get {return _saldo;}
        } 

        public ContaCorrente(int Agencia,int Numero,Cliente Titular){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this._saldo = 0.0;
        }

        public double Deposito(double valor){
            if (valor < 0){
                
            }else{
                System.Console.WriteLine("O deposito foi efetuado com sucesso");
            }
            this._saldo += valor;
            return this._saldo;
        }
        public bool Saque(double valor){
            
            if(valor <= this._saldo){
                this._saldo -= valor;
                return true;
            } else{
                return false;
            }
        }
        public bool Transferencia(ContaCorrente destino, double valor){
            if (this.Saque(valor)){
                destino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }
    }
}