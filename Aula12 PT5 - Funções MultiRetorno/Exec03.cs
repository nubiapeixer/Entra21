using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Funções_MultiRetorno
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

        private void Exec03_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void UpdateDG()
        {
            dgHistorico.Rows.Clear();
            List<string[]> list = DBFunction.GenericSelectAll("Historico2");

            // var aceita qualquer variável já declarada
            foreach (var item in list)
            {
                dgHistorico.Rows.Add(item);
            }

            // muda cor dos valores que estão negativos
            for (int i = 0; i < dgHistorico.Rows.Count; i++)
            {
                // converte para double e confere se o valor da linha na posição [i] na coluna "ValorLiquidoCol" é menor que zero
                if (Convert.ToDouble(dgHistorico.Rows[i].Cells["ValorLiquidoCol"].Value.ToString()) < 0)
                {
                    dgHistorico.Rows[i].Cells["ValorLiquidoCol"].Style.ForeColor = Color.Red;
                }
            }
            
        }

        private void Exec03_Load(object sender, EventArgs e)
        {
            UpdateDG();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorLiquido = 0, novoSaldo = 0, despesas = 0, ganhos = 0;
            bool lucrou = false; // pode começar com false ou true

            // pega o último elemento da coluna ValorEmCaixa
            double saldoAtual = Convert.ToDouble(dgHistorico.Rows[dgHistorico.Rows.Count - 1].Cells[1].Value);

            ganhos = Convert.ToDouble(txtGanhos.Text);
            despesas = Convert.ToDouble(txtDespesas.Text);

            CalculateMonth(saldoAtual, ganhos, despesas, out valorLiquido, out novoSaldo, out lucrou);

            // CultureInfo.InvariantCulture reconhece vírgula nas variantes double, e converter pra ponto 
            string insert = $"INSERT into dbo.Historico2 (ValorEmCaixa,DespesasDoMes,GanhosDoMes,ValorLiquido,SeLucrou) values ({novoSaldo.ToString(CultureInfo.InvariantCulture)},{despesas.ToString(CultureInfo.InvariantCulture)},{ganhos.ToString(CultureInfo.InvariantCulture)},{valorLiquido.ToString(CultureInfo.InvariantCulture)},{Convert.ToInt32(lucrou)})";
            // lucrou convert pra toint porque ele resulta em 0 (false) e 1 (true)

            DBFunction.GenericExecute(insert);
            UpdateDG();

        }

        /// <summary>
        /// Função MultiRetorno
        /// </summary>
        /// <param name="saldoAtual"></param>
        /// <param name="ganhos"></param>
        /// <param name="despesas"></param>
        /// <param name="valorLiquido"></param>
        /// <param name="novoSaldo"></param>
        /// <param name="lucrou"></param>
        private void CalculateMonth(double saldoAtual, double ganhos, double despesas, out double valorLiquido, out double novoSaldo, out bool lucrou)
        {
            valorLiquido = ganhos - despesas;
            novoSaldo = saldoAtual + valorLiquido;
            if(valorLiquido > 0)
            {
                lucrou = true;
            }
            else
            {
                lucrou = false;
            }
        }
    }
}
