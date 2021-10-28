using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class CaixaEletro
    {
        private double saldo;
        private string[] contas;

        public CaixaEletro(double saldo, string[] contas)
        {
            this.saldo = saldo;
            this.contas = contas;
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public void SetContas(string[] contas)
        {
            this.contas = contas;
        }
        public string[] GetContas()
        {
            return contas;
        }






    }
}
