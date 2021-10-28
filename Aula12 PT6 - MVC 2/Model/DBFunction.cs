using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_2.Model
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=ENTRA21SENAC;Integrated Security=True");

        public static bool GenericInsertCliente(string nome, string cnpj, string quantia)
        {
            string insert = $"INSERT into dbo.Cliente (Nome,Cnpj,ValorDaCompraMensal) values ('{nome}','{cnpj}',{Convert.ToInt32(quantia)})";
            SqlCommand cmd = new SqlCommand(insert, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
            return true;
        }
        public static bool GenericRemove(string table, string nome)
        {
            string delete = $"DELETE from dbo.{table} WHERE Nome = '{nome}'";
            SqlCommand cmd = new SqlCommand(delete, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
            return true;
        }


        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> listElements = new List<string[]>();
            string select = $"SELECT * from dbo.{table}";
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
