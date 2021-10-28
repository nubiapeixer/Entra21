using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Cachorro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeDoDono { get; set; }
        public string Telefone { get; set; }

        public void MostraCao()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Nome);
            Console.WriteLine(NomeDoDono);
            Console.WriteLine(Telefone);
        }

    }
}
