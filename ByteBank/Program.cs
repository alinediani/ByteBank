using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaAline = new ContaCorrente(123, 312313123);
            Cliente clienteAline = new Cliente();
            ContaCorrente contaDaAna = new ContaCorrente(123, 343241213);
            Cliente clienteAna = new Cliente();
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario edison = new Funcionario();
            Diretor juliana = new Diretor();


            contaDaAline.Saldo=1000;
            clienteAline.nome = "Aline";
            clienteAline.cpf = "123456789";
            clienteAline.idade = 22;
            clienteAline.profissao = "Desenvolvedora";
            contaDaAline.titular = clienteAline;

            
            clienteAna.nome = "Ana";
            clienteAna.cpf = "987654321";
            clienteAna.idade = 16;
            clienteAna.profissao = "Tradutora";
            contaDaAna.titular = clienteAna;

            edison.Nome = "Edison";
            edison.CPF = "3231432454656";
            edison.Salario = 8000;

            juliana.Nome = "Juliana";
            juliana.CPF = "3232321";
            juliana.Salario = 15000;

            contaDaAline.Saldo+=1000;
            contaDaAline.Sacar(100);
            contaDaAna.Depositar(300);
            contaDaAline.Transferir(500, contaDaAna);
            contaDaAna.Transferir(6, contaDaAline);
            gerenciador.Registrar(edison);
            gerenciador.Registrar(juliana);


            Console.WriteLine(contaDaAline.titular.nome);
            Console.WriteLine(contaDaAline.agencia);
            Console.WriteLine(contaDaAline.conta);
            Console.WriteLine(contaDaAline.Saldo);

            Console.WriteLine(contaDaAna.titular.nome);
            Console.WriteLine(contaDaAna.agencia);
            Console.WriteLine(contaDaAna.conta);
            Console.WriteLine(contaDaAna.Saldo);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine("Total de bonificacoes: " + gerenciador.GetTotalBonificacao());
        }
    }
}
