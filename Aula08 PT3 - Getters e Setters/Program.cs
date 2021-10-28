using System;
using System.Collections.Generic;

namespace _8._2_OO_pt3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// LISTA 01 OO pt 3

            //// Exec 01 CORRIGIDO
            //Console.WriteLine("Preencha um cachorro");
            //string nome, raca;
            //int idade;
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = Convert.ToInt32(Console.ReadLine());
            //Cachorro cao = new Cachorro(nome, raca, idade);

            //Console.WriteLine("---------------//------------");
            //Console.WriteLine(cao.GetNome());
            //Console.WriteLine(cao.GetRaca());
            //Console.WriteLine(cao.GetIdade());

            //// Extra usando Setters
            //Console.WriteLine("---------------//------------");
            //Console.WriteLine("Insira um doguinho");
            //nome = Console.ReadLine();
            //raca = Console.ReadLine();
            //idade = Convert.ToInt32(Console.ReadLine());
            //cao.SetNome(nome);
            //cao.SetRaca(raca);
            //cao.SetIdade(idade);
            //Console.WriteLine("---------------//------------");
            //Console.WriteLine(cao.GetNome());
            //Console.WriteLine(cao.GetRaca());
            //Console.WriteLine(cao.GetIdade());

            //// Exec 02 
            //Console.WriteLine("Preencha os dados de um carro");
            //string nome, marca, anoDeFabricacao, placa;

            //Carro car = new Carro("", "", "", "");
            //Console.WriteLine("Insira o nome");
            //nome = Console.ReadLine();
            //Console.WriteLine("Insira a marca");
            //marca = Console.ReadLine();
            //Console.WriteLine("Insira o ano de fabricação");
            //anoDeFabricacao = Console.ReadLine();
            //Console.WriteLine("Insira a placa");
            //placa = Console.ReadLine();

            //car.SetNome(nome);
            //car.SetMarca(marca);
            //car.SetAnoDeFabricacao(anoDeFabricacao);
            //car.SetPlaca(placa);
            //Console.WriteLine("------------------//--------------");
            //Console.WriteLine(car.GetNome());
            //Console.WriteLine(car.GetMarca());
            //Console.WriteLine(car.GetAnoDeFabricacao());
            //Console.WriteLine(car.GetPlaca());

            //// Exec 03
            //Pessoa pess = new Pessoa("", "", -1);

            //while (true)
            //{
            //    Console.WriteLine("Insira os dados da pessoa:\n");
            //    string nome, cpf;
            //    int idade;
            //    Console.WriteLine("Insira o nome");
            //    nome = Console.ReadLine();
            //    Console.WriteLine("Insira o CPF");
            //    cpf = Console.ReadLine();
            //    Console.WriteLine("Insira a idade");
            //    idade = Convert.ToInt32(Console.ReadLine());

            //    pess.SetNome(nome);
            //    pess.SetCpf(cpf);
            //    pess.SetIdade(idade);
            //    Console.WriteLine("----------------//-------------");
            //    Console.WriteLine(pess.GetNome());
            //    Console.WriteLine(pess.GetCpf());
            //    Console.WriteLine(pess.GetIdade());

            //    Console.WriteLine("Deseja alterar a pessoa inserida?\nS - sim | N - não");
            //    nome = Console.ReadLine().ToLower();
            //    if(nome == "n")
            //    {
            //        break;
            //    }
            //}

            //// Exec 04 CORRIGIDO
            //Cliente cli = new Cliente("", "", new string[1]); // Criando cliente vazio para preenche-lo usando os Setters
            //Console.WriteLine("Preencha o cliente");
            //string nome = Console.ReadLine();
            //string cpf = Console.ReadLine();
            //Console.WriteLine("Insira as consultas");
            //Console.WriteLine("para parar, insira f");

            //// preenche as consultas
            //string[] consultas = new string[10];
            //int indice = 0;
            //while (true)
            //{
            //    string temp = Console.ReadLine();
            //    if (temp == "f")
            //    {
            //        break;
            //    }                
            //    try
            //    {
            //        consultas[indice] = temp;
            //        indice++;
            //    }
            //    catch (Exception)
            //    {

            //        Console.WriteLine("Chegamos ao limite de 10 consultas");
            //        break;
            //    }
            //}
            //cli.SetNome(nome);
            //cli.SetCpf(cpf);
            //cli.SetConsultas(consultas);

            //Console.WriteLine(cli.GetNome());
            //Console.WriteLine(cli.GetCpf());
            ////string[] consultasFinal = cli.GetConsultas(); // Funcionaria
            //for (int i = 0; i < cli.GetConsultas().Length; i++)
            //{
            //    if (cli.GetConsultas()[i] == null) // na hora de preencher se der só enter vai ficar "" e não null
            //    {
            //        break;
            //    }
            //    Console.WriteLine(cli.GetConsultas()[i]);
            //}

            // Exec 05

            ////Exec 06
            //Aluno al = new Aluno("", new double[1]);
            //string nome;
            //Console.WriteLine("Insira o nome do aluno");
            //nome = Console.ReadLine();
            //Console.WriteLine("Quantas notas deseja registrar?");
            //int qtd = Convert.ToInt32(Console.ReadLine());
            //double[] notas = new double[qtd];
            //double media = 0;
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine("Insira a " + (i + 1) + "ª nota");
            //    notas[i] = Convert.ToDouble(Console.ReadLine());
            //    media += notas[i];
            //}
            //al.SetNome(nome);
            //al.SetNotas(notas);
            //media /= qtd;
            //Console.WriteLine(al.GetNome());
            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.Write("Nota nº " + (i + 1) + " --> ");
            //    Console.WriteLine(al.GetNotas()[i]);
            //}
            //Console.WriteLine("Média: " + media);

            //// Exec 07
            //double entrada = 0, saida = 0;
            //double qtdCaixa = 1000;

            //Console.WriteLine("Insira o número do guichê");
            //int guiche = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("1 - Entrada");
            //    Console.WriteLine("2 - Saída");
            //    int opcao = Convert.ToInt32(Console.ReadLine());
            //    if (opcao == 1)
            //    {
            //        Console.WriteLine("Qual o valor de entrada?");
            //        entrada = Convert.ToDouble(Console.ReadLine());
            //        qtdCaixa += entrada;


            //    }
            //    else
            //    {
            //        Console.WriteLine("Qual o valor de saida?");
            //        saida = Convert.ToDouble(Console.ReadLine());
            //        qtdCaixa -= saida;
            //    }
            //}
            //Mercado caixa = new Mercado(0, 0, 0, 0);
            //caixa.SetGuiche(guiche);
            //caixa.SetQtdCaixa(qtdCaixa);
            //caixa.SetEntrada(entrada);
            //caixa.SetSaida(saida);
            //Console.WriteLine("-----------//----------");
            //Console.WriteLine(caixa.GetGuiche());
            //Console.WriteLine(caixa.GetQtdCaixa());
            //if (caixa.GetQtdCaixa() > 1000)
            //{
            //    Console.WriteLine("Deu lucro");
            //}
            //else
            //{
            //    Console.WriteLine("Prejuízo");
            //}
            // LISTA 02 -----------------------------------------------------

            //// Exec01
            //CaixaEletro caixa = new CaixaEletro(0, new string[1]);
            //string[] contasCaixa = new string[3] { "a", "b", "c" };
            //caixa.SetContas(contasCaixa);

            //caixa.SetSaldo(1000);
            //double saldoCaixa = caixa.GetSaldo();

            //ClienteCaixa cli = new ClienteCaixa("", "", 0);
            //cli.SetSaldo(5000);
            //double saldo = cli.GetSaldo();

            //Console.WriteLine("Informe seu nome");
            //string nome = Console.ReadLine();
            //cli.SetNome(nome);

            //while (true)
            //{
            //    while (true)
            //    {
            //        Console.WriteLine("Informe sua conta");
            //        string conta = Console.ReadLine();
            //        cli.SetConta(conta);
            //        int indice = BuscaConta(caixa.GetContas(), cli.GetConta());
            //        if (indice != -1)
            //        {
            //            Console.WriteLine("Quanto deseja sacar?");
            //            double saque = Convert.ToDouble(Console.ReadLine());
            //            if (saque <= saldo && saque <= saldoCaixa)
            //            {
            //                saldo -= saque;
            //                saldoCaixa -= saque;
            //                Console.WriteLine("Saque efetuado");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("A quantia não pode ser sacada");
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Essa conta não existe");
            //        }
            //    }
            //    Console.WriteLine("Para sair digite - sair\nPara continuar - Enter");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "sair")
            //    {
            //        break;
            //    }
            //}

            // Exec 02
            //GerenciaFunc func = new GerenciaFunc(new string[5], new string[5], new string[5], new double[5]);

            //func.SetNome





        }
        public static int BuscaConta(string[] contas, string conta)
        {
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] == conta)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
