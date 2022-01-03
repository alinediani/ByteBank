using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("Catch no metodo main");
            }
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Não é possível fazer divisão por 0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Aconteceu um erro");
            }
            ContaCorrente contaDaAline = new ContaCorrente(123, 312313123);
            Cliente clienteAline = new Cliente();
            ContaCorrente contaDaAna = new ContaCorrente(123, 343241213);
            Cliente clienteAna = new Cliente();
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Designer edison = new Designer("1233131",5000);
            Diretor juliana = new Diretor("45254523",3000);


            contaDaAline.Saldo=1000;
            clienteAline.nome = "Aline";
            clienteAline.cpf = "123456789";
            clienteAline.idade = 22;
            clienteAline.profissao = "Desenvolvedora";
            contaDaAline.Titular = clienteAline;

            
            clienteAna.nome = "Ana";
            clienteAna.cpf = "987654321";
            clienteAna.idade = 16;
            clienteAna.profissao = "Tradutora";
            contaDaAna.Titular = clienteAna;

            edison.Nome = "Edison";
            edison.CPF = "3231432454656";

            juliana.Nome = "Juliana";
            juliana.CPF = "3232321";
            juliana.GetAumento();
            Console.WriteLine("Novo salário: " + juliana.Salario);

            contaDaAline.Saldo+=1000;
            contaDaAline.Sacar(100);
            contaDaAna.Depositar(300);
            contaDaAline.Transferir(500, contaDaAna);
            contaDaAna.Transferir(6, contaDaAline);
            gerenciador.Registrar(edison);
            gerenciador.Registrar(juliana);


            Console.WriteLine(contaDaAline.Titular.nome);
            Console.WriteLine(contaDaAline.Agencia);
            Console.WriteLine(contaDaAline.Conta);
            Console.WriteLine(contaDaAline.Saldo);

            Console.WriteLine(contaDaAna.Titular.nome);
            Console.WriteLine(contaDaAna.Agencia);
            Console.WriteLine(contaDaAna.Conta);
            Console.WriteLine(contaDaAna.Saldo);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Total de bonificacoes: " + gerenciador.GetTotalBonificacao());
            CalcularBonificacao();
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer anajulia = new Designer("2213123", 4000);
            anajulia.Nome = "Ana Julia";

            Diretor alined = new Diretor("2213121", 14000);
            alined.Nome = "Aline Diani";

            Auxiliar bib = new Auxiliar("23424324", 1000);
            bib.Nome = "Bib";

            Gerente ju = new Gerente("24324234", 2000);
            ju.Nome = " Ju";

            gerenciadorBonificacao.Registrar(anajulia);
            gerenciadorBonificacao.Registrar(alined);
            gerenciadorBonificacao.Registrar(bib);
            gerenciadorBonificacao.Registrar(ju);

            Console.WriteLine("Total: " + gerenciadorBonificacao.GetTotalBonificacao()) ;
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }
        private static void TestaDivisao (int divisor)
        {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
         
        }
        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com número = " + numero + " e divisor " + divisor);
                throw;
            }
           
        }
        private static void CarregarContas()
        {
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
        }
    }
}
