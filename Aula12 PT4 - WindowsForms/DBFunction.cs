using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=ENTRA21SENAC;Integrated Security=True");

        /// <summary>
        /// This function return all elements selected in the table, the table already include dbo.
        /// </summary>
        /// <param name="table"></param>
        /// <param name="element"></param>
        /// <returns>List(string) allSelectedElements</returns>
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
        /// <summary>
        /// This function return all elements selected in the table, the table already include dbo. and Where must be complete
        /// </summary>
        /// <param name="element"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<string> GenericUnitSelect(string element, string table, string where) //sobrecarga overload
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
        public static void Executa(string comando)
        {
            DBFunction.Connection.Open();
            SqlCommand cmd = new SqlCommand(comando, Connection);
            cmd.ExecuteNonQuery();
            DBFunction.Connection.Close();
        }
    }
}
