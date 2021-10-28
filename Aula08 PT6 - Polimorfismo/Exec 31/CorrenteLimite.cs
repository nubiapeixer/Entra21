using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class CorrenteLimite : Conta
    {
        public double ValorLimite { get; set; }

        public override void Extrato()
        {
            base.Extrato();
            Console.WriteLine("Valor Limite: {0:c}", ValorLimite);
        }
        public override double Deposito()
        {
            double deposito;
            deposito = base.Deposito();
            return deposito;
        }
        public override double Retirada()
        {
            Console.WriteLine("Informe o valor do saque");
            double saque = Convert.ToDouble(Console.ReadLine());
            if ((Saldo + ValorLimite) >= saque)
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

    }
}
