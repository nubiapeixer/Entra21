using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Agenda
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public virtual void MostraLista()
        {
            Console.WriteLine("Contato");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("E-mail: " + Email);
        }
    }
}
