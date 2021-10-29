using _18.AulaSQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.AulaSQL.Control
{
    public static class Controller02
    {
        public static bool AdicionaPessoa(string nome, string idade, string cpf, string rua, string numero, string cidade, string estado)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(idade) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rua) && !string.IsNullOrEmpty(numero) && !string.IsNullOrEmpty(cidade) && !string.IsNullOrEmpty(estado))
            {
                return DBExec02.AdicionaPessoa(nome, idade, cpf, rua, numero, cidade, estado);
            }
            else
            {
                return false;
 
            }                       
 
        }
        public static List<string[]> SelecionaPessoas()
        {
            return DBExec02.SelecionaPessoas();
        }

        public static bool AdicionaEmpresa(string nome, string qtdFuncionarios, string rua, string numero, string cidade, string estado)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(qtdFuncionarios) && !string.IsNullOrEmpty(rua) && !string.IsNullOrEmpty(numero) && !string.IsNullOrEmpty(cidade) && !string.IsNullOrEmpty(estado))
            {
                return DBExec02.AdicionaEmpresa(nome, qtdFuncionarios, rua, numero, cidade, estado);
            }
            else
            {
                return false;
            }
        }
        public static List<string[]> SelecionaEmpresas()
        {
            return DBExec02.SelecionaEmpresas();
        }

        public static bool AdicionaHabitacao(string nome, string tipo, string rua, string numero, string cidade, string estado)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(tipo) && !string.IsNullOrEmpty(rua) && !string.IsNullOrEmpty(numero) && !string.IsNullOrEmpty(cidade) && !string.IsNullOrEmpty(estado))
            {
                return DBExec02.AdicionaHabitacao(nome, tipo, rua, numero, cidade, estado);
            }
            else
            {
                return false;
            }
        }
        public static List<string[]> SelecionaHabitacoes()
        {
            return DBExec02.SelecionaHabitacoes();
        }
    }
}
