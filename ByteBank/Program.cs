using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAline = new ContaCorrente();
            contaDaAline.titular = "Aline";
            contaDaAline.agencia = 123;
            contaDaAline.conta = 23232121;
            contaDaAline.saldo = 4234.9;

            ContaCorrente contaDaAna = new ContaCorrente();
            contaDaAna.titular = "Ana";
            contaDaAna.agencia = 123;
            contaDaAna.conta = 23232122;

            contaDaAline.Sacar(100);

            Console.WriteLine(contaDaAline.titular);
            Console.WriteLine(contaDaAline.agencia);
            Console.WriteLine(contaDaAline.conta);
            Console.WriteLine(contaDaAline.saldo);

            Console.WriteLine(contaDaAna.titular);
            Console.WriteLine(contaDaAna.agencia);
            Console.WriteLine(contaDaAna.conta);
            Console.WriteLine(contaDaAna.saldo);

        }
    }
}
