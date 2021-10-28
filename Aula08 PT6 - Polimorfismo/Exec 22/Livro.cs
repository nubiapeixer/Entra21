using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Livro : Produto
    {
        public string Autor { get; set; }
        public string Estilo { get; set; }
        

        public override void CalculaPreco()
        {
            Preco *= 1.55;
        }
    }
}
