using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_OO_pt_04
{
    class CalculadoraPersistente : Calculadora
    {
        public double Persistente { get; set; }

        public double Numero (double numero)
        {            
            return numero;
        }
    }
}
