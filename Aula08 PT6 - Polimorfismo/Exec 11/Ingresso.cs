using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Ingresso
    {
        public double Valor { get; set; }
        public virtual void ImprimeValor()
        {
            Console.WriteLine(Valor);
        }
    }
}
