using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public Autenticavel (string cpf, double salario) : base(cpf, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
