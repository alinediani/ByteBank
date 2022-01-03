using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsufucienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsufucienteException(double saldo, double valorSaque) : this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsufucienteException()
        {
            
        }
        public SaldoInsufucienteException (string mensagem) : base(mensagem)
        {

        }
    }
}
