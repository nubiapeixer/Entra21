using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Exec01 : Form
    {
        public Exec01()
        {
            InitializeComponent();
        }

        private void Exec01_Load(object sender, EventArgs e)
        {
            cbNome.Items.Clear();
            List<string> lista = DBFunction.GenericUnitSelect("Nome","Pessoa");
            foreach (var item in lista)
            {
                cbNome.Items.Add(item);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgNomes.Rows.Clear();

            string select = $"SELECT * from dbo.Pessoa WHERE Nome = '{cbNome.Text}'";
            SqlCommand cmd = new SqlCommand(select, DBFunction.Connection);
            DBFunction.Connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //string[] vetor = { dr[0].ToString(), dr[1].ToString(), $@"{Convert.ToInt64(dr[2].ToString()):000\.000\.000\-00}", dr[3].ToString() };

                string[] array = { dr[0].ToString(),dr[1].ToString(),FormatCPF(dr[2].ToString()),dr[3].ToString()};
                dgNomes.Rows.Add(array);
            }
            dr.Close();
            DBFunction.Connection.Close();
        }
        private string FormatCPF(string cpf)
        {
            return $@"{Convert.ToInt64(cpf):000\.000\.000\-00}";
        }

        private void Exec01_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
