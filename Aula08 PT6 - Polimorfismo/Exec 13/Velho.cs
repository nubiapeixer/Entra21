using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Velho : Imovel
    {
        public double Desconto { get; set; }

        public Velho(double preco, string endereco) : base(preco, endereco)
        {

        }

        public override void CalculaValor()
        {
            base.CalculaValor();
            Preco -= Desconto;
            Console.WriteLine("Imóvel Velho");
            Console.WriteLine("Preço Desconto: " + "{0:c}", Desconto);
            Console.WriteLine("Preço Total: " + "{0:c}", Preco);
        }
    }
}
