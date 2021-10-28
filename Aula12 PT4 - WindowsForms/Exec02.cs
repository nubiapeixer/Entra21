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

namespace teste
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
        private void Exec02_Load(object sender, EventArgs e)
        {
            AtualizaDG();
            AtualizaCB(true);
            rbEntrando.Checked = true;
        }

        private void rbEntrando_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEntrando.Checked)
            {
                lblVagas.Text = "Vagas Disponíveis";
                lblPlaca.Visible = true;
                txtPlaca.Visible = true;
                AtualizaCB(true);
            }
        }
        private void rbSaindo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSaindo.Checked)
            {
                lblVagas.Text = "Placas Veículos Estacionados";
                lblPlaca.Visible = false;
                txtPlaca.Visible = false;
                AtualizaCB(false);
            }
        }

        private void AtualizaDG()
        {
            dgVagas.Rows.Clear();
            string select = $"SELECT * from dbo.Vaga";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] array = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                dgVagas.Rows.Add(array);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }
        private void AtualizaCB(bool update)
        {
            cbVaga.Items.Clear();
            cbVaga.Text = null;
            if (update) // mostra as vagas livres
            {
                // sem a função generic:
                //string select = "SELECT NumeroDaVaga from dbo.Vaga WHERE EstaPreenchida = 0";
                //SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
                //DBFunction.Connection.Open();
                //SqlDataReader dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    cbVagasLivres.Items.Add(dr[0].ToString());
                //}
                //dr.Close();
                //DBFunction.Connection.Close();

                foreach (var item in DBFunction.GenericUnitSelect("NumeroDaVaga", "Vaga", "EstaPreenchida = 0"))
                {
                    cbVaga.Items.Add(item);
                }
            }
            else // mostra as placas
            {
                List<string> lista = DBFunction.GenericUnitSelect("PlacaDoVeiculo", "Vaga", "EstaPreenchida = 1");
                lista.Sort();
                foreach (var item in lista)
                {
                    cbVaga.Items.Add(item);
                }
            }
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            if (rbEntrando.Checked)
            {
                string update = $"UPDATE dbo.Vaga Set PlacaDoVeiculo = '{txtPlaca.Text}', EstaPreenchida = 1 WHERE NumeroDaVaga = '{cbVaga.Text}'";
                DBFunction.Executa(update);                
                AtualizaCB(true);
                txtPlaca.Clear();
            }
            else // como foi colocado no load pra iniciar com o entrando selecionado, pode - se colocar else aqui pois é de certeza que algum estará selecionado
            {
                string update = $"UPDATE dbo.Vaga Set PlacaDoVeiculo = null, EstaPreenchida = 0 WHERE PlacaDoVeiculo = '{cbVaga.Text}'";
                DBFunction.Executa(update);
                AtualizaCB(false);                
            }
            AtualizaDG();
            cbVaga.Text = null;
        }
    }
}
