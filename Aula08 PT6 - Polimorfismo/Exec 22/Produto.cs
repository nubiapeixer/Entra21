using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        

        public virtual void CalculaPreco()
        {

        }
    }
}
