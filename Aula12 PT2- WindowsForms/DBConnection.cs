using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms___Exec02
{
    class DBConnection
    {
        // public static não precisa instanciar o objeto para usa-lo, só chama-lo
        // só quero pegar, não precisa do set porque não queremos alterar
        public static SqlConnection Connection { get; } = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        // é possível usar construtor
    }
}
