using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class Clientes
    {
        public string nome, cpf;
        public int vip;

        public Clientes(string nome, string cpf, int vip)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.vip = vip;
        }

    }
}
