using System;

namespace Desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Desafio 01
            // degrau: 30cm comprimento, 18 cm altura, 50 cm de largura             
            //Console.WriteLine("Informe a altura da escada em centímetros:");
            //double altura = Convert.ToDouble(Console.ReadLine());
            //int qtdDegraus = 0;
            //double volume = 0;
            //bool meioDegrau = false;

            //while (true)
            //{
            //    if (altura > 0 && altura < 18)
            //    {
            //        meioDegrau = true;
            //        volume += altura * 30 * 50;
            //        qtdDegraus++;
            //    }
            //    else if (altura >= 18)
            //    {
            //        qtdDegraus++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //    altura -= 18;
            //}
            //Console.WriteLine("Quantidade de degraus:");
            //Console.WriteLine(qtdDegraus);
            //Console.WriteLine("Comprimento da escada:");
            //Console.WriteLine(qtdDegraus * 30);
            //Console.WriteLine("-------------//--------------");

            //for (int i = qtdDegraus; i > 0 ; i--)
            //{
            //    if (meioDegrau)
            //    {
            //        volume += (i-1) * (18 * 30 * 50);
            //        meioDegrau = false;
            //    }
            //    else
            //    {
            //        volume += i * (18 * 30 * 50);
            //    }

            //}
            //Console.WriteLine("Volume");
            //Console.WriteLine(volume * 1.3246);

            // Outra forma de resolver (Gustavo)
            double degrau, comprimento, altura, auxcomp = 0;
            while (true)
            {
                Console.WriteLine("Insira a altura da escada em centímetros");
                altura = Convert.ToDouble(Console.ReadLine());
                if(altura % 18 == 0)
                {
                    degrau = altura / 18;
                    comprimento = degrau * 30;
                    Console.WriteLine("Número de degraus: " + degrau);
                    Console.WriteLine("E o comprimento da escada será " + comprimento);
                }
                else
                {
                    degrau = altura / 18;
                    Console.WriteLine(degrau); // controle de variáveis
                    auxcomp = degrau; // captura a quantidade de degrais antes de arredondar

                    degrau = Math.Ceiling(degrau);
                    comprimento = degrau * 30;
                    Console.WriteLine("Número de degraus: " + degrau);
                    Console.WriteLine("E o comprimento da escada será " + comprimento);

                    auxcomp -= degrau;
                    auxcomp = Math.Abs(auxcomp); // faz com que a variável seja positiva
                    auxcomp *= 30; // calcula a "porcentagem" de degrau a ser retirado
                    Console.WriteLine(auxcomp); // controle
                }
                double volumeDegrau = 18 * 30 * 50; // degrau inteiro
                double volumeDegrauAux = 18 * auxcomp * 50; // degrau parcial
                double degraus = 0;
                double volumeEscada = 0;
                for (int i = 1; i <= degrau; i++)
                {
                    degraus += i; // aumenta 18 cm a cada degrau
                }
                volumeEscada = volumeEscada + volumeDegrau * degraus; // calcula o volume total
                volumeEscada = volumeEscada - volumeDegrauAux; // remove a parte quebrada do total
                volumeEscada = volumeEscada * 1.3246; // escala
                Console.WriteLine(volumeEscada);
            }



        }
    }
}
