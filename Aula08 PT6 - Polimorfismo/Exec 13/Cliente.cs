using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Cliente
    {
        public string Nome { get; set; }
        public double Dinheiro { get; set; }
        public Cliente(string nome, double dinheiro)
        {
            Nome = nome;
            Dinheiro = dinheiro;
        }
    }
}
