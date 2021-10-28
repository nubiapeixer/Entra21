using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class Empregados
    {
        public string nome, cpf;
        public double salario;

        public Empregados(string nome, double salario, string cpf)
        {
            this.nome = nome;
            this.salario = salario;
            this.cpf = cpf;
        }
        public static double Aumento(double salario)
        {
            return salario * 1.2;
        }
    }
}
