namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente titular;
        public int agencia;
        public int conta;
        private double _saldo = 100;

        public ContaCorrente(int agencia,int conta)
        {
            Agencia = agencia;
            Conta = conta;
            ContaCorrente.TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;
        }

        public static int TotalContasCriadas { get; private set; }


        public int Conta
        {
            get
            {
                return conta;
            }
            set
            {
                conta = value;
            }
        }
        public int Agencia
        {
            get
            {
                return agencia;
            }
            set
            {
                agencia = value;
            }
        }
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

    