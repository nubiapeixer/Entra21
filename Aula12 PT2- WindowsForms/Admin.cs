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
    public partial class Admin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string select = "SELECT * from dbo.Usuario";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string temp = "";
                temp += "Usuário: " + dr[1].ToString() + " ";
                temp += "Senha: " + dr[2].ToString();
                listContas.Items.Add(temp);
            }
            dr.Close();
            conn.Close();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Exec01 f = new Exec01();
            this.FindForm().Hide();
            f.Show();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
