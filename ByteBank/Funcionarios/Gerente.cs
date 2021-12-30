using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Gerente : FuncionarioAutenticavel
    {
        public Gerente(string cpf, double salario) : base(cpf, salario)
        {

        }
        public override double GetAumento()
        {
            return Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

    }
}
