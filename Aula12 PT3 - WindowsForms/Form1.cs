using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.Windows_Form_parte_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec02_Click(object sender, EventArgs e)
        {
            new Exec02().Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExec03_Click(object sender, EventArgs e)
        {
            new Exec03().Show();
            this.Hide();
        }

        private void btnExec04_Click(object sender, EventArgs e)
        {
            new Exec04().Show();
            this.Hide();
        }

        private void btnExec01_Click(object sender, EventArgs e)
        {
            new Exec01().Show();
            this.Hide();
        }
    }
}
