using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Poupanca : Conta
    {
        public string DataAniversário { get; set; }

        
        public override double Deposito()
        {
            double deposito;
            deposito = base.Deposito();
            return deposito;

        }
        public override double Retirada()
        {
            double saque;
            saque = base.Retirada();
            return saque;
        }
        public override void Extrato()
        {
            base.Extrato();
            Console.WriteLine("Aniversário: " + DataAniversário);
        }

    }
}
