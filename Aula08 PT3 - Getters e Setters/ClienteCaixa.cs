using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class ClienteCaixa
    {
        private string nome, conta;
        private double saldo;

        public ClienteCaixa(string nome, string conta, double saldo)
        {
            this.nome = nome;
            this.conta = conta;
            this.saldo = saldo;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetConta(string conta)
        {
            this.conta = conta;
        }
        public string GetConta()
        {
            return conta;
        }

        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }
    }
}
