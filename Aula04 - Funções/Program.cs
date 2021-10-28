using System;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            // Núbia
            // Exec 01
            //Program prog = new Program();
            //int entrada1, entrada2, resultado;
            //Console.WriteLine("Insira dois números");
            //entrada1 = Convert.ToInt32(Console.ReadLine());
            //entrada2 = Convert.ToInt32(Console.ReadLine());
            //resultado = prog.Compara(entrada1, entrada2);
            //Console.WriteLine(resultado);

            // EXEC 02
            //Program prog = new Program();
            //Console.WriteLine("Insira um número");
            //int x = prog.CRI();
            //x = prog.ParOuImpar(x);
            //Console.WriteLine(x);

            // EXEC 03
            //Program prog = new Program();
            //Console.WriteLine("Insira um número");
            //int x = Convert.ToInt32(Console.ReadLine());
            //x = prog.ParImparOuZero(x);
            //Console.WriteLine(x);

            // EXEC 04
            //Program prog = new Program();
            //Console.WriteLine("Insira a temperatura em Celsius para converter em Fahrenheit");
            //double x = Convert.ToDouble(Console.ReadLine());
            //x = prog.Temperatura(x);
            //Console.WriteLine(x);

            // EXEC 05 (CORRIGIDO)
            //Program prog = new Program();
            //double nota1, nota2, nota3, devolucao;
            //string escolha;
            //Console.WriteLine("Insira a primeira nota do aluno");
            //nota1 = Convert.ToDouble(Console.ReadLine()); // ou usar a função CRD
            //Console.WriteLine("Insira a segunda nota do aluno");
            //nota2 = prog.CRD();
            //Console.WriteLine("Insira a terceira nota do aluno");
            //nota3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite A - Média aritmétrica das notas");
            //Console.WriteLine("Digite P - Média ponderada das notas");
            //Console.WriteLine("Digite M - Mediana das notas");
            //escolha = Console.ReadLine();
            //devolucao = prog.Escola(nota1, nota2, nota3, escolha);
            //Console.WriteLine("---------------//---------------");
            //if(devolucao == -1)
            //{
            //    Console.WriteLine("Opção inválida");
            //}
            //else
            //{
            //    Console.WriteLine(devolucao);
            //}


            // EXEC 06
            //Program prog = new Program();
            //Console.WriteLine("Insira 5 valores");
            //Console.WriteLine("Valor 1:");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Valor 2:");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Valor 3:");
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Valor 4:");
            //int numero4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Valor 5:");
            //int numero5 = Convert.ToInt32(Console.ReadLine());

            //double resultado = prog.Calculo(numero1, numero2, numero3, numero4, numero5);
            //Console.WriteLine(resultado);

            // EXEC 07
            //Program prog = new Program();
            //Console.WriteLine("Insira os lados de um triângulo retângulo");
            //Console.WriteLine("Insira o cateto oposto");
            //double oposto = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Insira o cateto adjacente");
            //double adjacente = Convert.ToDouble(Console.ReadLine());
            //double resultado = prog.Hipotenusa(oposto, adjacente);
            //Console.WriteLine(resultado);

            // EXEC 08 (CORRIGIDO)
            //Program prog = new Program();
            //Console.WriteLine("Insira o tamanho do vetor");
            //int tamanho = Convert.ToInt32(Console.ReadLine());
            //int[] numeros = new int[tamanho];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = prog.CRI(); // numeros[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //numeros = prog.SortManual(numeros); // equivalente Array.Sort
            ////Array.Sort(numeros);
            //Console.WriteLine("----------------//---------------------");
            //// Mostra o vetor
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            // PARTE 02

            // EXEC 01
            //Program prog = new Program();
            //Console.WriteLine("Insira dois números");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int resultado = prog.Maior(numero1, numero2);
            //Console.WriteLine("------------//------------");
            //Console.WriteLine("O maior número é " + resultado);
            //Console.WriteLine("****************************");
            //Console.WriteLine("Insira 4 números");
            //numero1 = Convert.ToInt32(Console.ReadLine());
            //numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            //int numero4 = Convert.ToInt32(Console.ReadLine());
            //resultado = prog.Maior2(numero1, numero2, numero3, numero4);
            //Console.WriteLine("---------------------//-----------------");
            //Console.WriteLine("O maior número é " + resultado);

            // EXEC 02 (CORRIGIDO)
            //Program prog = new Program();
            //int[] vetor = new int[10];
            //Random ran = new Random();
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = ran.Next(0, 10);
            //    Console.Write(vetor[i] + " ");
            //}
            //Console.WriteLine("\n\n"); // pula duas linhas (n = next line)
            //Console.WriteLine("Qual elemento deseja ver? 1 à 10");
            //int escolha = Convert.ToInt32(Console.ReadLine()); // OU escolha = prog.CRI();
            //escolha --; // para ao invés de começar com 0 a 9, fica de 1 a 10
            //escolha = prog.Selecao(vetor, escolha);
            //Console.WriteLine(escolha);

            // EXEC 03
            //Program prog = new Program();
            //Random ran = new Random();
            //Console.WriteLine("Informe se deseja inserir números ou gerar números aleatórios para um vetor");
            //Console.WriteLine("1 - Para inserir números");
            //Console.WriteLine("2 - Para gerar aleatoriamente");
            //int escolha = Convert.ToInt32(Console.ReadLine());
            //int[] vetor = new int[10];
            //if (escolha == 1)
            //{
            //    Console.WriteLine("Insira os números do vetor");
            //    for (int i = 0; i < vetor.Length; i++)
            //    {
            //        vetor[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < vetor.Length; i++)
            //    {
            //        vetor[i] = ran.Next(0, 10);
            //    }
            //}
            //Console.WriteLine("Vetor original");
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine(vetor[i]);
            //}
            //Console.WriteLine("-------------------//-------------------");
            //vetor = prog.OrganizarVetor(vetor);
            //Console.WriteLine("Vetor organizado do maior para o menor");
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.WriteLine(vetor[i]);
            //}

            // EXEC 04
            //Program prog = new Program();
            //Console.WriteLine("Insira dois números");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Insira a operação que deseja realizar");
            //Console.WriteLine("Para somar os valores + ");
            //Console.WriteLine("Para subtrair os valores - ");
            //char operador = Convert.ToChar(Console.ReadLine());
            //int resultado = prog.Operacao(numero1, numero2, operador);
            //if (resultado == -1)
            //{
            //    Console.WriteLine("Não foi possível efetuar o cálculo");
            //}
            //else
            //{
            //    Console.WriteLine(resultado);
            //}

            // EXEC 05 (CORRIGIDO)
            //Program prog = new Program();
            //string[] logins = { "a", "b", "c", "d", "e" };
            //string[] senhas = { "A", "B", "C", "D", "E" };
            //Console.WriteLine("Login");
            //string login = Console.ReadLine();
            //Console.WriteLine("Senha");
            //string senha = Console.ReadLine();

            //string resposta = prog.Login(logins, senhas, login, senha);
            //Console.WriteLine(resposta);      

            // PARTE 05
            // EXEC 01
            //Program prog = new Program();
            //Random ran = new Random();
            //int[][] matriz = new int[5][];

            //while (true)
            //{
            //    for (int i = 0; i < matriz.Length; i++)
            //    {
            //        matriz[i] = new int[5];
            //    }
            //    for (int i = 0; i < matriz.Length; i++)
            //    {
            //        for (int j = 0; j < matriz[i].Length; j++)
            //        {
            //            matriz[i][j] = ran.Next(0, 30);
            //            if (matriz[i][j] < 10)
            //            {
            //                Console.Write("0" + matriz[i][j] + " ");
            //            }
            //            else
            //            {
            //                Console.Write(matriz[i][j] + " ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Digite o número que deseja encontrar na matriz gerada");
            //    int numero = Convert.ToInt32(Console.ReadLine());
            //    numero = prog.NumeroSelecionado(matriz, numero);
            //    Console.WriteLine(numero);
            //    Console.WriteLine("----------------//-----------------");
            //    Console.WriteLine("Deseja encerrar o programa?");
            //    Console.WriteLine("1 - Encerra / 2 - Continua");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero == 1)
            //    {
            //        break;
            //    }
            //}
            // EXEC 02
            //Program prog = new Program();
            //Random ran = new Random();
            //int[] vetor1 = new int[10];
            //int[] vetor2 = new int[10];
            //int[] vetor3 = new int[10];
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    vetor1[i] = ran.Next(0, 20);
            //    vetor2[i] = ran.Next(0, 20);
            //    vetor3[i] = ran.Next(0, 20);
            //}

            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    if(vetor1[i] < 10)
            //    {
            //        Console.Write("0" + vetor1[i] + " ");
            //    }
            //    else
            //    {
            //        Console.Write(vetor1[i] + " ");
            //    }

            //}

            //Console.WriteLine("\n\n");
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    if (vetor2[i] < 10)
            //    {
            //        Console.Write("0" + vetor2[i] + " ");
            //    }
            //    else
            //    {
            //        Console.Write(vetor2[i] + " ");
            //    }
            //}
            //Console.WriteLine("\n\n");
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    if (vetor3[i] < 10)
            //    {
            //        Console.Write("0" + vetor3[i] + " ");
            //    }
            //    else
            //    {
            //        Console.Write(vetor3[i] + " ");
            //    }
            //}
            //Console.WriteLine("\n\n");
            //int[] vetorResultado = prog.VetorResultado(vetor1, vetor2, vetor3);
            //Console.WriteLine("Vetor resultado");

            //for (int i = 0; i < vetorResultado.Length; i++)
            //{
            //    if (vetorResultado[i] < 10)
            //    {
            //        Console.Write("0" + vetorResultado[i] + " ");
            //    }
            //    else
            //    {
            //        Console.Write(vetorResultado[i] + " ");
            //    }
            //}
            //
            // EXEC 03
            //Program prog = new Program();
            //Console.WriteLine("Qual o valor total da compra do cliente?");
            //double valorTotal = Convert.ToDouble(Console.ReadLine());
            //int opcao = prog.Opcoes();
            //Console.WriteLine("Você escolheu a opção " + opcao);

            //if (opcao == 1)
            //{
            //    valorTotal = prog.Opcao1(valorTotal);
            //    Console.WriteLine("Total a pagar:");
            //    Console.WriteLine("R$" + valorTotal);
            //}
            //else if (opcao == 2)
            //{
            //    valorTotal = prog.Opcao2(valorTotal);
            //    Console.WriteLine("Total a pagar:");
            //    Console.WriteLine("2x R$" + valorTotal);
            //}
            //else
            //{
            //    Console.WriteLine("Quantas parcelas você deseja fazer?");
            //    int escolha = Convert.ToInt32(Console.ReadLine());
            //    valorTotal = prog.Opcao3(valorTotal, escolha);
            //    Console.WriteLine("Total a pagar:");
            //    Console.WriteLine(escolha + "x R$" + valorTotal);
            //}
        }


        public int Compara(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }



        } // exec 01

        public int ParOuImpar(int entrada)
        {
            if (entrada % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        } // exec 02

        public string CR()
        {
            return Console.ReadLine();
        }
        public int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public double CRD()
        {
            return Convert.ToDouble(CR());
        }

        public int ParImparOuZero(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        } // exec 03

        public double Temperatura(double x) // exec 04
        {
            return (x / 5) * 9 + 32;
        }

        public double Escola(double n1, double n2, double n3, string alternativa) // exec 05
        {
            double resultado = 0;
            switch (alternativa)
            {
                case "A":
                case "a":
                    resultado = (n1 + n2 + n3) / 3;
                    return resultado;
                case "P": // média ponderada
                case "p": // (n1*p1 + n2*p2 + ... nn*pn) / p1 + p2 + ... + pn
                    resultado = (n1 * 5 + n2 * 3 + n3 * 2) / (5 + 3 + 2);
                    return resultado;
                case "M":
                case "m":
                    double[] notas = new double[3];
                    notas[0] = n1;
                    notas[1] = n2;
                    notas[2] = n3;
                    Array.Sort(notas);
                    resultado = notas[1]; // elemento do meio = 1
                    return resultado;
                default:
                    return -1;
            }
        }

        public double Calculo(int a, int b, int c, int d, int e)
        {
            return (a + b + c) / (d * e);
        } // exec 06

        public double Hipotenusa(double a, double b)
        {
            double c = Math.Sqrt((a * a + b * b));
            return c;

        } // exec 07

        public int[] SortManual(int[] vetor) // exec 08
        {
            // Laço que percorre o vetor do início ao fim
            for (int i = 0; i < vetor.Length; i++)
            {
                // Laço que volta organizando
                for (int j = i; j > 0; j--)
                {
                    if (vetor[j - 1] > vetor[j])
                    {
                        // temp = temporário - para trocar os valores
                        int temp = vetor[j];
                        vetor[j] = vetor[j - 1];
                        vetor[j - 1] = temp;
                    }
                }
            }
            return vetor;
        }

        public int Maior(int x, int y) // parte 02 exec01
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public int Maior2(int a, int b, int c, int d)
        {
            int[] numeros = new int[4];
            numeros[0] = a;
            numeros[1] = b;
            numeros[2] = c;
            numeros[3] = d;
            Array.Sort(numeros);
            int resultado = numeros[3];
            return resultado;
        }

        public int Selecao(int[] vetor, int a) // exec 02
        {
            return vetor[a];
        }

        public int[] OrganizarVetor(int[] vetor) // exec 03
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (vetor[j - 1] < vetor[j]) // do maior para o menor <
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j - 1];
                        vetor[j - 1] = temp;
                    }
                }
            }
            return vetor;
        }

        public int Operacao(int n1, int n2, char opcao) // exec 04
        {
            switch (opcao)
            {
                case '+':
                    return n1 + n2;
                case '-':
                    return n1 - n2;
                default:
                    return -1;
            }
        }

        public string Login(string[] logins, string[] senhas, string login, string senha) // exec 05
        {
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] == login && senhas[i] == senha)
                {
                    return "Login Efetuado";
                }
            }
            return "Login Inválido";
        }

        public int NumeroSelecionado(int[][] matriz, int a)// LISTA 05 exec 01
        {
            bool nãoEncontrado = true;
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] == a)
                    {
                        nãoEncontrado = false;
                    }
                }
            }
            if (nãoEncontrado)
            {
                return -1234;
            }
            else
            {
                return a;
            }
        }

        public int[] VetorResultado(int[] vet1, int[] vet2, int[] vet3) // exec 02
        {
            int[] vetResultado = new int[10];
            for (int i = 0; i < vet1.Length; i++)
            {
                if (vet1[i] >= vet2[i] && vet1[i] >= vet3[i])
                {
                    vetResultado[i] = vet1[i];
                }
                else if (vet2[i] >= vet1[i] && vet2[i] >= vet3[i])
                {
                    vetResultado[i] = vet2[i];
                }
                else
                {
                    vetResultado[i] = vet3[i];
                }
            }
            return vetResultado;
        }

        public int Opcoes() // exec 03
        {

            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("Opção 1 - A vista com 10 % de desconto.");
            Console.WriteLine("Opção 2 - Em 2 vezes (preço da etiqueta).");
            Console.WriteLine("Opção 3 - De 3 a 10 vezes com 3% de juros ao mês (compras acima de R$ 100,00)");

            int escolha = Convert.ToInt32(Console.ReadLine());
            return escolha;
        }

        public double Opcao1(double valor)
        {
            double valorFinal = valor * 0.9;
            return valorFinal;
        }
        public double Opcao2(double valor)
        {
            double valorFinal = valor / 2;
            return valorFinal;
        }
        public double Opcao3(double valor, double parcelas)
        {
            double valorFinal = (valor / parcelas) * 1.3;
            return valorFinal;

        }

    }
}
