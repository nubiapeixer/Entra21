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
    public partial class Exec03Add : Form
    {
        public Exec03Add()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new Exec03().Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Controller03.AdicionaCachorro(txtNome.Text, txtIdade.Text))
            {
                MessageBox.Show("Cachorro Inserido");
            }
            else
            {
                MessageBox.Show("Preencha todos os dados");
            }
        }
    }
}
