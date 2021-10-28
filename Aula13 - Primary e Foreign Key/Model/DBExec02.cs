using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _18.AulaSQL.Model
{
    public static class DBExec02
    {
        private static SqlConnection Connection { get; set; } = DBFunction.Connection;

        private static SqlCommand Cmd { get; set; } = new SqlCommand("", Connection);


        public static bool AdicionaPessoa(string nome, string idade, string cpf, string rua, string numero, string cidade, string estado)
        {
            // Primeira Parte: inserir dados na tabela de dbo.Endereco
            string insert = $"INSERT into dbo.Endereco (Rua,Numero,Cidade,Estado) values ('{rua}', '{numero}', '{cidade}','{estado}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            // Segunda Parte: seleciona o elemento recem inserido
            string select = $"SELECT Top 1 idEndereco from dbo.Endereco Order by idEndereco desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idEndereco = 0;
            if (dr.Read())
            {
                idEndereco = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            // Terceira Parte: insere o elemento selecionado + os valores faltantes na tabela de destino idPessoaEndereco
            insert = $"INSERT into dbo.PessoaEndereco (idEndereco, Nome, Idade, Cpf) values ({idEndereco}, '{nome}',{Convert.ToInt32(idade).ToString()},'{cpf}')";
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
            List<string> Nomes = new List<string>();
            List<string> Idades = new List<string>();
            List<string> Cpfs = new List<string>();

            string select = "SELECT * from dbo.PessoaEndereco";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                Nomes.Add(dr[1].ToString());
                Idades.Add(dr[2].ToString());
                Cpfs.Add(dr[3].ToString());
                idPessoa.Add(Convert.ToInt32(dr[4]));
            }
            dr.Close();
            Connection.Close();

            int index = 0;
            foreach (var item in idPessoa)
            {
                select = $"SELECT * from dbo.Endereco WHERE idEndereco = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount + 3];
                    for (int i = 3; i < dr.FieldCount + 3; i++)
                    {
                        vetor[i] = dr[i - 3].ToString();
                    }

                    vetor[0] = Nomes[index];
                    vetor[1] = Idades[index].ToString();
                    vetor[2] = Cpfs[index];
                    lista.Add(vetor);
                    index++;
                }
                dr.Close();
                Connection.Close();
            }

            return lista;
        }
        public static bool AdicionaEmpresa(string nome, string qtdFuncionarios, string rua, string numero, string cidade, string estado)
        {
            // Primeira Parte: inserir dados na tabela de dbo.Endereco

            string insert = $"INSERT into dbo.Endereco (Rua, Numero, Cidade, Estado) values ('{rua}', '{numero}', '{cidade}', '{estado}')";           

            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            // Segunda Parte: seleciona o elemento recem inserido
            string select = $"SELECT Top 1 idEndereco from dbo.Endereco Order by idEndereco desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idEndereco = 0;
            if (dr.Read())
            {
                idEndereco = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            // Terceira Parte: insere o elemento selecionado + os valores faltantes na tabela de destino idPessoaEndereco

            insert = $"INSERT into dbo.Empresa (idEndereco, Nome, QtdFuncionarios) values ({idEndereco}, '{nome}',{Convert.ToInt32(qtdFuncionarios).ToString()})";

            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }


        public static List<string[]> SelecionaEmpresas()
        {
            List<string[]> lista = new List<string[]>();
            List<int> idEndereco = new List<int>();
            List<string> Nomes = new List<string>();
            List<int> QtdFuncionarios = new List<int>();            

            string select = "SELECT * from dbo.Empresa";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                Nomes.Add(dr[1].ToString());
                QtdFuncionarios.Add(Convert.ToInt32(dr[2].ToString()));
                idEndereco.Add(Convert.ToInt32(dr[3]));
            }
            dr.Close();
            Connection.Close();

            int index = 0;
            foreach (var item in idEndereco)
            {
                select = $"SELECT * from dbo.Endereco WHERE idEndereco = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount + 2];
                    for (int i = 2; i < dr.FieldCount + 2; i++)
                    {
                        vetor[i] = dr[i - 2].ToString();
                    }

                    vetor[0] = Nomes[index];
                    vetor[1] = QtdFuncionarios[index].ToString();                    
                    lista.Add(vetor);
                    index++;
                }
                dr.Close();
                Connection.Close();
            }

            return lista;
        }

        public static bool AdicionaHabitacao(string nome, string tipo, string rua, string numero, string cidade, string estado)
        {
            // Primeira Parte: inserir dados na tabela de dbo.Endereco
            string insert = $"INSERT into dbo.Endereco (Rua, Numero, Cidade, Estado) values ('{rua}', '{numero}', '{cidade}', '{estado}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            // Segunda Parte: seleciona o elemento recem inserido
            string select = $"SELECT Top 1 idEndereco from dbo.Endereco Order by idEndereco desc";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            int idEndereco = 0;
            if (dr.Read())
            {
                idEndereco = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            Connection.Close();

            // Terceira Parte: insere o elemento selecionado + os valores faltantes na tabela de destino idPessoaEndereco
            insert = $"INSERT into dbo.Habitacao (idEndereco, NomeDoDono, Tipo) values ({idEndereco}, '{nome}','{tipo}')";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }
        public static List<string[]> SelecionaHabitacoes()
        {
            List<string[]> lista = new List<string[]>();
            List<int> idEndereco = new List<int>();
            List<string> Nomes = new List<string>();
            List<string> Tipos = new List<string>();

            string select = "SELECT * from dbo.Habitacao";
            Cmd.CommandText = select;
            Connection.Open();
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                Nomes.Add(dr[1].ToString());
                Tipos.Add(dr[2].ToString());                
                idEndereco.Add(Convert.ToInt32(dr[3]));
            }
            dr.Close();
            Connection.Close();

            int index = 0;
            foreach (var item in idEndereco)
            {
                select = $"SELECT * from dbo.Endereco WHERE idEndereco = {item}";
                Cmd.CommandText = select;
                Connection.Open();
                dr = Cmd.ExecuteReader();
                if (dr.Read())
                {
                    string[] vetor = new string[dr.FieldCount + 2];
                    for (int i = 2; i < dr.FieldCount + 2; i++)
                    {
                        vetor[i] = dr[i - 2].ToString();
                    }

                    vetor[0] = Nomes[index];
                    vetor[1] = Tipos[index];                    
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
