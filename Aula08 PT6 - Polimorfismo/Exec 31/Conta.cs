using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Conta : Transacao
    {
        public string NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public List<Transacao> Transacoes { get; set; }


        public virtual double Deposito()
        {            
            Console.WriteLine("Informe o valor do depósito");
            double deposito = Convert.ToDouble(Console.ReadLine());
            Saldo += deposito;
            Console.WriteLine("Saldo atual: {0:c}", Saldo);

            return deposito;

            
        }
        public virtual double Retirada()
        {
            Console.WriteLine("Informe o valor do saque");
            double saque = Convert.ToDouble(Console.ReadLine());
            if (Saldo >= saque)
            {
                Saldo -= saque;
                Console.WriteLine("Saque Efetuado");
                Console.WriteLine("Saldo atual: {0:c}", Saldo);
                return saque;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return 0;
            }

        }
        public virtual void Extrato()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Número da Conta: " + NumeroConta);
            Console.WriteLine("Saldo: {0:c}", Saldo);            
        }


    }
}
