using System;
using System.Collections.Generic;

namespace Depuração
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEPURAÇÃO

            // exec 01
            //Console.WriteLine("Insira um número");
            //int x = CRI();
            //x = Exec01(x);
            //Console.WriteLine(x);

            // exec 02
            //Exec02();

            // exec 03
            //Console.WriteLine("Insira dois números");
            //int numero1 = CRI();
            //int numero2 = CRI();
            //bool resultado = Exec03(numero1, numero2);
            //Console.WriteLine(resultado);

            // exec 04
            //Console.WriteLine("Insira dois números");
            //int numero1 = CRI();
            //int numero2 = CRI();
            //Exec04(numero1, numero2);

            // exec 05
            //List<double> numeros = new List<double>();

            //Console.WriteLine("Insira números para a lista");
            //for (int i = 0; i < 3; i++)
            //{
            //    double numero = CRD();
            //    numeros.Add(numero);
            //}
            //double resultado = Exec05(numeros);
            //Console.WriteLine(resultado);

            // exec 06
            //Console.WriteLine("Insira um número");
            //int numero = CRI();
            //numero = Exec06(numero);
            //Console.WriteLine(numero);



        }

        public static string CR()
        {
            return Console.ReadLine();
        }
        public static double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        // exec 01
        public static int Exec01(int numero)
        {
            if (numero > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        // exec 02
        public static void Exec02()
        {
            while (true)
            {
                Console.WriteLine("Insira um numero ou sair");
                string entrada = Console.ReadLine();
                if (entrada == "sair")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(entrada);
                }
            }
        }
        // exec 03
        public static bool Exec03(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // exec 04
        public static void Exec04(int numero1, int numero2)
        {
            if (numero2 < numero1)
            {
                Console.WriteLine(numero1 + numero2);
            }
            else
            {
                Console.WriteLine("Não computável");
            }
        }

        // exec 05
        public static double Exec05(List<double> lista)
        {
            double maior = 0;
            foreach (var item in lista)
            {
                if (item > maior)
                {
                    maior = item;
                }
            }
            return maior;
        }

        // exec 06
        public static int Exec06(int numero)
        {
            if (numero >= 0 && numero <= 10)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

