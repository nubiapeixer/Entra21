using MVC_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_2.Control
{
    class Controller1
    {

        public static List<string[]> SelectAll(string table)
        {
            if (!string.IsNullOrEmpty(table))
            {
                return DBFunction.GenericSelectAll(table);
            }
            else
            {
                return new List<string[]>();
            }
        }
        public static bool ConfereAdiciona(string nome, string cnpj, string quantia)
        {
            if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cnpj) && !string.IsNullOrEmpty(quantia))
            {
                
                return DBFunction.GenericInsertCliente(nome,cnpj,quantia);
            }
            else
            {
                return false;
            }
        }
        public static bool ConfereRemove(string table, string nome)
        {
            if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(table))
            {
                return DBFunction.GenericRemove(table, nome);
            }
            else
            {
                return false;
            }
        }

        

    }
}
