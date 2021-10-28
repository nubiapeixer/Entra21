using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class GerenciaFunc
    {
        private string[] nome, cargo, login;
        private double[] salario;

        public GerenciaFunc(string[] nome, string[] cargo, string[] login, double[] salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.login = login;
            this.salario = salario;
        }
        public void SetNome(string[] nome)
        {
            this.nome = nome;
        }
        public string[] GetNome()
        {
            return nome;
        }
        public void SetCargo(string[] cargo)
        {
            this.cargo = cargo;
        }
        public string[] GetCargo()
        {
            return cargo;
        }
        public void SetLogin(string[] login)
        {
            this.login = login;
        }
        public string[] GetLogin()
        {
            return login;
        }
        public void SetSalario(double[] salario)
        {
            this.salario = salario;
        }
        public double[] GetSalario()
        {
            return salario;
        }
    }
}
