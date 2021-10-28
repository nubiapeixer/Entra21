using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual void ExibeDados()
        {
            Console.WriteLine(Nome);
            Console.WriteLine("{0:c}", Salario);
        }
    }
}
