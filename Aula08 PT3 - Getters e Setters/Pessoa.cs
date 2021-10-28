using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class Pessoa
    {
        private string nome, cpf;
        private int idade;

        public Pessoa(string nome, string cpf, int idade)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.idade = idade;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return cpf;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public int GetIdade()
        {
            return idade;
        }

    }
}
