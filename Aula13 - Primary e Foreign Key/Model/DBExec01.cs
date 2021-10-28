using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.AulaSQL.Model
{
    public static class DBExec01
    {
        private static SqlConnection Connection { get; set; } = DBFunction.Connection;

        private static SqlCommand Cmd { get; set; } = new SqlCommand("", Connection);

        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            // Primeira Parte: inserir dados na tabela de dbo.Dados
            string insert = $"INSERT into dbo.Dados (Nome, Cpf, Rg) values ('{nome}', '{cpf}', '{rg}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            // Segunda Parte: seleciona o elemento recem inserido
            string select = $"SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idDados = 0;
            if (dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            // Terceira Parte: insere o elemento selecionado + os valores faltantes na tabela de destino idPessoaDados
            insert = $"INSERT into dbo.PessoaDados (idPessoa) values ({idDados})";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }

        public static List<string[]> SelecionaPessoas()
        {
            List<string[]> lista = new List<string[]>();
            List<int> idPessoa = new List<int>();

            // Primeira Parte: selecionar todos os id's da tabela pessoa
            string select = "SELECT * from dbo.PessoaDados";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                idPessoa.Add(Convert.ToInt32(dr[0]));
            }
            dr.Close();
            Connection.Close();

            // Segunda Parte: selecionar todas as informações do Dados onde idPessoa existe
            foreach (var item in idPessoa)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount];
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    lista.Add(vetor);
                }
                dr.Close();
                Connection.Close();
            }
            // Terceira Parte: Devolve para o controle
            return lista;

        }
        public static bool AdicionaFuncionario(string nome, string cpf, string rg, string salario)
        {
            string insert = $"INSERT into dbo.Dados (Nome, Cpf, Rg) values ('{nome}', '{cpf}', '{rg}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            string select = $"SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idDados = 0;
            if (dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            insert = $"INSERT into dbo.FuncionarioDados (idDados, Salario) values ({idDados}, {Convert.ToDouble(salario).ToString(CultureInfo.InvariantCulture)})";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }

        public static List<string[]> SelecionaFuncionarios()
        {
            List<string[]> lista = new List<string[]>();
            List<int> idFuncionario = new List<int>();
            List<string> salarios = new List<string>();

            string select = "SELECT * from dbo.FuncionarioDados";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                salarios.Add(dr[1].ToString());
                idFuncionario.Add(Convert.ToInt32(dr[2]));
            }
            dr.Close();
            Connection.Close();

            int index = 0;
            foreach (var item in idFuncionario)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    // acrescenta mais uma coluna para inserir os salários
                    string[] vetor = new string[dr.FieldCount + 1];
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    // insere na última coluna os salários
                    vetor[vetor.Length - 1] = salarios[index].ToString();
                    lista.Add(vetor);
                    index++;
                }
                dr.Close();
                Connection.Close();
            }

            return lista;

        }

        public static bool AdicionaCliente(string nome, string cpf, string rg, bool vip)
        {
            string insert = $"INSERT into dbo.Dados (Nome, Cpf, Rg) values ('{nome}', '{cpf}', '{rg}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            string select = $"SELECT Top 1 idDados from dbo.Dados Order by idDados desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idDados = 0;
            if (dr.Read())
            {
                idDados = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            insert = $"INSERT into dbo.ClienteDados (idDados, Vip) values ({idDados}, {Convert.ToInt32(vip).ToString()})";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }
        public static List<string[]> SelecionaClientes()
        {
            List<string[]> lista = new List<string[]>();
            List<int> idClientes = new List<int>();
            List<string> vip = new List<string>();

            string select = "SELECT * from dbo.ClienteDados";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                vip.Add(dr[1].ToString());
                idClientes.Add(Convert.ToInt32(dr[2]));
            }
            dr.Close();
            Connection.Close();

            int index = 0;
            foreach (var item in idClientes)
            {
                select = $"SELECT * from dbo.Dados WHERE idDados = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {                    
                    string[] vetor = new string[dr.FieldCount + 1];
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        vetor[i] = dr[i].ToString();
                    }
                    
                    vetor[vetor.Length - 1] = vip[index].ToString();
                    lista.Add(vetor);
                    index++;
                }
                dr.Close();
                Connection.Close();
            }

            return lista;

        }

    }
}
