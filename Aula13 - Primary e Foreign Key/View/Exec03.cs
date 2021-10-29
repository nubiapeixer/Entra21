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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Exec03Add().Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Exec03Atualiza().Show();
            this.Hide();
        }
    }
}
