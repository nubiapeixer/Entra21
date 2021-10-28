using System.Data.SqlClient;

namespace _18.AulaSQL.Model
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=ENTRA21SENAC;Integrated Security=True");
    }
}
