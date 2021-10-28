using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_OO_pt_04
{
    class Boleto : Pagamento
    {
        public string CodigoDeBarra { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
    }
}
