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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec02_Click(object sender, EventArgs e)
        {
            Exec02 f = new Exec02();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnExec01_Click(object sender, EventArgs e)
        {
            Exec01 f = new Exec01();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnExec04_Click(object sender, EventArgs e)
        {
            Nome f = new Nome();
            this.FindForm().Hide();
            f.Show();
        }

        private void btnExec05_Click(object sender, EventArgs e)
        {
            Exec05 f = new Exec05();
            this.FindForm().Hide();
            f.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnCorrigido1_Click(object sender, EventArgs e)
        {
            new Corrigido1().Show();
            this.Hide();
        }
    }
}
