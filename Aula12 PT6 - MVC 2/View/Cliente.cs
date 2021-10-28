using MVC_2.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_2.View
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (rbAdd.Checked)
            {
                if (Controller1.ConfereAdiciona(txtNome.Text, txtCnpj.Text, txtCompraMensal.Text))
                {                    
                    AtualizaLista();
                    MessageBox.Show("Cliente inserido com sucesso");
                    txtNome.Clear();
                    txtCnpj.Clear();
                    txtCompraMensal.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            else if (rbRemover.Checked)
            {
                if(Controller1.ConfereRemove("Cliente", txtNome.Text))
                {
                    AtualizaLista();
                    MessageBox.Show("Cliente removido com sucesso");
                    txtNome.Clear();
                }



            }
            else
            {

            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            AtualizaLista();
            rbAdd.Checked = true;
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {

            txtCnpj.Visible = true;
            txtCompraMensal.Visible = true;
            lblCnpj.Visible = true;
            lblCompra.Visible = true;
            lblNomeAtualizar.Visible = false;
            txtNomeAtualizar.Visible = false;
        }

        private void rbRemover_CheckedChanged(object sender, EventArgs e)
        {
            txtCnpj.Visible = false;
            txtCompraMensal.Visible = false;
            lblCnpj.Visible = false;
            lblCompra.Visible = false;
            lblNomeAtualizar.Visible = false;
            txtNomeAtualizar.Visible = false;
        }

        private void rbAtualizar_CheckedChanged(object sender, EventArgs e)
        {
            txtCnpj.Visible = true;
            txtCompraMensal.Visible = true;
            lblCnpj.Visible = true;
            lblCompra.Visible = true;
            lblNomeAtualizar.Visible = true;
            txtNomeAtualizar.Visible = true;
        }
        private void AtualizaLista()
        {
            dgLista.Rows.Clear();
            List<string[]> list = Controller1.SelectAll("Cliente");
            foreach (var item in list)
            {
                dgLista.Rows.Add(item);
            }
        }

        private void Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
