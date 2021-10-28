using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms___Exec02
{
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Corrigido1().Show();
            this.Hide();
        }

        private void Admin2_Load(object sender, EventArgs e)
        {
            listUsuarios.Items.Add("UserName\tPassword\t\tAccessLevel");
            string select = "SELECT * from dbo.Usuario2";
            SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
            DBConnection.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string texto = "";
                for (int i = 1; i < 4; i++)
                {                    
                    texto += dr[i].ToString() + "\t\t";                    
                }
                listUsuarios.Items.Add(texto);

            }
            DBConnection.Connection.Close();
            dr.Close();

        }
    }
}
