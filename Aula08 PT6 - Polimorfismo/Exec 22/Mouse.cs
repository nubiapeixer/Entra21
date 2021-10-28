using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Mouse : Produto
    {
        public double Dpi { get; set; }
        public string Modelo { get; set; }       


        public override void CalculaPreco()
        {
            Preco = (Preco * 2.3) + Dpi;
        }
    }

}
