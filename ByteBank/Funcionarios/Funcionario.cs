using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get;protected set; }

        public Funcionario(string cpf, double salario)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        public abstract double GetAumento();
       
        public abstract double GetBonificacao();
        

    }
}
