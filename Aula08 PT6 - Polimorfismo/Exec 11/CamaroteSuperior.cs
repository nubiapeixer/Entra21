using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class CamaroteSuperior : VIP
    {
        public string Localizacao { get; set; }

        public override void ImprimeValor()
        {
            base.ImprimeValor();
        }
    }
}
