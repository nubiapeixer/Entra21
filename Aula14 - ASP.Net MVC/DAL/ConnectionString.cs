using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConnectionString
    {
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=BUE205D69;Initial Catalog=BDMATUTINO;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        public static void Open()
        {
            Connection.Open();
        }
        public static void Close()
        {
            Connection.Close();
        }
    }
}
