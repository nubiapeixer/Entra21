using System;

namespace Tratamento_de_Exceções
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tratamento de Exceções
            // LISTA 01

            // EXEC 02            
            //int a = 0;
            //while (true)
            //{
            //    Console.WriteLine("Insira um número");
            //    // testa possível exceção
            //    try
            //    {
            //        a = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Deu Certo!!!");
            //        break;
            //    }
            //    // testa para números grandes
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número gigantesco");
            //    }
            //    // testa para qualquer coisa diferente de número
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");
            //    }
            //    // qualquer exceção
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");
            //    }                
            //}

            // EXEC 03
            //double numero;

            //while (true)
            //{
            //    Console.WriteLine("Insira 3 números entre 0 e 10 para saber a média");
            //    double media = 0;
            //    try
            //    {
            //        for (int i = 0; i < 3; i++)
            //        {
            //            while (true)
            //            {
            //                Console.WriteLine("Insira o " + (i + 1) + "° número");
            //                numero = Convert.ToDouble(Console.ReadLine());
            //                if (numero >= 0 && numero <= 10)
            //                {
            //                    media += numero;
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Insira apenas números entre 0 e 10");
            //                }
            //            }
            //        }
            //        Console.WriteLine("A média dos números inseridos é igual a " + (media / 3));

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");                    
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número gigantesco");                    
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");                    
            //    }
            //}
            // EXEC 04
            //int[] vetor = new int[5];

            //while (true)
            //{
            //    try
            //    {
            //        for (int i = 0; i < vetor.Length; i++)
            //        {
            //            vetor[i] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        break;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("O número é muito grande");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Digite apenas números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");
            //    }
            //}
            //Array.Sort(vetor);
            //Console.WriteLine("O maior número inserido foi " + vetor[4]);
            //Console.WriteLine("O menor número inserido foi " + vetor[0]);


            // Usando outras listas            
            //LISTA AULA 07
            // EXEC 02

            //List<double> notas = new List<double>();
            //double media = 0;
            //Console.WriteLine("Insira as 3 notas do aluno");

            //while (true)
            //{
            //    media = 0;
            //    try
            //    {
            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.WriteLine("Insira a " + (i + 1) + "° nota");
            //            double nota = Convert.ToDouble(Console.ReadLine());
            //            media += nota;
            //            notas.Add(nota);
            //        }
            //        break;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número muito grande");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Insira apenas números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");
            //    }
            //}
            //Console.WriteLine("Média das notas --> " + (media / 3));

            // GUARDANDO AS NOTAS
            //List<double> notas = new List<double>();
            //double media = 0, nota = 0;
            //Console.WriteLine("Insira as 3 notas do aluno");

            //while (true)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        while (true)
            //        {
            //            try
            //            {
            //                Console.WriteLine("Insira a " + (i + 1) + "ª nota");
            //                nota = Convert.ToDouble(Console.ReadLine());
            //                notas.Add(nota);
            //                break;
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Apenas números");
            //            }
            //            catch (OverflowException)
            //            {
            //                Console.WriteLine("Número muito grande");
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("*ERRO*");
            //            }
            //        }
            //    }
            //    break;
            //}
            //foreach (var item in notas)
            //{
            //    media += item;
            //}
            //Console.WriteLine("Média do aluno --> " + (media / 3));

            // exec 03
            //List<int> numeros = new List<int>();
            //Console.WriteLine("Insira 3 números");
            //int maior = 0;

            //while (true)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        while (true)
            //        {
            //            try
            //            {
            //                Console.WriteLine("Insira o " + (i + 1) + "° número");
            //                int numero = Convert.ToInt32(Console.ReadLine());
            //                numeros.Add(numero);                            
            //                foreach (var item in numeros)
            //                {
            //                    if (item > maior)
            //                    {
            //                        maior = item;
            //                    }
            //                }
            //                break;
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Apenas números");
            //            }
            //            catch (OverflowException)
            //            {
            //                Console.WriteLine("O número é muito grande");
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("*ERRO*");
            //            }
            //        }

            //    }
            //    break;
            //}
            //Console.WriteLine("O maior número inserido é " + maior);

            // exec 04
            //List<double> numeros = new List<double>();

            //Console.WriteLine("Insira números ou 0 para sair");


            //while (true)
            //{
            //    try
            //    {
            //        double numero = Convert.ToDouble(Console.ReadLine());

            //        if (numero == 0)
            //        {
            //            break;
            //        }
            //        numeros.Add(numero);
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número muito grande");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");
            //    }

            //}
            //double resultado = 1;
            //foreach (var item in numeros)
            //{
            //    resultado *= item;
            //}
            //Console.WriteLine(resultado);

            // exec 05
            //List<int> numeros = new List<int>();

            //Console.WriteLine("Insira números ou sair");

            //while (true)
            //{
            //    try
            //    {
            //        string entrada = Console.ReadLine();
            //        if (entrada == "sair")
            //        {
            //            break;
            //        }
            //        int numero = Convert.ToInt32(entrada);
            //        numeros.Add(numero);

            //        for (int i = 1; i < numeros.Count; i++)
            //        {
            //            if (numeros[i] < numeros[i - 1])
            //            {
            //                do
            //                {
            //                    Console.WriteLine("O número é muito pequeno, insira outro");
            //                    numeros[i] = Convert.ToInt32(Console.ReadLine());

            //                } while (numeros[i] < numeros[i - 1]);
            //            }

            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas números");
            //    }


            //}
            //foreach (var item in numeros)
            //{
            //    Console.WriteLine(item);
            //}

            // Variáveis avançadas, list, static
            // LISTA 02

            //exec 01
            //List<string> nomes = new List<string>();

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Insira o nome do aluno ou sair");
            //        string opcao = Console.ReadLine();
            //        if (opcao == "sair")
            //        {
            //            break;
            //        }
            //        nomes.Add(opcao);
            //    }                
            //    catch (Exception)
            //    {
            //        Console.WriteLine("*ERRO*");
            //    }
            //}
            //foreach (var item in nomes)
            //{
            //    Console.WriteLine(item);
            //}





        }
    }
}
