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
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void checkPessoa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPessoa.Checked)
            {
                checkFuncionario.Checked = false;
                checkCliente.Checked = false;
                lblSalario.Visible = false;
                txtSalario.Visible = false;
                cbVip.Visible = false;
            }
            
        }

        private void checkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCliente.Checked)
            {
                checkFuncionario.Checked = false;
                checkPessoa.Checked = false;
                lblSalario.Visible = false;
                txtSalario.Visible = false;
                cbVip.Visible = true;
            }
            
        }

        private void checkFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFuncionario.Checked)
            {
                checkPessoa.Checked = false;
                checkCliente.Checked = false;
                lblSalario.Visible = true;
                txtSalario.Visible = true;
                cbVip.Visible = false;
            }
            
        }

        private void Exec01_Load(object sender, EventArgs e)
        {
            checkPessoa.Checked = true;
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (checkPessoa.Checked)
            {
                if (Controller01.AdicionaPessoa(txtNome.Text, txtCpf.Text, txtRg.Text))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                txtNome.Clear();
                txtCpf.Clear();
                txtRg.Clear();


            }
            else if (checkCliente.Checked)
            {
                if (Controller01.AdicionaCliente(txtNome.Text, txtCpf.Text, txtRg.Text, cbVip.Checked))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                txtNome.Clear();
                txtCpf.Clear();
                txtRg.Clear();
                cbVip.Checked = false;

            }
            else
            {
                if (Controller01.AdicionaFuncionario(txtNome.Text, txtCpf.Text, txtRg.Text, txtSalario.Text))
                {
                    MessageBox.Show("Elemento inserido");
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                txtNome.Clear();
                txtCpf.Clear();
                txtRg.Clear();
                txtSalario.Clear();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (checkPessoa.Checked)
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
            else if (checkCliente.Checked)
            {
                List<string[]> lista = Controller01.SelecionaClientes();
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
                List<string[]> lista = Controller01.SelecionaFuncionarios();
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
        }
    }
}
