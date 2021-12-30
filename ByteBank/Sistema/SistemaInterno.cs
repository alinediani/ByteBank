using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    class SistemaInterno
    {
        public bool Logar(Autenticavel autenticavel,string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
