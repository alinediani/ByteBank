using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAline = new ContaCorrente(123, 312313123);
            Cliente clienteAline = new Cliente();
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
          

            contaDaAline.Saldo=1000;
            clienteAline.nome = "Aline";
            clienteAline.cpf = "123456789";
            clienteAline.idade = 22;
            clienteAline.profissao = "Desenvolvedora";

            contaDaAline.titular = clienteAline;

            ContaCorrente contaDaAna = new ContaCorrente(123, 343241213);
            Cliente clienteAna = new Cliente();
            clienteAna.nome = "Ana";
            clienteAna.cpf = "987654321";
            clienteAna.idade = 16;
            clienteAna.profissao = "Tradutora";

            contaDaAna.titular = clienteAna;

            contaDaAline.Saldo+=1000;
            contaDaAline.Sacar(100);
            contaDaAna.Depositar(300);
            contaDaAline.Transferir(500, contaDaAna);
            contaDaAna.Transferir(6, contaDaAline);
            

            Console.WriteLine(contaDaAline.titular.nome);
            Console.WriteLine(contaDaAline.agencia);
            Console.WriteLine(contaDaAline.conta);
            Console.WriteLine(contaDaAline.Saldo);

            Console.WriteLine(contaDaAna.titular.nome);
            Console.WriteLine(contaDaAna.agencia);
            Console.WriteLine(contaDaAna.conta);
            Console.WriteLine(contaDaAna.Saldo);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Funcionario edison = new Funcionario(0);
            edison.Nome = "Edison";
            edison.CPF = "3231432454656";
            edison.Salario = 8000;
            gerenciador.Registrar(edison);

            Diretor juliana = new Diretor(1);
            juliana.Nome = "Juliana";
            juliana.CPF = "3232321";
            juliana.Salario = 15000;
            gerenciador.Registrar(juliana);

            Console.WriteLine("Total de bonificacoes: " + gerenciador.GetTotalBonificacao());
        }
    }
}
