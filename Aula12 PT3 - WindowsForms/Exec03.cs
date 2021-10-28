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
    public partial class Exec03 : Form
    {
        public Exec03()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtualizarLista()
        {
            dgProduto.Rows.Clear();
            string select = "SELECT idProduto,Nome,Preco from dbo.Mercado";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };
                dgProduto.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();

            dgCarrinho.Rows.Clear();
            string select2 = "SELECT idProduto,Nome,Preco from dbo.Carrinho";
            SqlCommand cmd2 = new SqlCommand(select2, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string[] vetor = { dr2[0].ToString(), dr2[1].ToString(), dr2[2].ToString() };
                dgCarrinho.Rows.Add(vetor);
            }
            dr2.Close();
            DBFunction.Connection.Close();
        }
        //private void AtualizarCarrinho()
        //{
        //    dgCarrinho.Rows.Clear();
        //    string select2 = "SELECT idProduto,Nome,Preco from dbo.Carrinho";
        //    SqlCommand cmd2 = new SqlCommand(select2, DBFunction.Connection);
        //    DBFunction.Connection.Open();
        //    SqlDataReader dr2 = cmd2.ExecuteReader();
        //    while (dr2.Read())
        //    {
        //        string[] vetor = { dr2[0].ToString(), dr2[1].ToString(), dr2[2].ToString() };
        //        dgCarrinho.Rows.Add(vetor);
        //    }
        //    dr2.Close();
        //    DBFunction.Connection.Close();
        //}

        private void Exec03_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (checkADD.Checked)
            {
                int produto = 0;
                string nome = "";
                int preco = 0;
                string select = $"SELECT idProduto,Nome,Preco from dbo.Mercado WHERE idProduto = {txtID.Text}";
                SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
                DBFunction.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    produto = Convert.ToInt32(dr[0]);
                    nome = Convert.ToString(dr[1]);
                    preco = Convert.ToInt32(dr[2]);                    
                }
                else
                {
                    MessageBox.Show("Nenhum produto corresponde ao ID inserido");
                }
                dr.Close();
                DBFunction.Connection.Close();

                AdicionaCarrinho(produto,nome, preco);
                AtualizarLista();
            }
            else if (checkRemove.Checked)
            {
                string delete = $"DELETE from dbo.Carrinho WHERE idProduto = {txtID.Text}";
                DBFunction.Executa(delete);
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma das opções");
            }
            txtID.Clear();
        }

        private void AdicionaCarrinho(int produto,string nome, int preco)
        {
            
            string insert = $"INSERT into dbo.Carrinho (idProduto,Nome,Preco) values ({produto},'{nome}',{preco})";
            DBFunction.Executa(insert);
        }

        private void checkADD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkADD.Checked)
            {
                checkRemove.Checked = false;
            }
        }

        private void checkRemove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRemove.Checked)
            {
                checkADD.Checked = false;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int valorTotal = 0;
            string select = "SELECT Preco from dbo.Carrinho";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                valorTotal += Convert.ToInt32(dr[0]);
            }
            dr.Close();
            DBFunction.Connection.Close();
            MessageBox.Show("Valor Total: " + valorTotal);

            string delete = "DELETE from dbo.Carrinho";
            DBFunction.Executa(delete);

            AtualizarLista();
        }
    }
}
