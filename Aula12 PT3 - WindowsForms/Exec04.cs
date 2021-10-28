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
    public partial class Exec04 : Form
    {
        public Exec04()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string insert = $"INSERT into dbo.Historico (Custos,Ganhos,Lucro,MesAno) values ({txtCusto.Text},{txtGanho.Text},{txtLucro.Text},'{txtMesAno.Text}')";
            DBFunction.Executa(insert);

            AtualizaDG();

            txtCusto.Clear();
            txtGanho.Clear();
            txtLucro.Clear();
            txtMesAno.Clear();
        }

        private void AtualizaDG()
        {
            dgHistorico.Rows.Clear();
            string select = "SELECT * from dbo.Historico";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = {dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString() };
                dgHistorico.Rows.Add(vetor);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }

        private void Exec04_Load(object sender, EventArgs e)
        {
            AtualizaDG();
        }

        private void Exec04_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
