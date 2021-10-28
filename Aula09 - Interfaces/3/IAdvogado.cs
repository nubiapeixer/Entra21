using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Interfaces
{
    interface IAdvogado
    {
        string Nome { get; set; }
        int Idade { get; set; }
        string Cpf { get; set; }
        List<string> ListaCrimes { get; set; }
        double QtdAnosPreso { get; set; }
        string DataPrisao { get; set; }
    }
}
