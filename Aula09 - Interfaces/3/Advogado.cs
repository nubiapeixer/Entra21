using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Interfaces
{
    class Advogado : IAdvogado
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public List<string> ListaCrimes { get; set; }
        public double QtdAnosPreso { get; set; }
        public string DataPrisao { get; set; }
    }
}
