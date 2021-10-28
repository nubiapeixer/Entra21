using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_OO_pt_04
{
    class Comportamento
    {
        public static double Comer(double comida)
        {
            return comida * 250;
        }
        public static int Descansar(int descansa)
        {
            return descansa * 100;
        }
        public static double Trabalhar (int trabalho)
        {
            return trabalho * 24.52;
        }
    }
}
