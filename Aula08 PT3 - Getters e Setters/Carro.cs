using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class Carro
    {
        private string nome, marca, anoDeFabricacao, placa;

        public Carro(string nome, string marca, string anoDeFabricacao, string placa)
        {
            this.nome = nome;
            this.marca = marca;
            this.anoDeFabricacao = anoDeFabricacao;
            this.placa = placa;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return marca;
        }

        public void SetAnoDeFabricacao(string anoDeFabricacao)
        {
            this.anoDeFabricacao = anoDeFabricacao;
        }
        public string GetAnoDeFabricacao()
        {
            return anoDeFabricacao;
        }

        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }
        public string GetPlaca()
        {
            return placa;
        }
    }
}
