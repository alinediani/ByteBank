using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int _agencia;
        private readonly int _conta;
        private double _saldo = 100;
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciaNaoPermitidas { get; private set; }




        public static int TotalContasCriadas { get; private set; }


        public int Conta
        {
            get 
            {
                return _conta;
            }
        }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                _agencia = value;
            }
        }
        public ContaCorrente(int agencia, int conta)
        {
           if (agencia <= 0)
            {
                ArgumentException excecao = new ArgumentException("A agência deve ser maior que zero",nameof(agencia));
                throw excecao;
            }
            if (conta <= 0)
            {
                ArgumentException excecao = new ArgumentException("O número devem ser maior que zero",nameof(conta));
                throw excecao;
            }
            _agencia = agencia;
            _conta = conta;
            ContaCorrente.TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;
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

     

        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsufucienteException(Saldo, valor);
            }
            if(valor < 0)
            {
                throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
            }
            if (_saldo < valor)
            {
                throw new SaldoInsufucienteException(_saldo, valor);
            }
            _saldo -= valor;
           
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsufucienteException)
            {
                ContadorTransferenciaNaoPermitidas++;
                throw;
            }
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido", nameof(valor));
            }
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
        
    }
}

    