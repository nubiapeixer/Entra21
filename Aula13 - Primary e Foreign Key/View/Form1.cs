using _18.AulaSQL.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.AulaSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (rbExec01.Checked)
            {
                new Exec01().Show();
                this.Hide();
            }
            else if (rbExec02.Checked)
            {
                new Exec02().Show();
                this.Hide();
            }
            else if(rb3.Checked)
            {
                new Exec03().Show();
                this.Hide();
            }
        }
    }
}
