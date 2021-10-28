using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class Cachorro
    {
        private string nome, raca;
        private int idade;

        // atalho: seleciona tudo acima e aperta ctrl + .
        public Cachorro(string nome, string raca, int idade)
        {
            this.nome = nome;
            this.raca = raca;
            this.idade = idade;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;
        }

        public void SetRaca(string raca)
        {
            this.raca = raca;
        }
        public string GetRaca()
        {
            return raca;
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
