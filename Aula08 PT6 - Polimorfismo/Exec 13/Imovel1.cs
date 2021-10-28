using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Imovel1
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }

        public virtual void CalculaValor()
        {

        }
    }
}
