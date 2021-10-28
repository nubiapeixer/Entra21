using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Windows_Form_parte_3
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=ENTRA21SENAC;Integrated Security=True");

        public static void Executa(string comando)
        {
            SqlCommand cmd = new SqlCommand(comando, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }


    }
}
