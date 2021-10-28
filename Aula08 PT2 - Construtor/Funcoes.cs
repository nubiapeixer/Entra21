using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    public static class Funcoes
    {
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double CRD()
        {
            return Convert.ToDouble(CR());
        }
    }
}
