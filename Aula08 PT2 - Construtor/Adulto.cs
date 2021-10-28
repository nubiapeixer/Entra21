using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class Adulto
    {
        public string nome;
        public int idade;

        public Adulto(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public static bool ConfereAdulto(int valor)
        {
            if(valor > 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
