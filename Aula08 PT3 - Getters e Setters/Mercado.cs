using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_OO_pt3
{
    class Mercado
    {
        private int guiche;
        private double qtdCaixa, entrada, saida;

        public Mercado(int guiche, double qtdCaixa, double entrada, double saida)
        {
            this.guiche = guiche;
            this.qtdCaixa = qtdCaixa;
            this.entrada = entrada;
            this.saida = saida;
        }
        public void SetGuiche(int guiche)
        {
            this.guiche = guiche;
        }
        public int GetGuiche()
        {
            return guiche;
        }
        public void SetQtdCaixa(double qtdCaixa)
        {
            this.qtdCaixa = qtdCaixa;
        }
        public double GetQtdCaixa()
        {
            return qtdCaixa;
        }
        public void SetEntrada(double entrada)
        {
            this.entrada = entrada;
        }
        public double GetEntrada()
        {
            return entrada;
        }
        public void SetSaida(double saida)
        {
            this.saida = saida;
        }
        public double GetSaida()
        {
            return saida;
        }
    }
}
