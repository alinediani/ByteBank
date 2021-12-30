using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class AumentarSalario
    {
        private double _totalSalario;
        public void Registrar(Funcionario funcionario)
        {
            _totalSalario += funcionario.GetAumento();
        }
        public double GetTotalSalario()
        {
            return _totalSalario;
        }
    }
}
