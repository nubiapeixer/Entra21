using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class PessoaJuridica : Agenda
    {
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string RazaoSocial { get; set; }

        public override void MostraLista()
        {
            base.MostraLista();
            Console.WriteLine("CNPJ: " + Cnpj);
            Console.WriteLine("Inscrição Estadual: " + InscricaoEstadual);
            Console.WriteLine("Razão Social: " + RazaoSocial);
        }
    }
}
