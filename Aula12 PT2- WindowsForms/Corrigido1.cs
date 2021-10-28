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
    public partial class Corrigido1 : Form
    {
        public Corrigido1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // lógica booleana
            // ! inverte para falso: se não estiver vazio ou nulo entra no if
            if (!string.IsNullOrEmpty(txtUsername.Text))
            {
                bool admin = false;
                string select = $"SELECT AccessLevel from dbo.Usuario2 WHERE UserName = '{txtUsername.Text}' and PasswordKey = '{txtPassword.Text}'";
                SqlCommand cmd = new SqlCommand(select, DBConnection.Connection);
                DBConnection.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (Convert.ToInt32(dr[0]) > 4)
                    {
                        // não da pra carregar a tela aqui, porque a conexão       ficará aberta e não da pra fechar também, porque ele       está sendo utilizado depois
                        // por isso usa booleano
                        admin = true;
                    }
                    else
                    {
                        MessageBox.Show("Login efetuado com sucesso");
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado");
                }
                DBConnection.Connection.Close();
                dr.Close();

                if (admin)
                {
                    new Admin2().Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("UserName está vazio");
            }
            txtPassword.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
