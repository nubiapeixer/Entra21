using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Funções_MultiRetorno
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=ENTRA21SENAC;Integrated Security=True");

        public static void GenericExecute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// Função retorna os elementos selecionados da tabela do banco de dados.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string> GenericUnitSelect(string element, string table)
        {
            List<string> returnElements = new List<string>();
            string select = $"SELECT {element} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return returnElements;
        }

        public static List<string> GenericUnitSelect(string element, string table, string where) // Overloading/Sobrecarga
        {
            List<string> returnElements = new List<string>();
            string select = $"SELECT {element} from dbo.{table} WHERE {where}";
            SqlCommand cmd = new SqlCommand(select, Connection);
            Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                returnElements.Add(dr[0].ToString());
            }
            dr.Close();
            Connection.Close();
            return returnElements;
        }

        /// <summary>
        /// Seleciona todos os valores e adiciona em uma lista de vetores.
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> list = new List<string[]>();
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
                list.Add(array);
            }
            dr.Close();
            Connection.Close();
            return list;
        }

    }
}
