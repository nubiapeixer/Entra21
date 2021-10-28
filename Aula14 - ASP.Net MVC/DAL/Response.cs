using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Response
    {
        public bool Executed { get; set; } // Conferir se deu certo
        public string ErrorMessage { get; set; } // Mensagem de erro
        public Exception Exception { get; set; }
    }
}
