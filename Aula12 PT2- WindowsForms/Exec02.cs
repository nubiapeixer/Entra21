using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms___Exec02
{
    public partial class Exec02 : Form
    {
        public Exec02()
        {
            InitializeComponent();
        }

        

        private void Exec02_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            Saque f = new Saque();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Deposito f = new Deposito();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            Contas f = new Contas();
            this.FindForm().Hide();
            f.Show();
        }
    }
}
