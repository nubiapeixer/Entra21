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
    public partial class Exec01 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public Exec01()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string select = $"SELECT * from dbo.Usuario WHERE LoginUser = '{txtUsuario.Text}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            
            if (dr.Read())
            {
                if(txtSenha.Text == dr["PasswordKey"].ToString())
                {
                    if(txtUsuario.Text == "Admin")
                    {
                        Admin f = new Admin();
                        this.FindForm().Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Efetuado");
                    }                   
                }
                else
                {
                    MessageBox.Show("Sua conta ou senha está incorreta");
                }
            }
            else
            {
                MessageBox.Show("Sua conta ou senha está incorreta");
            }
            dr.Close();
            conn.Close();

            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
