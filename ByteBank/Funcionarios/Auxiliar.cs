using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf, double salario) : base(cpf, salario)
        {

        }
        public override double GetAumento()
        {
            return Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }

    }
}
