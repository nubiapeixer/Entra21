using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_OO_pt_04
{
    class Funcionarios : DadosBancarios
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }
}
