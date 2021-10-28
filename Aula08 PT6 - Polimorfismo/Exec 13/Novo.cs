using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Novo : Imovel
    {
        public double PrecoAdicional { get; set; }
        public Novo(double preco, string endereco) : base(preco, endereco)
        {

        }


        public override void CalculaValor()
        {
            base.CalculaValor();
            Preco += PrecoAdicional;
            Console.WriteLine("Imóvel Novo");
            Console.WriteLine("Preço Adicional: " + "{0:c}", PrecoAdicional);
            Console.WriteLine("Preço Total: " + "{0:c}", Preco);
        }
    }
}
