using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Núbia_Peixer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva seu código Aqui ;)
            // Nome: Núbia Peixer

            int[][] produto1 = new int[6][];
            int[][] produto2 = new int[6][];
            int[][] produto3 = new int[6][];
            int[][] produto4 = new int[6][];

            // Gera as matrizes (estoque de cada produto) 
            for (int i = 0; i < produto1.Length; i++)
            {
                produto1[i] = new int[6];
                produto2[i] = new int[6];
                produto3[i] = new int[6];
                produto4[i] = new int[6];
            }
            int id1 = 1, id2 = 2, id3 = 3, id4 = 4;
            // Preenche as matrizes usando função (inicia com estoque pela metade)
            produto1 = Matriz(id1, produto1);
            produto2 = Matriz(id2, produto2);
            produto3 = Matriz(id3, produto3);
            produto4 = Matriz(id4, produto4);

            int dia = 1;
            do
            {
                Console.WriteLine("------------ " + dia + "° dia ------------");
                Console.WriteLine();

                // 1° - Gera quantidade de cargas chegando
                Console.WriteLine("CARGAS CHEGANDO");
                Console.WriteLine();

                int qtdCargas = Geradores.Qtd();
                Console.WriteLine("Está vindo " + qtdCargas + " carga(s)");


                List<string> cargasEntrada = new List<string>();
                int contagem1 = 0, contagem2 = 0, contagem3 = 0, contagem4 = 0;

                Console.WriteLine("Lista(s) de produtos recebidos:");

                // Gera as listas com os produtos (recebe carga)
                for (int i = 0; i < qtdCargas; i++)
                {
                    cargasEntrada = Geradores.GeraEntrada();

                    Console.Write("--> ");
                    foreach (var item in cargasEntrada)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();

                    // Conta a quantidade de produtos de cada ID                    
                    foreach (var item in cargasEntrada)
                    {
                        if (item == "1")
                        {
                            contagem1 += 1;
                        }
                        else if (item == "2")
                        {
                            contagem2 += 1;
                        }
                        else if (item == "3")
                        {
                            contagem3 += 1;
                        }
                        else
                        {
                            contagem4 += 1;
                        }
                    }
                }
                Console.WriteLine();

                Console.WriteLine("Total Recebidos:");
                Console.WriteLine("Produto ID1: " + contagem1);
                Console.WriteLine("Produto ID2: " + contagem2);
                Console.WriteLine("Produto ID3: " + contagem3);
                Console.WriteLine("Produto ID4: " + contagem4);

                Console.WriteLine();

                //Preenche cada matriz com as cargas recebidas(organiza no estoque)
                RecebeCarga(produto1, contagem1, id1);
                RecebeCarga(produto2, contagem2, id2);
                RecebeCarga(produto3, contagem3, id3);
                RecebeCarga(produto4, contagem4, id4);

                Console.WriteLine("Pressione enter para ver o estoque");
                Console.ReadLine();

                // 2° - Mostra o estoque depois de receber as cargas
                Console.WriteLine("*ESTOQUES*\n");

                MostraMatriz(produto1);
                Console.WriteLine();
                MostraMatriz(produto2);
                Console.WriteLine();
                MostraMatriz(produto3);
                Console.WriteLine();
                MostraMatriz(produto4);
                Console.WriteLine();

                Console.WriteLine("Pressione enter para progredir");
                Console.ReadLine();

                // 3° - Envio de cargas
                // Gera a quantidade de cargas (ordem de serviço)
                Console.WriteLine("CARGAS SOLICITADAS");

                qtdCargas = Geradores.Qtd();
                Console.WriteLine(qtdCargas + " carga(s)\n");

                // Para contar total de produtos solicitados
                int prod1 = 0, prod2 = 0, prod3 = 0, prod4 = 0;

                // Produto no estoque por pedido
                contagem1 = 0; contagem2 = 0; contagem3 = 0; contagem4 = 0;

                // Total no estoque de todos os pedidos
                int total1 = 0, total2 = 0, total3 = 0, total4 = 0;

                Console.WriteLine("-----------------//--------------");
                for (int i = 0; i < qtdCargas; i++)
                {
                    Console.WriteLine("Ordem de serviço n°" + (i + 1));
                    Console.WriteLine();
                    Console.Write("Pedido -->  ");
                    string cargaSaida = Geradores.OrdemDeServico();
                    Console.WriteLine(cargaSaida);                    

                    // Conta quantos produtos de cada ID foram solicitados
                    foreach (var item in cargaSaida)
                    {
                        if (item == '1')
                        {
                            prod1++;
                        }
                        else if (item == '2')
                        {
                            prod2++;
                        }
                        else if (item == '3')
                        {
                            prod3++;
                        }
                        else
                        {
                            prod4++;
                        }
                    }

                    // Confere se os produtos solicitados estão disponíveis em estoque
                    // se estiver disponível faz a retirada                    
                    for (int j = 0; j < cargaSaida.Length; j++)
                    {
                        string numero = cargaSaida.Substring(j, 1); // separa cada elemento da string de j a 1

                        if (numero == "1")
                        {
                            bool encontrado = false;
                            for (int k = produto1.Length - 1; k >= 0; k--)
                            {
                                for (int l = produto1[k].Length - 1; l >= 0; l--)
                                {
                                    if (produto1[k][l] == id1)
                                    {
                                        produto1[k][l] = 0;                                        
                                        contagem1++;
                                        total1++;
                                        encontrado = true;
                                        break;
                                    }
                                }
                                if (encontrado)
                                {
                                    break;
                                }
                            }
                        }

                        else if (numero == "2")
                        {
                            bool encontrado = false;
                            for (int k = produto2.Length - 1; k >= 0; k--)
                            {
                                for (int l = produto2[k].Length - 1; l >= 0; l--)
                                {
                                    if (produto2[k][l] == id2)
                                    {
                                        produto2[k][l] = 0;                                        
                                        contagem2++;
                                        total2++;
                                        encontrado = true;
                                        break;
                                    }
                                }
                                if (encontrado)
                                {
                                    break;
                                }
                            }
                        }
                        else if (numero == "3")
                        {
                            bool encontrado = false;
                            for (int k = produto3.Length - 1; k >= 0; k--)
                            {
                                for (int l = produto3[k].Length - 1; l >= 0; l--)
                                {
                                    if (produto3[k][l] == id3)
                                    {
                                        produto3[k][l] = 0;                                        
                                        contagem3++;
                                        total3++;
                                        encontrado = true;
                                        break;
                                    }
                                }
                                if (encontrado)
                                {
                                    break;
                                }
                            }
                        }
                        else if (numero == "4")
                        {
                            bool encontrado = false;
                            for (int k = produto4.Length - 1; k >= 0; k--)
                            {
                                for (int l = produto4[k].Length - 1; l >= 0; l--)
                                {
                                    if (produto4[k][l] == id4)
                                    {
                                        produto4[k][l] = 0;                                        
                                        contagem4++;
                                        total4++;
                                        encontrado = true;
                                        break;
                                    }
                                }
                                if (encontrado)
                                {
                                    break;
                                }
                            }
                        }
                    }

                    int total = contagem1 + contagem2 + contagem3 + contagem4;
                    int vetor;

                    // Para definir tamanho do vetor
                    if (total == 0)
                    {
                        vetor = 0;
                    }
                    else if (total < 7)
                    {
                        vetor = 6;
                    }
                    else if (total < 9)
                    {
                        vetor = 8;
                    }
                    else
                    {
                        vetor = 10;
                    }

                    // Coloca os produtos no vetor em ordem 
                    int[] pedido = new int[vetor];

                    for (int j = 0; j < pedido.Length; j++)
                    {
                        if (contagem1 > 0)
                        {
                            pedido[j] = id1;
                            contagem1--;
                        }
                        else if (contagem2 > 0)
                        {
                            pedido[j] = id2;
                            contagem2--;
                        }
                        else if (contagem3 > 0)
                        {
                            pedido[j] = id3;
                            contagem3--;
                        }
                        else if (contagem4 > 0)
                        {
                            pedido[j] = id4;
                            contagem4--;
                        }
                        else
                        {
                            pedido[j] = 0;
                        }
                    }

                    Console.Write("Envio  -->  ");
                    if (total != 0)
                    {
                        foreach (var item in pedido)
                        {
                            Console.Write(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("sem estoque");
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------//--------------");
                }
                Console.WriteLine();

                Console.WriteLine("Total Solicitados:");
                Console.WriteLine("Produto ID1: " + prod1);
                Console.WriteLine("Produto ID2: " + prod2);
                Console.WriteLine("Produto ID3: " + prod3);
                Console.WriteLine("Produto ID4: " + prod4);

                Console.WriteLine();
                Console.WriteLine("Total Enviados:");
                Console.WriteLine("Produto ID1: " + total1);
                Console.WriteLine("Produto ID2: " + total2);
                Console.WriteLine("Produto ID3: " + total3);
                Console.WriteLine("Produto ID4: " + total4);

                Console.WriteLine();

                // Mostra os produtos solicitados em falta (Função)
                if (total1 < prod1)
                {
                    Confere(total1, prod1, id1);
                }
                if (total2 < prod2)
                {
                    Confere(total2, prod2, id2);
                }
                if (total3 < prod3)
                {
                    Confere(total3, prod3, id3);
                }
                if (total4 < prod4)
                {
                    Confere(total4, prod4, id4);
                }

                Console.WriteLine();
                Console.WriteLine("Pressione enter para ver estoque");
                Console.ReadLine();

                // 4° - Mostra estoque depois que as cargas foram enviadas
                Console.WriteLine("*Estoques Atualizados*\n");

                MostraMatriz(produto1);
                Console.WriteLine();
                MostraMatriz(produto2);
                Console.WriteLine();
                MostraMatriz(produto3);
                Console.WriteLine();
                MostraMatriz(produto4);
                Console.WriteLine();

                Console.WriteLine("*Fim do Expediente*");
                Console.WriteLine();

                Console.WriteLine("Pressione enter para progredir");
                Console.ReadLine();

                dia++;
            } while (dia < 7);
        }
        // Função para preencher as matrizes com metade do estoque
        public static int[][] Matriz(int id, int[][] produtos)
        {
            for (int i = 0; i < produtos.Length; i++)
            {
                for (int j = 0; j < produtos[i].Length; j++)
                {
                    if (i < 3)
                    {
                        produtos[i][j] = id;
                    }
                    else
                    {
                        produtos[i][j] = 0;
                    }
                }
            }
            return produtos;
        }
        // Função para receber as cargas
        public static void RecebeCarga(int[][] produto, int contagem, int id)
        {
            for (int k = 0; k < contagem; k++)
            {
                bool encontrado = false;
                for (int i = 0; i < produto.Length; i++)
                {
                    for (int j = 0; j < produto[i].Length; j++)
                    {
                        if (produto[i][j] == 0)
                        {
                            produto[i][j] = id;
                            encontrado = true;
                            break;
                        }
                    }
                    if (encontrado)
                    {
                        break;
                    }
                }
            }
        }
        // Função para mostrar matriz na tela
        public static void MostraMatriz(int[][] produtos)
        {
            for (int i = 0; i < produtos.Length; i++)
            {
                for (int j = 0; j < produtos[i].Length; j++)
                {
                    Console.Write(produtos[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        // Compara produtos solicitados com disponíveis no estoque
        public static void Confere(int contagem, int produto, int id)
        {
            Console.WriteLine("**EM FALTA**");
            Console.WriteLine("Produto ID" + id + ": " + (Math.Abs(contagem - produto)));
        }
    }
}
