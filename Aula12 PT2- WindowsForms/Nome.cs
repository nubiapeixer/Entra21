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
    public partial class Nome : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public Nome()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int valor = Confere();
            if (valor == 1)
            {
                string insert = $"INSERT into dbo.Pessoa2 (Nome) values ('{txtNome.Text}')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Nome cadastrado");
            }
            txtNome.Clear();
        }

        
        private int Confere()
        {
            int valor = -1;
            string select = $"SELECT Nome from dbo.Pessoa2 WHERE Nome = '{txtNome.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Nome já cadastrado");
            }
            else
            {
                valor = 1;
            }
            conn.Close();
            dr.Close();
            return valor;
        }

        private void Nome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaNomes f = new ListaNomes();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
