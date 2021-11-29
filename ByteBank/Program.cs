using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAline = new ContaCorrente();
            Cliente clienteAline = new Cliente();
            clienteAline.nome = "Aline";
            clienteAline.cpf = "123456789";
            clienteAline.idade = 22;
            clienteAline.profissao = "Desenvolvedora";

            contaDaAline.titular = clienteAline;
            contaDaAline.agencia = 123;
            contaDaAline.conta = 23232121;
            contaDaAline.saldo = 4234.9;

            ContaCorrente contaDaAna = new ContaCorrente();
            Cliente clienteAna = new Cliente();
            clienteAna.nome = "Ana";
            clienteAna.cpf = "987654321";
            clienteAna.idade = 16;
            clienteAna.profissao = "Tradutora";

            contaDaAna.titular = clienteAna;
            contaDaAna.agencia = 123;
            contaDaAna.conta = 23232122;

            contaDaAline.Sacar(100);
            contaDaAna.Depositar(300);
            contaDaAline.Transferir(500, contaDaAna);
            contaDaAna.Transferir(6, contaDaAline);

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
