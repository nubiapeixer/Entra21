using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Administrativo : Assistente
    {
        public double Bonus { get; set; }
        /// <summary>
        /// True = dia, False = Noite
        /// </summary>
        public bool Turno { get; set; }

        public override void ExibeDados()
        {
            Console.WriteLine(Nome);
            if (Turno)
            {
                Console.WriteLine("{0:c}", Salario);
                Console.WriteLine("Dia");
            }
            else
            {
                Console.WriteLine("{0:c}", Salario + Bonus);
                Console.WriteLine("Noite");
            }
            Console.WriteLine(NumeroMatricula);
        }
    }
}
