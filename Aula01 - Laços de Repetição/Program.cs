using System;

namespace Aula05___Exec_1_a_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Núbia
            //Laços de Repetição

            //exec01 (corrigido)
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //exec 02 (corrigido)
            //for (int i = 0; i < 24; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //exec 03 (corrigido)
            //Console.WriteLine("Insira um número");
            //int a = Convert.ToInt32(Console.ReadLine());

            //for (int i = a; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Insira um número");
            //int a = Convert.ToInt32(Console.ReadLine());
            //while (a > 0)
            //{
            //    a--;
            //    Console.WriteLine(a);
            //}

            //exec 04 (corrigido)
            //int a;
            //Console.WriteLine("Insira um número");
            //a = Convert.ToInt32(Console.ReadLine());

            //if (a >= 0)
            //{
            //    for (int i = a; i >= 0; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    for(int i = a; i < 0; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //exec 05 (corrigido)
            //double numero;
            //string entrada;

            //while (true)
            //{
            //    Console.WriteLine("Insira um número");
            //    Console.WriteLine("Insira exit para sair");

            //    entrada = Console.ReadLine();
            //    if (entrada == "exit")
            //    {
            //        break;
            //    }
            //    numero = Convert.ToDouble(entrada);
            //    if (numero > 24)
            //    {
            //        Console.WriteLine(numero * 2);
            //    }
            //    else if (numero > 0)
            //    {
            //        Console.WriteLine(numero);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Insira novamente");
            //    }
            //}

            //exec 06 (corrigido)

            //string nome = "s", cpf, endereco;

            //while (nome == "s")
            //{
            //    Console.WriteLine("Insira o nome do aluno");
            //    nome = Console.ReadLine();
            //    Console.WriteLine("Insira o CPF do aluno");
            //    cpf = Console.ReadLine();
            //    Console.WriteLine("Insira o endereço do aluno");
            //    endereco = Console.ReadLine();

            //    Console.WriteLine(nome);
            //    Console.WriteLine(cpf);
            //    Console.WriteLine(endereco);

            //    Console.WriteLine("Deseja cadastrar mais um aluno?");
            //    Console.WriteLine("s = sim e n = não");
            //    nome = Console.ReadLine();
            //}

            // (CORRIGIDO) 06
            //string nome, cpf, endereco;

            //while (true)
            //{
            //    Console.WriteLine("Insira o nome");
            //    nome = Console.ReadLine();
            //    Console.WriteLine("Insira o cpf");
            //    cpf = Console.ReadLine();
            //    Console.WriteLine("Insira o endereço");
            //    endereco = Console.ReadLine();
            //    Console.WriteLine("-----------//------------");
            //    Console.WriteLine(nome);
            //    Console.WriteLine(cpf);
            //    Console.WriteLine(endereco);
            //    Console.WriteLine("Deseja cadastrar mais um aluno?");
            //    Console.WriteLine("s = sim | n = não");
            //    nome = Console.ReadLine();

            //    if (nome == "n")
            //    {
            //        break;
            //    }
            //}


            //exec 07

            //double valorFinal = 0;

            //for (int i = 0; i < 30; i++)
            //{
            //    int resultado;
            //    Random ran = new Random();
            //    resultado = ran.Next(1, 7);

            //    if (resultado >= 3)
            //    {
            //        valorFinal = valorFinal + 10.00;
            //    }
            //    else
            //    {
            //        valorFinal = valorFinal - 15.00;
            //    }
            //    Console.WriteLine(resultado);
            //}

            //if (valorFinal >= 0)
            //{
            //    Console.WriteLine("Você ganhou");
            //    Console.WriteLine("{0:c}", valorFinal);
            //}
            //else
            //{
            //    Console.WriteLine("Você perdeu");
            //    Console.WriteLine("{0:c}", valorFinal);
            //}

            // (CORRIGIDO) 07

            //Random ran = new Random();
            //double valorTotal = 0;

            //for(int i = 0; i < 30; i++)
            //{
            //    int dado = ran.Next(1, 7);
            //    if(dado >= 3)
            //    {
            //        Console.WriteLine("V");
            //        valorTotal = valorTotal + 10;
            //    }
            //    else
            //    {
            //        Console.WriteLine("D");
            //        valorTotal += -15;
            //    }
            //}
            //if(valorTotal > 0)
            //{
            //    Console.WriteLine("Você Venceu " + valorTotal);
            //}
            //else
            //{
            //    Console.WriteLine("Você Perdeu " + valorTotal);
            //}

            // 08 (CORRIGIDO)
            //int queijo = 0, macarrao = 0, feijao = 0, presunto = 0, pao = 0, carrinho = 0;

            //Console.WriteLine("Bem vindo ao supermercado Joeslei :");
            //Console.WriteLine("onde os preços são os heróis");

            //while (true)
            //{
            //    Console.WriteLine("Escolha um dos produtos para colocar em seu carrinho");
            //    Console.WriteLine("1 - Queijo 200g Frimesa");
            //    Console.WriteLine("2 - Macarrão 500g KiMassa");
            //    Console.WriteLine("3 - Feijão 1Kg Tio João");
            //    Console.WriteLine("4 - Presunto 200g Presuntop");
            //    Console.WriteLine("5 - Pão Brasileiro Un.");
            //    Console.WriteLine("acabou ou fim para encerrar a compra");
            //    string escolha = Console.ReadLine();

            //    switch (escolha) // pode usar if também
            //    {
            //        case "1":
            //            Console.WriteLine("Quantos queijos você deseja?");
            //            queijo = queijo + Convert.ToInt32(Console.ReadLine());
            //            Console.Clear(); // limpar o console/tela
            //            break;
            //        case "2":
            //            Console.WriteLine("Quantos macarrões você deseja?");
            //            macarrao = macarrao + Convert.ToInt32(Console.ReadLine());
            //            Console.Clear();
            //            break;
            //        case "3":
            //            Console.WriteLine("Quantos Kg de feijão você deseja?");
            //            feijao = feijao + Convert.ToInt32(Console.ReadLine());
            //            Console.Clear();
            //            break;
            //        case "4":
            //            Console.WriteLine("Quantos presuntos você deseja?");
            //            presunto = presunto + Convert.ToInt32(Console.ReadLine());
            //            Console.Clear();
            //            break;
            //        case "5":
            //            Console.WriteLine("Quantos pães você deseja?");
            //            pao = pao + Convert.ToInt32(Console.ReadLine());
            //            Console.Clear();
            //            break;
            //        case "acabou":
            //        case "fim":
            //            Console.WriteLine("Obrigado por comprar na loja");
            //            Console.WriteLine("mais heróica do Brasil");
            //            break;
            //        default:
            //            Console.Clear();
            //            Console.WriteLine("           !!!OPÇÃO INVÁLIDA!!!");
            //            break;
            //    }
            //    if (escolha == "acabou" || escolha == "fim")
            //    {
            //        break;
            //    }
            //}
            //double valorTotal = 0;

            //if (queijo > 3)
            //{
            //    valorTotal += (queijo * 4.5) * 0.9;
            //}
            //else
            //{
            //    valorTotal += queijo * 4.5;
            //}
            //if (macarrao > 3)
            //{
            //    valorTotal += (macarrao * 5) * 0.9;
            //}
            //else
            //{
            //    valorTotal += macarrao * 5;
            //}

            //valorTotal += feijao * 4;
            //valorTotal += presunto * 5.5;
            //valorTotal += pao * 3.75;

            //carrinho = queijo + macarrao + feijao + presunto + pao;
            //if (carrinho > 7)
            //{
            //    valorTotal *= 0.9; //valorTotal = valorTotal * 0.9;
            //}
            //Console.WriteLine("O preço total é :");
            //Console.WriteLine("{0:c}", valorTotal);

            // EXTRASSSSSS

            //exec 01
            //int x, fatorial;
            //Console.WriteLine("Insira um número");
            //x = Convert.ToInt32(Console.ReadLine());
            //fatorial = 1;

            //for(int i = 1; i <= x; i++)
            //{
            //    fatorial = fatorial * i;
            //}
            //Console.WriteLine(fatorial);

            //exec 02
            //Console.WriteLine("Insira um número");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Quantas vezes deve ser somado a ele mesmo?");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int resultado = 0;

            //for (int i = 0; i <= n; i++)
            //{
            //    resultado = resultado + x;
            //}
            //Console.WriteLine(resultado);

            // exec CALCULADORA
            //int numero1, numero2, resultado;
            //string operacao;

            //Console.WriteLine("Digite o primeiro número:");
            //numero1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite a operação:");
            //operacao = Console.ReadLine();

            //Console.WriteLine("Digite o segundo número:");
            //numero2 = Convert.ToInt32(Console.ReadLine());

            //switch (operacao)
            //{
            //    case "+":
            //        resultado = numero1 + numero2;
            //        break;
            //    case "-":
            //        resultado = numero1 - numero2;
            //        break;
            //    case "/":
            //        resultado = numero1 / numero2;
            //        break;
            //    case "*":
            //        resultado = numero1 * numero2;
            //        break;
            //    case "^":
            //        resultado = numero1 * numero1;
            //        break;
            //    default:
            //        Console.WriteLine("Operação inválida");
            //        break;

            //}
            //Console.WriteLine(resultado);
        }
    }
}
