using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Novo1 : Imovel1
    {
        public double Adicional { get; set; }

        public override void CalculaValor()
        {
            Preco = Preco + Adicional;
        }
    }
}
