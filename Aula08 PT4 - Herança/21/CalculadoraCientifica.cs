using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_OO_pt_04
{
    class CalculadoraCientifica : Calculadora
    {
        public double Potenciacao(double x, double y)
        {
            return Math.Pow(x,y);
        }
        public double Raiz(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
