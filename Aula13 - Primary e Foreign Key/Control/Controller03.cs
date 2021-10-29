using _18.AulaSQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.AulaSQL.Control
{
    public static class Controller03
    {
        public static bool AdicionaCachorro(string nome, string idade)
        {
            if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(idade))
            {
                return DBExec03.AdicionaCachorro(nome, idade);
            }
            else
            {
                return false;
            }
        }
        public static bool AtualizaCachorroDopamina(string nome, string qtd)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(qtd))
            {
                return DBExec03.AtualizaCachorroDopamina(nome, qtd);
            }
            else
            {
                return false;
            }
        }
        public static bool AtualizaCachorroConforto(string nome, string qtd)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(qtd))
            {
                return DBExec03.AtualizaCachorroConforto(nome, qtd);
            }
            else
            {
                return false;
            }
        }
        public static List<string[]> SelecionaTodos(string table)
        {
            if (!string.IsNullOrEmpty(table))
            {
                return DBExec03.SelecionaTodos(table);
            }
            else
            {
                return new List<string[]>();
            }
        }
    }
}
