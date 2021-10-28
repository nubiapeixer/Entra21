using _18.AulaSQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.AulaSQL.Control
{
    public static class Controller01
    {
        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg))
            {
                return DBExec01.AdicionaPessoa(nome, cpf, rg);
            }
            else
            {
                return false;
            }
        }
        public static List<string[]> SelecionaPessoas()
        {
            return DBExec01.SelecionaPessoas();
        }        
        public static bool AdicionaFuncionario(string nome, string cpf, string rg, string salario)
        {
            if(!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg) && !string.IsNullOrEmpty(salario))
            {
                return DBExec01.AdicionaFuncionario(nome, cpf, rg, salario);
            }
            else
            {
                return false;
            }
        }

        public static List<string[]> SelecionaFuncionarios()
        {
            return DBExec01.SelecionaFuncionarios();
        }
        public static bool AdicionaCliente(string nome, string cpf, string rg, bool vip)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg))
            {
                return DBExec01.AdicionaCliente(nome, cpf, rg, vip);
            }
            else
            {
                return false;
            }
        }
        public static List<string[]> SelecionaClientes()
        {
            return DBExec01.SelecionaClientes();
        }



    }
}
