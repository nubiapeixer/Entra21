using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Imovel
    {
        public double Preco { get; set; }
        public string Endereco { get; set; }

        public Imovel(double preco, string endereco)
        {
            Preco = preco;
            Endereco = endereco;
        }
        public virtual void CalculaValor()
        {
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Preço: " + "{0:c}",Preco);
        }
    }
}
