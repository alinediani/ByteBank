namespace ByteBank
{
    public class ContaCorrente
    {

        public Cliente titular;
        public int agencia;
        public int conta;
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
               
             if (value < 0)
                {
                    return;
                }
             else
                {
                    _saldo = value;
                }
            }
        }

     

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                contaDestino._saldo += valor;
                this._saldo -= valor;
                return true;
            }
        }
    }
}

    