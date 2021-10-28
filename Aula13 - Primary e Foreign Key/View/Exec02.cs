using _18.AulaSQL.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.AulaSQL.View
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbPessoa.Checked)
            {
                if (Controller02.AdicionaPessoa(txtNome.Text, txtIdade.Text, txtCpf.Text, txtRua.Text, txtNumero.Text, txtCidade.Text, txtEstado.Text))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                txtNome.Clear();
                txtIdade.Clear();
                txtCpf.Clear();
                txtRua.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
            else if (cbEmpresa.Checked)
            {
                if (Controller02.AdicionaEmpresa(txtNome.Text, txtIdade.Text, txtRua.Text, txtNumero.Text, txtCidade.Text, txtEstado.Text))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                txtNome.Clear();
                txtIdade.Clear();
                txtRua.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtEstado.Clear();

            }
            else if (cbHabitacao.Checked)
            {
                if (Controller02.AdicionaHabitacao(txtNome.Text, txtCpf.Text, txtRua.Text, txtNumero.Text, txtCidade.Text, txtEstado.Text))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                txtNome.Clear();
                txtCpf.Clear();
                txtRua.Clear();
                txtNumero.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
            else
            {
                MessageBox.Show("Selecione uma opção: Pessoa/Empresa/Habitação");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (cbPessoa.Checked)
            {
                List<string[]> lista = Controller02.SelecionaPessoas();
                string mostraTexto = "";
                foreach (var item in lista)
                {
                    string elemento = "";
                    foreach (var item2 in item)
                    {
                        elemento += item2 + "  ";
                    }
                    mostraTexto += elemento + "\n";
                }
                MessageBox.Show(mostraTexto);

            }
            else if (cbEmpresa.Checked)
            {
                List<string[]> lista = Controller02.SelecionaEmpresas();
                string mostraTexto = "";
                foreach (var item in lista)
                {
                    string elemento = "";
                    foreach (var item2 in item)
                    {
                        elemento += item2 + "  ";
                    }
                    mostraTexto += elemento + "\n";
                }
                MessageBox.Show(mostraTexto);
            }
            else if (cbHabitacao.Checked)
            {
                List<string[]> lista = Controller02.SelecionaHabitacoes();
                string mostraTexto = "";
                foreach (var item in lista)
                {
                    string elemento = "";
                    foreach (var item2 in item)
                    {
                        elemento += item2 + "  ";
                    }
                    mostraTexto += elemento + "\n";
                }
                MessageBox.Show(mostraTexto);
            }
            else
            {
                MessageBox.Show("Selecione uma opção: Pessoa/Empresa/Habitação");
            }
        }

        private void cbPessoa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPessoa.Checked)
            {
                cbEmpresa.Checked = false;
                cbHabitacao.Checked = false;
                lblIdade.Visible = true;
                txtIdade.Visible = true;
                lblCpf.Visible = true;
                txtCpf.Visible = true;
                lblNome.Text = "Nome";
                lblIdade.Text = "Idade";
                lblCpf.Text = "CPF";

            }
        }

        private void cbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmpresa.Checked)
            {
                cbPessoa.Checked = false;
                cbHabitacao.Checked = false;
                lblIdade.Visible = true;
                txtIdade.Visible = true;
                lblCpf.Visible = false;
                txtCpf.Visible = false;
                lblNome.Text = "Nome";
                lblIdade.Text = "Qtd Funcionários";

            }
        }

        private void cbHabitacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHabitacao.Checked)
            {
                cbPessoa.Checked = false;
                cbEmpresa.Checked = false;
                lblNome.Text = "Nome Dono";
                lblIdade.Visible = false;
                txtIdade.Visible = false;
                lblCpf.Visible = true;
                lblCpf.Text = "Tipo Habitação";
                txtCpf.Visible = true;
            }
        }

        private void Exec02_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
