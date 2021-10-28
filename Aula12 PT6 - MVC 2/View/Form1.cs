using MVC_2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFuncionario.Checked = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cbFuncionario.Checked)
            {
                
            }
            else if (cbCliente.Checked)
            {
                new Cliente().Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void cbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFuncionario.Checked)
            {
                cbCliente.Checked = false;
                cbFinanceiro.Checked = false;
            }
        }

        private void cbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCliente.Checked)
            {
                cbFuncionario.Checked = false;
                cbFinanceiro.Checked = false;
            }
        }

        private void cbFinanceiro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinanceiro.Checked)
            {
                cbFuncionario.Checked = false;
                cbCliente.Checked = false;
            }
        }
    }
}
