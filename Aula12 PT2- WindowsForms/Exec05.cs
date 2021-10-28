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
    public partial class Exec05 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");
        public Exec05()
        {
            InitializeComponent();
        }
        int operacao = -1;


        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacao = 2;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao = 3;
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = 4;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
            string sinal = "";
            if (operacao == 1)
            {
                resultado = numero1 + numero2;
                txtResultado.Text = Convert.ToString(resultado);
                sinal = "+";
            }
            else if (operacao == 2)
            {
                resultado = numero1 - numero2;
                txtResultado.Text = Convert.ToString(resultado);
                sinal = "-";
            }
            else if (operacao == 3)
            {
                resultado = numero1 * numero2;
                txtResultado.Text = Convert.ToString(resultado);
                sinal = "*";
            }
            else if (operacao == 4)
            {
                resultado = numero1 / numero2;
                txtResultado.Text = Convert.ToString(resultado);
                sinal = "/";
            }
            else
            {
                MessageBox.Show("Operação incorreta");
            }

            if (operacao == 1 || operacao == 2 || operacao == 3 || operacao == 4)
            {

                string calculo = txtNumero1.Text + sinal + txtNumero2.Text + "=" + txtResultado.Text;
                string insert = $"INSERT into dbo.Operacao (Operacao) values ('{calculo}')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }


        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Operacoes f = new Operacoes();
            this.FindForm().Hide();
            f.Show();
        }

        private void Exec05_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
