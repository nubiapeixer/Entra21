using System;
using System.Collections.Generic;

namespace Variáveis_avançadas__static_e_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // Núbia
            // Variáveis Avançadas, Static e List

            // EXEC 01

            //// criando a lista
            //List<string> listaDeString = new List<string>();
            //// pedir dados para usuário
            //Console.WriteLine("Insira 2 entradas");
            //string entrada = Program.CR();
            //listaDeString.Add(entrada);
            //entrada = CR();
            //listaDeString.Add(entrada);
            //// mostrar na tela
            //Console.WriteLine("-------------------//-----------------");
            //for (int i = 0; i < listaDeString.Count; i++)
            //{
            //    Console.WriteLine(listaDeString[i]);
            //}
            //Console.WriteLine("-------------------//-----------------");

            //foreach(var item in listaDeString)
            //{
            //    Console.WriteLine(item);
            //}

            // EXEC 02

            // cria lista
            //List<double> notas = new List<double>();

            //// pede dados
            //Console.WriteLine("Insira 3 notas");
            //for (int i = 0; i < 3; i++)
            //{
            //    double nota = CRD();
            //    notas.Add(nota);
            //}

            //// mostra
            //double resultado = 0;
            //foreach (var item in notas)
            //{
            //    resultado += item;
            //}
            //Console.WriteLine("Média: " + (resultado/3));

            // USANDO VAR
            //List<double> notas = new List<double>();

            //// pede dados
            //Console.WriteLine("Insira 3 notas");
            //for (int i = 0; i < 3; i++)
            //{
            //    var nota = CRD();
            //    notas.Add(nota);
            //}

            //// mostra
            //double resultado = 0;
            //foreach (var item in notas)
            //{
            //    resultado += item;
            //}
            //Console.WriteLine("Média: " + (resultado / 3));

            // EXEC 03
            //List<int> valores = new List<int>();

            //Console.WriteLine("Insira 3 valores");
            //for (int i = 0; i < 3; i++)
            //{
            //    int valor = CRI(); // chama função Convert.ToInt32(Console.WriteLine());
            //    valores.Add(valor);
            //}
            //if (valores[0] == valores[1] && valores[0] == valores[2])
            //{
            //    Console.WriteLine("Os valores são todos iguais");
            //}
            //else if (valores[0] > valores[1] && valores[0] > valores[2])
            //{
            //    Console.WriteLine("O maior número é " + valores[0]);
            //}
            //else if (valores[1] > valores[0] && valores[1] > valores[2])
            //{
            //    Console.WriteLine("O maior número é " + valores[1]);
            //}
            //else
            //{
            //    Console.WriteLine("O maior número é " + valores[2]);
            //}

            // EXEC 04
            //List<double> numeros = new List<double>();
            //Console.WriteLine("Insira os valores que deseja multiplicar");
            //Console.WriteLine("Para encerrar digite 0");
            //double resultado = 1;
            //while (true)
            //{

            //    double numero = CRD();

            //    if (numero == 0)
            //    {

            //        break;
            //    }
            //    numeros.Add(numero);

            //}
            //foreach (var item in numeros)
            //{
            //    resultado *= item;
            //}
            //Console.WriteLine("O produto dos valores é igual a " + resultado);

            // EXEC 05
            //List<double> numeros = new List<double>();
            //Console.WriteLine("Insira números em ordem crescente");
            //Console.WriteLine("Para encerrar digite: fim");

            //while (true)
            //{
            //    string entrada = Console.ReadLine();
            //    if (entrada == "fim")
            //    {
            //        break;
            //    }
            //    double numero = Convert.ToDouble(entrada);
            //    numeros.Add(numero);

            //    for (int i = 1; i < numeros.Count; i++)
            //    {
            //        if (numeros[i] < numeros[i - 1])
            //        {
            //            do
            //            {
            //                Console.WriteLine("Este número é muito pequeno, insira outro");
            //                numeros[i] = Convert.ToDouble(Console.ReadLine());
            //            } while (numeros[i] < numeros[i - 1]);
            //        }
            //    }
            //}
            //Console.WriteLine("----------//----------");
            //foreach (var item in numeros)
            //{
            //    Console.Write(item + " ");
            //}

            // EXEC 06 (CORRIGIDO)
            //List<string> logins = new List<string>();
            //List<string> senhas = new List<string>();

            //// preenche as listas com letras de 'a' a 'e'
            //for (int i = 97; i < 102; i++) // tabela ascii "a" 97 a 102 tem 5 elementos preenche de a e
            //{
            //    char letra = (char)i; // ou Convert.ToChar
            //    logins.Add(letra.ToString());
            //    letra = Convert.ToChar(i - 32);
            //    senhas.Add(Convert.ToString(letra));
            //}
            //// mostra as listas (teste)
            ////foreach (var item in logins)
            ////{
            ////    Console.Write(item + "  ");
            ////}
            ////Console.WriteLine();
            ////foreach (var item in senhas)
            ////{
            ////    Console.Write(item + "  ");
            ////}
            ////Console.WriteLine();

            //while (true)
            //{
            //    Console.WriteLine("Insira o login ou sair ou ver");
            //    string tempL = CR();

            //    if (tempL == "sair")
            //    {
            //        break;
            //    }
            //    else if (tempL == "ver")
            //    {
            //        MostraLista(logins);
            //        MostraLista(senhas);
            //    }
            //    else if (tempL == "Admin")
            //    {
            //        Console.WriteLine("Senha do Admin");
            //        string tempS = CR();
            //        if (tempS == "@Senac")
            //        {
            //            int a = 0; // Pra conseguir fazer log out do swtich case 
            //            while (a == 0)
            //            {
            //                Console.WriteLine("\t\t***Menu Do Admin***");
            //                Console.WriteLine("1 - Criar Conta");
            //                Console.WriteLine("2 - Deletar Conta");
            //                Console.WriteLine("3 - LogOut");
            //                int escolha = CRI();
            //                switch (escolha)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Qual o login desta conta?");
            //                        string entrada = CR();

            //                        // não pode ter logins iguais
            //                        if (BuscaEmLista(logins, entrada) == -1)
            //                        {
            //                            logins.Add(entrada); // resumindo: logins.Add(Console.ReadLine()); ou CR();
            //                            Console.WriteLine("Qual a senha?");
            //                            entrada = CR();
            //                            senhas.Add(entrada);
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Login já existente");
            //                        }
            //                        break;
            //                    case 2:
            //                        int cont = 0;
            //                        foreach (var item in logins)
            //                        {
            //                            cont++; // cont = cont + 1;
            //                            Console.WriteLine(cont + " --> " + item);
            //                        }
            //                        Console.WriteLine("\nQual deseja remover?");
            //                        cont = CRI();
            //                        logins.RemoveAt(cont-1);
            //                        senhas.RemoveAt(cont-1);
            //                        break;
            //                    case 3:
            //                        a = 1;
            //                        Console.WriteLine("Log Out Efetuado");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Opção inválida");
            //                        break;
            //                }
            //                Console.WriteLine("Pressione enter para progredir");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Senha incorreta");
            //        }
            //    }
            //    else
            //    {
            //        // forma resumida de resolver usando função
            //        int indice = BuscaEmLista(logins, tempL);
            //        if (indice != -1)
            //        {
            //            Console.WriteLine("Qual a senha?");
            //            string tempS = CR();
            //            if (senhas[indice] == tempS)
            //            {
            //                Console.WriteLine("Login efetuado");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Senha incorreta");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Login não encontrado");
            //        }
            //    }

            //    Console.WriteLine("Pressione enter para progredir");
            //    Console.ReadLine();
            //    Console.Clear();
            //}


            // LISTA 02

            // EXEC 01
            //List<string> nomes = new List<string>();
            //Console.WriteLine("Insira nome ou sair");

            //while (true)
            //{
            //    string nome = Console.ReadLine();

            //    if (nome == "sair")
            //    {
            //        Console.WriteLine();
            //        foreach (var item in nomes)
            //        {                        
            //            Console.WriteLine(item);
            //        }
            //        break;
            //    }
            //    nomes.Add(nome);
            //}

            // EXEC 02
            //List<double> notas = new List<double>();
            //double soma = 0;
            //double media = 0;
            //Console.WriteLine("Insira as notas do aluno ou sair");
            //while (true)
            //{
            //    string escolha = Console.ReadLine();
            //    if (escolha == "sair")
            //    {

            //        break;
            //    }
            //    double nota = Convert.ToDouble(escolha);
            //    soma += nota;
            //    notas.Add(nota);
            //}
            //foreach (var item in notas)
            //{
            //    media = soma / (notas.Count);
            //}
            //Console.WriteLine(media);

            // EXEC 03
            //List<int> numeros = new List<int>();

            //Console.WriteLine("Insira um número");
            //Console.WriteLine("ou sair para ver o maior número e o menor");

            //while (true)
            //{
            //    string escolha = Console.ReadLine();
            //    if (escolha == "sair")
            //    {
            //        break;
            //    }
            //    int numero = Convert.ToInt32(escolha);
            //    numeros.Add(numero);
            //}
            //numeros.Sort();
            //// numeros.Sort();
            //// numeros.Reverse(); ao contrário
            //Console.WriteLine("O maior número inserido foi " + numeros[numeros.Count - 1]);
            //Console.WriteLine("O menor número inserido foi " + numeros[0]);

            //// ORDENAR A MÃO
            ////for (int i = 0; i < numeros.Count; i++)
            ////{
            ////    for (int j = i; j > 0; j--)
            ////    {
            ////        if (numeros[j - 1] > numeros[j])
            ////        {
            ////            int temp = numeros[j];
            ////            numeros[j] = numeros[j - 1];
            ////            numeros[j - 1] = temp;
            ////        }
            ////    }
            ////}
            ////for (int i = 0; i < numeros.Count; i++)
            ////{
            ////    Console.Write(numeros[i] + " ");

            ////}
            ////Console.WriteLine();


            // EXEC 04
            //List<int> nascimento = new List<int>();
            //List<string> nomes = new List<string>();

            //Console.WriteLine("Insira os dados da pessoa ou sair");
            //while (true)
            //{
            //    Console.WriteLine("Insira o nome");
            //    string nome = Console.ReadLine();

            //    if (nome == "sair")
            //    {
            //        break;
            //    }
            //    nomes.Add(nome);
            //    Console.WriteLine("Insira o ano de nascimento");
            //    int data = Convert.ToInt32(Console.ReadLine());                
            //    nascimento.Add(data);
            //}

            //for (int i = 0; i < nascimento.Count; i++)
            //{
            //    nascimento[i] = 2021 - nascimento[i];
            //}


            //for (int i = 0; i < nascimento.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (nascimento[j - 1] < nascimento[j])
            //        {
            //            int tempData = nascimento[j];
            //            nascimento[j] = nascimento[j - 1];
            //            nascimento[j - 1] = tempData;

            //            String tempNome = nomes[j];
            //            nomes[j] = nomes[j - 1];
            //            nomes[j - 1] = tempNome;
            //        }
            //    }
            //}
            //for (int i = 0; i < nascimento.Count; i++)
            //{
            //    Console.WriteLine(nomes[i]);
            //    Console.WriteLine(nascimento[i]);
            //}

            // exec 05
            //List<string> placas = new List<string>();
            //List<double> horaEntrada = new List<double>();

            //while (true)
            //{
            //    Console.WriteLine("Informe se o veículo está entrando ou saindo");
            //    Console.WriteLine("1 - Entrando\n2 - Saindo");
            //    int opcao = Convert.ToInt32(Console.ReadLine());
            //    if (opcao == 1)
            //    {
            //        bool cheio = true;
            //        for (int i = 0; i < 10; i++)
            //        {
            //            if (placas.Count <= 9)
            //            {
            //                Console.WriteLine("Qual a placa?");
            //                string placa = Console.ReadLine();
            //                placas.Add(placa);
            //                Console.WriteLine("Insira a hora de entrada");
            //                double horaE = Convert.ToDouble(Console.ReadLine());
            //                horaEntrada.Add(horaE);
            //                cheio = false;
            //                break;
            //            }
            //        }
            //        if (cheio)
            //        {
            //            Console.WriteLine("Está cheio");
            //        }
            //    }
            //    else if (opcao == 2)
            //    {
            //        Console.WriteLine("Qual a placa?");
            //        string placa = Console.ReadLine();
            //        bool naoEncontrado = true;
            //        for (int i = 0; i < 10; i++)
            //        {
            //            if (placas[i] == placa)
            //            {
            //                Console.WriteLine("Insira a hora de saída");
            //                double horaS = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Valor final: " + (horaS - horaEntrada[i]) * 4);
            //                placas.Remove(placa);
            //                naoEncontrado = false;
            //                break;
            //            }
            //        }
            //        if (naoEncontrado)
            //        {
            //            Console.WriteLine("Placa não encontrada");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opção inválida");
            //    }
            //}















        }



        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        // exec 06 lista 01
        public static int BuscaEmLista(List<string> elementos, string verificador)
        {
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i] == verificador)
                {
                    return i;
                }
            }
            return -1;
        }
        // exec 06 lista 01
        public static void MostraLista(List<string> elementos)
        {
            foreach (var item in elementos)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

