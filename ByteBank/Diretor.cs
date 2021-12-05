using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf): base(cpf)
        {

        }

        public double GetBonificacao()
        {
            return Salario;
        }

    }
}
