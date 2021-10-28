using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_OO_pt2
{
    class Alunos
    {
        string nome;
        double nota1, nota2, nota3;

        public Alunos(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public static double Media(double nota1, double nota2, double nota3)
        {
            return ((nota1 + nota2 + nota3) / 3);
        }
    }
}
