using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class SerHumano
    {
        public string nome;
        public int idade;
        public string genero;

        // atalho ctor = constructor

        public SerHumano(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }
    }
}
