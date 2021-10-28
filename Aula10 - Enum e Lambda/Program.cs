using System;

namespace _10._Enum_e_Lambda
{
    class Program
    {
        // Exec 01) lista 1
        enum Nomes
        {
            Carla,
            Joaquina,
            Astolfo,
            Tesla,
            JoanaDark
        }
        // Exec 03) lista 1
        enum Potencia
        {
            dois = 2,
            tres,
            quatro,
            cinco,
            seis,
            sete,
            oito,
            nove,
            dez
        }
        // Exec 04) lista 1
        enum Cargos
        {
            Auxiliar,
            Secretaria,
            Mestre,
            Engenheiro
        }
        static void Main(string[] args)
        {
            //// LISTA 01 -----------------------------------------------------------------------
            //// Exec 01
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0} : {1}", i + 1, (Nomes)i);
            //}
            //Console.WriteLine("Qual nome deseja?");
            //int escolha = Convert.ToInt32(Console.ReadLine());
            //escolha--;
            //Console.WriteLine("Nome escolhido {0}", (Nomes)escolha);

            ////Coloca em uma variável, convertendo para string:
            //string j = ((Nomes)escolha).ToString();

            //try
            //{
            //    // Mostrar o índice
            //    int k = Convert.ToInt32((Nomes.Carla));
            //    Console.WriteLine(k);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Deu ruim");
            //}
            

            //// Exec 02
            //Func<int, int> eleva = x =>
            // {
            //     if (x <= 10)
            //     {
            //         return x * x;
            //     }
            //     else
            //     {
            //         return x;
            //     }
            // };

            //Console.WriteLine("Insira um número");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(eleva(numero));

            //// Exec 03       
            //Console.WriteLine("Insira um número");
            //int numero = CRI();
            //for (int i = 2; i < 11; i++)
            //{
            //    double k = Convert.ToDouble((Potencia)i);
            //    Console.Write("O número " + numero + " elevado a potência de " + k);
            //    Console.WriteLine(": " + Math.Pow(numero, k));
            //}

            //// Exec 04
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("{0}: {1}", i + 1, (Cargos)i);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Insira o índice do cargo");
            //int escolha = CRI();
            //escolha--;
            //double salario = 0;

            //switch (escolha)
            //{
            //    case 0:
            //        salario = 1000;
            //        break;
            //    case 1:
            //        salario = 2500;
            //        break;
            //    case 2:
            //        salario = 3000;
            //        break;
            //    case 3:
            //        salario = 4000;
            //        break;
            //    default:
            //        break;
            //}

            //Console.WriteLine("Cargo escolhido: {0}", (Cargos)escolha);
            //Console.WriteLine("Salário: {0:c}", salario);

            // LISTA 2 ---------------------------------------------------------------------
            // Exec 01           


            //int saque, quociente, resto, nota;

            //saque = int.Parse(Console.ReadLine());

            //resto = saque;

            //nota = 100;
            //quociente = resto / nota;
            //Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            //resto = resto % nota;

            //nota = 50;
            //quociente = resto / nota;
            //Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            //resto = resto % nota;

            //nota = 20;
            //quociente = resto / nota;
            //Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            //resto = resto % nota;

            //nota = 10;
            //quociente = resto / nota;
            //Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            //resto = resto % nota;

            //nota = 5;
            //quociente = resto / nota;
            //Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            //resto = resto % nota;

            //nota = 2;
            //quociente = resto / nota;
            //Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");





        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public static double CRD()
        {
            return Convert.ToDouble(CR());
        }
    }
}
