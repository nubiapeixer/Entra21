using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_pt_6___Polimorfismo
{
    class Transacao
    {
        public string DataTransacao { get; set; }
        public double ValorTransacao { get; set; }
        public string Descricao { get; set; }

        public void ExibirTransacao()
        {
            Console.WriteLine("Data da Última Transação: " + DataTransacao);
            Console.WriteLine("Valor da Última Transação: {0:c}", ValorTransacao);
            Console.WriteLine(Descricao);
        }
    }
}
