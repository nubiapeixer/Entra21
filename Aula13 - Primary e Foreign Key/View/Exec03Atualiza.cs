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
    public partial class Exec03Atualiza : Form
    {
        public Exec03Atualiza()
        {
            InitializeComponent();
        }

        private void Exec03Atualiza_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            dgCachorros.Rows.Clear();
            
            List<string[]> list = Controller03.SelecionaTodos("Cachorro");
            foreach (var item in list)
            {
                dgCachorros.Rows.Add(item);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComer_Click(object sender, EventArgs e)
        {
            if (Controller03.AtualizaCachorroDopamina(txtNome.Text, txtQtd.Text))
            {
                AtualizarLista();
                MessageBox.Show("Informações Atualizadas");

                txtNome.Clear();
                txtQtd.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todas as informações");
            }
        }

        private void btnDescansar_Click(object sender, EventArgs e)
        {
            if (Controller03.AtualizaCachorroConforto(txtNome.Text, txtQtd.Text))
            {
                AtualizarLista();
                MessageBox.Show("Informações Atualizadas");

                txtNome.Clear();
                txtQtd.Clear();
            }
            else
            {
                MessageBox.Show("Preencha todas as informações");
            }
        }
    }
}
