using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class PessoaFisica : Agenda
    {
        public string Cpf { get; set; }        
        public string Nascimento { get; set; }        
        public string EstadoCivil { get; set; }
        public override void MostraLista()
        {
            base.MostraLista();
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Nascimento: " + Nascimento);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
        }
    }
}
