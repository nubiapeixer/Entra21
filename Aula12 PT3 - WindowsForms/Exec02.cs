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

namespace _14.Windows_Form_parte_3
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AtualizaDG()
        {
            // Rows = Linhas
            // Limpa antes de atualizar, senão soma a lista anterior com a atualizada
            dgMercado.Rows.Clear();

            string select = $"SELECT * from dbo.MercadoCadastro";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string[] vetor = {dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString() };
                dgMercado.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (checkAdd.Checked)
            {
                string insert = $"INSERT into dbo.MercadoCadastro (Nome,Preco,Fornecedor) values ('{txtNome.Text}',{txtPreco.Text},'{txtFornecedor.Text}')";
                DBFunction.Executa(insert);
                AtualizaDG();
            }
            else if (checkRemover.Checked)
            {
                string delete = $"DELETE from dbo.MercadoCadastro WHERE idProduto = {txtNome.Text}";
                DBFunction.Executa(delete);
                AtualizaDG();
            }
            else
            {
                MessageBox.Show("Por favor, escolha uma das opções");
            }
            txtNome.Clear();
            txtPreco.Clear();
            txtFornecedor.Clear();
        }

        private void checkAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdd.Checked)
            {
                checkRemover.Checked = false;
                lblNome.Text = "Nome";
                txtPreco.Visible = true;
                txtFornecedor.Visible = true;
                lblPreco.Visible = true;
                lblFornecedor.Visible = true;
            }
        }

        private void checkRemover_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRemover.Checked)
            {
                checkAdd.Checked = false;
                lblNome.Text = "ID";
                txtPreco.Visible = false;
                txtFornecedor.Visible = false;
                lblPreco.Visible = false;
                lblFornecedor.Visible = false;
            }
        }

        private void Exec02_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }
    }
}
