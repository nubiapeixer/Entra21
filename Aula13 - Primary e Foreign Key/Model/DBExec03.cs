using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace _18.AulaSQL.Model
{
    public static class DBExec03
    {
        private static SqlConnection Connection { get; set; } = DBFunction.Connection;

        private static SqlCommand Cmd { get; set; } = new SqlCommand("", Connection);

        public static bool AdicionaCachorro(string nome, string idade)
        {
            string insert = $"INSERT into dbo.Cachorro (Nome,Idade) values ('{nome}', {Convert.ToInt32(idade).ToString()})";
            Cmd.CommandText = insert;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
        public static bool AtualizaCachorroDopamina(string nome, string qtd)
        {
            int dopamina = (Convert.ToInt32(qtd) * 250);

            string update = $"UPDATE dbo.Cachorro set Dopamina += {dopamina} WHERE Nome = '{nome}'";
            Cmd.CommandText = update;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();
            
            return true;
        }
        public static bool AtualizaCachorroConforto(string nome, string qtd)
        {
            int descansar = (Convert.ToInt32(qtd) * 100);

            string update = $"UPDATE dbo.Cachorro set Conforto += {descansar} WHERE Nome = '{nome}'";
            Cmd.CommandText = update;
            Connection.Open();
            Cmd.ExecuteNonQuery();
            Connection.Close();

            return true;
        }
        public static List<string[]> SelecionaTodos(string table)
        {
            List<string[]> listElements = new List<string[]>();
            string select = $"SELECT Nome,Idade,Dopamina,Conforto from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] array = new string[dr.FieldCount];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = dr[i].ToString();
                }
                listElements.Add(array);
            }
            dr.Close();
            Connection.Close();

            return listElements;
        }
    }
}
