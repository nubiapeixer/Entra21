using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Interfaces
{
    interface IPessoa
    {
        // Todos os atributos são public na Interface
        string Nome { get; set; }
        int Idade { get; set; }
        string Cpf { get; set; }

    }
}
