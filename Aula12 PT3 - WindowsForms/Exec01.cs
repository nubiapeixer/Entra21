using System;

using System.Data.SqlClient;

using System.Windows.Forms;

namespace _14.Windows_Form_parte_3
{
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                string select = $"SELECT * from dbo.Usuario WHERE LoginUser = '{txtUsuario.Text}'";
                SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
                DBFunction.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (txtSenha.Text == dr["PasswordKey"].ToString())
                    {
                        if (cb2.Checked && cb3.Checked && !cb1.Checked && !cb4.Checked && !cb5.Checked)
                        {
                            MessageBox.Show("Login efetuado");
                        }
                        else
                        {
                            MessageBox.Show("Login não efetuado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login incorreto");
                    }

                }
                else
                {
                    MessageBox.Show("Login não encontrado");
                }
                dr.Close();
                DBFunction.Connection.Close();
            }
            else
            {
                MessageBox.Show("Campo vazio");
            }
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
