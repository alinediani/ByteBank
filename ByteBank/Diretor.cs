﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf,double salario): base(cpf, salario)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

    }
}
