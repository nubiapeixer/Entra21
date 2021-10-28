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
    public partial class ListaNomes : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public ListaNomes()
        {
            InitializeComponent();
        }

        private void ListaNomes_Load(object sender, EventArgs e)
        {
            string select = "SELECT * from dbo.Pessoa2";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string temp = "";
                temp += "ID: " + dr[0].ToString() + " ";
                temp += "Nome: " + dr[1].ToString();
                listBox1.Items.Add(temp);
            }
            dr.Close();
            conn.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Nome f = new Nome();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
