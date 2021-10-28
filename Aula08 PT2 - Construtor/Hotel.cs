using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class Hotel
    {
        public string nome;
        public int qtdSolteiro, qtdCasal;

        public Hotel(string nome, int qtdSolteiro, int qtdCasal)
        {
            this.nome = nome;
            this.qtdSolteiro = qtdSolteiro;
            this.qtdCasal = qtdCasal;
        }


    }
}
