using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class Aluno
    {
        private string nome;
        private double[] notas;

        public Aluno(string nome, double[] notas)
        {
            this.nome = nome;
            this.notas = notas;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNotas(double[] notas)
        {
            this.notas = notas;
        }
        public double[] GetNotas()
        {
            return notas;
        }
    }
}
