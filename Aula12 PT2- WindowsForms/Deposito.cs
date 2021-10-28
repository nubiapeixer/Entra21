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
    public partial class Deposito : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public Deposito()
        {
            InitializeComponent();
        }

        private void Deposito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string update = $"UPDATE dbo.Conta Set Saldo += {txtValor.Text} WHERE NumeroConta = {txtConta.Text}";
            SqlCommand cmd = new SqlCommand(update, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            txtConta.Clear();
            txtValor.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            int valor = ConfereSaldo();
            if(valor != 1)
            {
                MessageBox.Show("Saldo: R$" + valor.ToString());
            }
        }

        private int ConfereSaldo()
        {
            int retorno = -1;
            string select = $"SELECT Saldo from dbo.Conta WHERE NumeroConta = {txtConta.Text}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                retorno = Convert.ToInt32(dr[0]);
            }
            else
            {
                MessageBox.Show("Conta não encontrada");
            }
            dr.Close();
            conn.Close();
            return retorno;
        }
    }
}
