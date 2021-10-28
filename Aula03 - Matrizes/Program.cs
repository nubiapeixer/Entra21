using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Núbia
            // MATRIZ

            // EXEC 01 CORRIGIDO
            //int[][] matriz = new int[4][]; // gera uma matriz com 4 linhas

            //for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            //{
            //    matriz[i] = new int[4]; // gera as colunas
            //}

            //for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            //{
            //    for (int j = 0; j < matriz[i].Length; j++) // percorre todas as colunas da linha i
            //    {
            //        Console.WriteLine("Insira o elemento -> " + i + " " + j);
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //int contador = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (matriz[i][j] > 10)
            //            contador++;
            //        Console.Write(matriz[i][j] + "  ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine(contador);

            // EXEC 02 CORRIGIDO
            //int x = 5, y = 5;
            //int[,] diagonal = new int[x,y];
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        if(i == j)
            //        {
            //            diagonal[i, j] = 1;
            //        }
            //        else
            //        {
            //            diagonal[i, j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //        Console.Write(diagonal[i, j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            // EXEC 03 CORRIGIDO
            //int[][] matriz = new int[4][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = i * j;
            //        Console.Write(matriz[i][j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //EXTRA_ copiando matriz (exec 09 - exemplo)
            //int[][] matrizCopia = matriz;
            // .....................
            //int[][] matrizCopia = new int[1][];
            //matrizCopia = matriz;

            // EXEC 04
            //int[][] matriz = new int[5][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[5];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira o elemento -> " + i + "  " + j);
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }                
            //}
            //Console.WriteLine("Insira o número que deseja buscar na matriz");
            //int x = Convert.ToInt32(Console.ReadLine());

            //bool naoEncontrado = true;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if(matriz[i][j] == x)
            //        {
            //            Console.WriteLine("Localização: " + i + "  " + j);
            //            naoEncontrado = false;
            //        }                    
            //    }
            //}
            //if (naoEncontrado)
            //{
            //    Console.WriteLine("Não encontrado");
            //}

            //// EXEC 05
            //int[][] matriz1 = new int[4][];
            //int[][] matriz2 = new int[4][];
            //int[][] maior = new int[4][];
            //for (int i = 0; i < matriz1.Length; i++)
            //{
            //    matriz1[i] = new int[4];
            //}
            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    matriz2[i] = new int[4];
            //}
            //for (int i = 0; i < maior.Length; i++)
            //{
            //    maior[i] = new int[4];
            //}

            //for (int i = 0; i < matriz1.Length; i++)
            //{
            //    for (int j = 0; j < matriz1[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira os elementos da primeira matriz --> " + i + "  " + j);
            //        matriz1[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz2.Length; i++)
            //{
            //    for (int j = 0; j < matriz2[i].Length; j++)
            //    {
            //        Console.WriteLine("Insira os elementos da segunda matriz --> " + i + "  " + j);
            //        matriz2[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < maior.Length; i++)
            //{
            //    for (int j = 0; j < maior[i].Length; j++)
            //    {
            //        if(matriz1[i][j] >= matriz2[i][j])
            //        {
            //            maior[i][j] = matriz1[i][j];
            //        }
            //        else
            //        {
            //            maior[i][j] = matriz2[i][j];
            //        }
            //        Console.Write(maior[i][j] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            // EXEC 05 CORRIGIDO
            //Random ran = new Random();

            //int[][] matriz01 = new int[4][];
            //int[][] matriz02 = new int[4][];
            //int[][] resultado = new int[4][];

            //for (int i = 0; i < matriz01.Length; i++)
            //{
            //    matriz01[i] = new int[4];
            //    matriz02[i] = new int[4];
            //    resultado[i] = new int[4];
            //}

            //for (int i = 0; i < matriz01.Length; i++)
            //{
            //    for (int j = 0; j < matriz01[i].Length; j++)
            //    {
            //        matriz01[i][j] = ran.Next(0, 10);
            //        Console.Write(matriz01[i][j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------------//--------------------");
            //for (int i = 0; i < matriz02.Length; i++)
            //{
            //    for (int j = 0; j < matriz02[i].Length; j++)
            //    {
            //        matriz02[i][j] = ran.Next(0, 10);
            //        Console.Write(matriz02[i][j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------------//--------------------");

            //for (int i = 0; i < resultado.Length; i++)
            //{
            //    for (int j = 0; j < resultado[i].Length; j++)
            //    {
            //        if (matriz01[i][j] > matriz02[i][j])
            //        {
            //            resultado[i][j] = matriz01[i][j];
            //        }
            //        else
            //        {
            //            resultado[i][j] = matriz02[i][j];
            //        }
            //        Console.Write(resultado[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // EXEC 06
            //int[][] matriz = new int[10][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[10];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (i == j)
            //        {
            //            matriz[i][j] = 3 * i - 1;
            //        }
            //        else if (i < j)
            //        {
            //            matriz[i][j] = 2 * i + 7 * j - 2;
            //        }
            //        else
            //        {
            //            matriz[i][j] = 4 * i - 5 * j + 1;
            //        }
            //        Console.Write(matriz[i][j] + "  ");
            //    }
            //    Console.WriteLine();
            //}
            // EXEC 07
            //int[][] matriz = new int[3][];
            //int soma = 0;

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (i < j)
            //        {
            //            matriz[i][j] = i + j;
            //            soma = soma + matriz[i][j];
            //        }
            //    }
            //}
            //Console.WriteLine(soma);

            // EXEC 08
            //int[][] matriz = new int[3][];
            //int soma = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if(i > j)
            //        {
            //            matriz[i][j] = i + j;
            //            soma = soma + matriz[i][j];
            //        }

            //    }
            //}
            //Console.WriteLine(soma);

            // (CORRIGIDO) 09
            //Random ran = new Random();
            //int[][] matriz = new int[4][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //// preenche matriz de 1 a 20
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = ran.Next(1, 21);
            //    }
            //}
            //// mostra a matriz original na tela
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (matriz[i][j] < 10) // pra deixar os números alinhados
            //        {
            //            Console.Write("0" + matriz[i][j] + " ");
            //        }
            //        else
            //        {
            //            Console.Write(matriz[i][j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //// transforma a matriz
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (i < j)
            //        {
            //            matriz[i][j] = 0;
            //        }
            //    }
            //}
            //Console.WriteLine("--------------//-----------------");
            //// mostra a matriz transformada na tela
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (matriz[i][j] < 10) // pra deixar os números alinhados
            //        {
            //            Console.Write("0" + matriz[i][j] + " ");
            //        }
            //        else
            //        {
            //            Console.Write(matriz[i][j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // EXEC 10
            //Random ran = new Random();
            //int[][] matriz = new int[5][]; // int[,] matriz = new int[5,5];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[5];
            //}
            //for (int i = 0; i < matriz.Length; i++) // for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++) // for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i][j] = ran.Next(0, 100); // matriz[i,j] = ran.Next(0,100);
            //        // faz a busca por elementos repetidos
            //        for (int k = 0; k < matriz.Length; k++)
            //        {
            //            for (int l = 0; l < matriz[k].Length; l++)
            //            {
            //                if (matriz[i][j] == matriz[k][l] && (i != k || j != l)) // pra não parar toda vez que tem 1 elemento do número igual, ex.: 01 10 ou 22 12
            //                {
            //                    k = matriz.Length;
            //                    j--;
            //                    break; // para 1 laço só, o último for
            //                }
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (matriz[i][j] < 10) // pra deixar os números alinhados
            //        {
            //            Console.Write("0" + matriz[i][j] + " ");
            //        }
            //        else
            //        {
            //            Console.Write(matriz[i][j] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // PARTE 02

            // EXEC 01 (CORRIGIDO)
            //int[][] matriz = new int[3][];
            //int[] soma = new int[3];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //    soma[i] = 0;
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < matriz.Length; i++) // vai ser a coluna
            //{
            //    for (int j = 0; j < matriz[i].Length; j++) // vai ser a linha
            //    {
            //        // NOTA: o índice da matriz está "invertido"
            //        soma[i] += matriz[j][i];
            //    }                
            //}
            //// mostra o resultado do vetor
            //for (int i = 0; i < soma.Length; i++)
            //{
            //    Console.WriteLine(soma[i]);
            //}

            // EXEC 02 (CORRIGIDO)
            //int[][] matriz = new int[5][];
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}
            //// a)
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length - 1; j++) // para não percorrer a última coluna
            //    {
            //        if (j == 0)
            //        {
            //            Console.WriteLine("Qual a matricula do aluno " + (i + 1) + "° aluno");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else if (j == 1)
            //        {
            //            Console.WriteLine("Qual a média das provas do aluno  " + (i + 1) + "° aluno");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else
            //        {
            //            Console.WriteLine("Qual a média dos trabalhos do aluno  " + (i + 1) + "° aluno");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    // b)
            //    matriz[i][matriz[i].Length - 1] = matriz[i][1] + matriz[i][2];
            //}
            //Console.WriteLine("--------------------//--------------------");
            //// c)
            //int notaFinal = -1, valorNotaFinal = -1;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    if (matriz[i][3] > valorNotaFinal)
            //    {
            //        valorNotaFinal = matriz[i][3];
            //        notaFinal = i;
            //    }
            //}
            //Console.WriteLine("Aluno com a maior nota");
            //Console.WriteLine(matriz[notaFinal][0]);
            //Console.WriteLine("--------------------//--------------------");

            //// d)
            //int mediaFinal = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    mediaFinal += matriz[i][3];
            //}
            //Console.WriteLine("A media final de todos os alunos é!!!");
            //Console.WriteLine(mediaFinal / matriz.Length);

            // EXEC 03
            //int[][] matriz = new int[3][];
            //int soma = 0;
            //int media = 0;

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[6];
            //}
            //Console.WriteLine("Insira os elementos da matriz");
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.WriteLine("Posição: " + i + " " + j);
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //// a)
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if(j % 2 == 0)
            //        {
            //            soma = soma + matriz[i][j];
            //        }
            //    }
            //}
            //Console.WriteLine("A soma de todos os elementos das colunas ímpares é igual a: " + soma);
            //// b)
            //soma = 0;
            //int numElementos = 0;
            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        soma = soma + matriz[i][1] + matriz[i][3];                    
            //    }
            //    numElementos = numElementos + 1;
            //}
            //media = soma / (numElementos * 2);
            //Console.WriteLine(media);
        }
    }
}
