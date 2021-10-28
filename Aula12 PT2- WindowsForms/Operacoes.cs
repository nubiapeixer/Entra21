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
    public partial class Operacoes : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public Operacoes()
        {
            InitializeComponent();
        }

        private void Operacoes_Load(object sender, EventArgs e)
        {
            string select = "SELECT * from dbo.Operacao";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string temp = "";
                temp += dr[1].ToString();
                listOperacoes.Items.Add(temp);
            }
            dr.Close();
            conn.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Exec05 f = new Exec05();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            string delete = "DELETE from dbo.Operacao";
            SqlCommand cmd = new SqlCommand(delete, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("LISTA DELETADA");
            Exec05 f = new Exec05();
            this.FindForm().Hide();
            f.Show();
        }

        private void Operacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
