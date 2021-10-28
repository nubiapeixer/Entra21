using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int Salario { get; set; }

        public void MostraFuncionario()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Nome);
            Console.WriteLine(Cargo);
            Console.WriteLine(Salario);
        }
    }
}
