using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class Produto
    {
        public string produto;
        public double preco;
        public int quantidade;

        public Produto(string produto, double preco, int quantidade)
        {
            this.produto = produto;
            this.preco = preco;
            this.quantidade = quantidade;
        }
    }
}
