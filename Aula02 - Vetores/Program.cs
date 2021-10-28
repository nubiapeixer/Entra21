using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Núbia
            //ARRAY/VETOR

            // exec 01 CORRIGIDO

            //int[] vet = new int[2];
            //Console.WriteLine("Insira 2 valores que te digo qual o maior");
            ////vet[0] = int.Parse(Console.ReadLine());
            ////vet[1] = Convert.ToInt32(Console.ReadLine());
            //for(int i = 0; i < vet.Length; i++)
            //{
            //    vet[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //if (vet[0] > vet[1])
            //{
            //    Console.WriteLine(vet[0]);
            //}
            //else
            //{
            //    Console.WriteLine(vet[1]);
            //}

            // exec 02
            //double[] nota = new double[3];

            //Console.WriteLine("Insira as 3 notas do aluno para cálculo da média:");
            //for(int i = 0; i < nota.Length; i++)
            //{
            //    nota[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //double media = (nota[0] + nota[1] + nota[2]) / 3;
            //Console.WriteLine("A média das notas do aluno é: " + media);

            // exec 03
            //int[] valor = new int[3];

            //Console.WriteLine("Insira 3 valores e te direi se são iguais ou qual o maior");
            //for(int i = 0; i < valor.Length; i++)
            //{
            //    valor[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //if (valor[0] == valor[1] && valor[0] == valor[2])
            //{
            //    Console.WriteLine("Os valores são iguais");
            //}
            //else if(valor[0] >= valor[1] && valor[0] >= valor[2])
            //{
            //    Console.WriteLine("O maior valor é: " + valor[0]);
            //}
            //else if(valor[1] >= valor[0] && valor[1] >= valor[2])
            //{
            //    Console.WriteLine("O maior valor é: " + valor[1]);
            //}
            //else
            //{
            //    Console.WriteLine("O maior valor é " + valor[2]);
            //}
            
            // exec 04
            //string[] nomes = new string[3];

            //while (true)
            //{
            //    Console.WriteLine("Insira 3 nomes");
            //    for (int i = 0; i < nomes.Length; i++)
            //    {
            //        Console.WriteLine("Nome " + (i + 1) + ":");
            //        nomes[i] = Console.ReadLine();
            //    }
            //    Console.WriteLine("Deseja ver a lista?\ns - sim | n - não");
            //    string escolha = Console.ReadLine();
            //    if (escolha == "s")
            //    {
            //        for (int i = 0; i < nomes.Length; i++)
            //        {
            //            Console.WriteLine("Nome " + (i + 1) + ": " + nomes[i]);
            //        }
            //    }

            //}

            // exec 05
            //int[] valores = new int[5];
            //Console.WriteLine("Insira 5 valores inteiros");

            //for(int i = 0; i < valores.Length; i++)
            //{
            //    valores[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("A soma dos valores é igual a:");
            //Console.WriteLine(valores[0] + valores[1] + valores[2] + valores[3] + valores[4]);

            // exec 06 CORRIGIDO
            //string[] nomes = new string[4];
            //string[] cpf = new string[4];
            //int[] idade = new int[4];

            //while (true)
            //{
            //    for (int i = 0; i < nomes.Length; i++)
            //    {
            //        Console.WriteLine("------------------//----------------");
            //        Console.WriteLine("Aluno : " + (i + 1));
            //        Console.WriteLine("Nome : " + nomes[i]);
            //        Console.WriteLine("CPF : " + cpf[i]);
            //        Console.WriteLine("Idade : " + idade[i]);
            //    }
            //    Console.WriteLine("Qual aluno deseja preencher?");
            //    int escolha = Convert.ToInt32(Console.ReadLine());
            //    // escolha--;
            //    Console.WriteLine("Insira o nome");
            //    nomes[escolha - 1] = Console.ReadLine();
            //    Console.WriteLine("Insira o CPF");
            //    cpf[escolha - 1] = Console.ReadLine();
            //    Console.WriteLine("Insira a idade");
            //    idade[escolha - 1] = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Deseja sair?\n1 - sim | 2 - não");
            //    escolha = Convert.ToInt32(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        break;
            //    }
            //}

            // exec 07 CORRIGIDO
            //string[] placa = new string[10]; // null
            //double[] hrEntrada = new double[10];
            //for (int i = 0; i < placa.Length; i++)
            //{
            //    placa[i] = ""; // preenche com string vazio ao invés de null
            //}

            //while (true)
            //{
            //    Console.WriteLine("O veículo está entrando ou saindo?");
            //    Console.WriteLine("e - entrando | s - saindo");
            //    string escolha = Console.ReadLine();

            //    if (escolha == "e")
            //    {
            //        bool cheio = true; // bool tipo de variável que armazena falso e verdadeiro, utilizado pra não ficar printando vários "Está cheio"
            //        for (int i = 0; i < placa.Length; i++)
            //        {
            //            if (placa[i] == "")
            //            {
            //                Console.WriteLine("Insira a placa do veículo");
            //                placa[i] = Console.ReadLine();
            //                Console.WriteLine("Insira a hora de entrada");
            //                hrEntrada[i] = Convert.ToDouble(Console.ReadLine());
            //                cheio = false; // não entra no if (cheio)
            //                break; // pra ele não ir pra outra placa (for)
            //            }
            //        }
            //        if (cheio) // cheio true
            //        {
            //            Console.WriteLine("Está cheio");
            //        }
            //    }
            //    else if (escolha == "s")
            //    {
            //        Console.WriteLine("Qual a placa?");
            //        string saindo = Console.ReadLine();
            //        bool encontrado = true;
            //        for (int i = 0; i < placa.Length; i++)
            //        {
            //            if (placa[i] == saindo)
            //            {
            //                placa[i] = "";
            //                Console.WriteLine("Insira a hora de saída");
            //                double hrSaida = Convert.ToDouble(Console.ReadLine());
            //                Console.WriteLine("Valor Final: " + (hrSaida - hrEntrada[i]) * 3.5);
            //                encontrado = false;
            //                break;
            //            }
            //        }
            //        if (encontrado) // encontrado for true
            //        {
            //            Console.WriteLine("Placa não encontrada");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opção inválida");
            //    }
            //}
            //exercícios PARTE 02 VETOR

            // exec 01
            //int[] vetor1 = new int[5];
            //int[] vetor2 = new int[5];
            //int[] soma = new int[5];


            //for(int i = 0; i < vetor1.Length; i++)
            //{
            //    Console.WriteLine("Insira 2 valores");
            //    Console.WriteLine("Posição " + (i + 1) + ":");
            //    vetor1[i] = Convert.ToInt32(Console.ReadLine());
            //    vetor2[i] = Convert.ToInt32(Console.ReadLine());
            //    soma[i] = vetor1[i] + vetor2[i];
            //}
            //Console.WriteLine();
            //Console.WriteLine("A soma dos valores de mesma posição é igual a:");
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    Console.WriteLine("Posição " + (i + 1) + ":");
            //    Console.WriteLine(soma[i]);
            //}

            // exec 02
            //string[] produtos = new string[5];
            //string[] compras = new string[10];
            //double valorTotal = 0;

            //produtos[0] = "cuca";
            //produtos[1] = "pão";
            //produtos[2] = "pastel";
            //produtos[3] = "coxinha";
            //produtos[4] = "bolo";

            //string escolha = Console.ReadLine();

            //while (true)
            //{
            //    Console.WriteLine("Escolha os produtos para colocar em seu carrinho");
            //    Console.WriteLine("1 - Cuca R$ 10,00");
            //    Console.WriteLine("2 - Pão R$ 1,00");
            //    Console.WriteLine("3 - Pastel R$ 5,00");
            //    Console.WriteLine("4 - Coxinha R$ 4,00");
            //    Console.WriteLine("5 - Bolo R$ 35,00");
            //    Console.WriteLine("6 - Para solicitar o valor atual da compra");
            //    Console.WriteLine("acabou ou fim para encerrar a compra");
            //    Console.WriteLine();

            //    for (int i = 0; i < compras.Length; i++)
            //    {
            //        Console.WriteLine("Produto " + (i + 1) + " :" + compras[i]);
            //    }
            //    for (int i = 0; i < compras.Length; i++)
            //    {


            //        if (escolha == "1")
            //        {
            //            compras[i] = produtos[0];
            //            valorTotal = valorTotal + 10;

            //        }
            //        else if (escolha == "2")
            //        {
            //            compras[i] = produtos[1];
            //            valorTotal = valorTotal + 1;

            //        }
            //        else if (escolha == "3")
            //        {
            //            compras[i] = produtos[2];
            //            valorTotal = valorTotal + 5;

            //        }
            //        else if (escolha == "4")
            //        {
            //            compras[i] = produtos[3];
            //            valorTotal = valorTotal + 4;

            //        }
            //        else if (escolha == "5")
            //        {
            //            compras[i] = produtos[4];
            //            valorTotal = valorTotal + 35;

            //        }
            //        else if (escolha == "acabou" || escolha == "fim")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine(valorTotal);
            //            break;
            //        }
            //    }

            //}
            //Console.WriteLine(valorTotal);


            // exec 03
            //int[] vetor1 = new int[10];
            //int[] vetor2 = new int[10];
            //int[] vetor3 = new int[10];
            //int[] maior = new int[10];
            //int soma = 0;

            //for(int i = 0; i < vetor1.Length; i++)
            //{
            //    Random ran = new Random();
            //    vetor1[i] = ran.Next(0, 30);
            //    Console.WriteLine(vetor1[i]);
            //    vetor2[i] = ran.Next(0, 30);
            //    Console.WriteLine(vetor2[i]);
            //    vetor3[i] = ran.Next(0, 30);
            //    Console.WriteLine(vetor3[i]);
            //    Console.WriteLine("--------------//-----------------");

            //    if (vetor1[i] >= vetor2[i] && vetor1[i] >= vetor3[i])
            //    {
            //        maior[i] = vetor1[i];
            //    }
            //    else if (vetor2[i] >= vetor1[i] && vetor2[i] >= vetor3[i])
            //    {
            //        maior[i] = vetor2[i];
            //    }
            //    else
            //    {
            //        maior[i] = vetor3[i];
            //    }
            //}

            //for(int i = 0; i < maior.Length; i++)
            //{
            //    soma = soma + maior[i];
            //}
            //Console.WriteLine("A soma dos valores é igual a " + soma);

            // exec 04 - criptografia de Cesar
            //int numCar, num;
            //string senha, senhaCrip = "";

            //while (true)
            //{
            //    Console.WriteLine("Digite a senha que deseja criptografar");
            //    senha = Console.ReadLine();
            //    numCar = senha.Length;
            //    if (senha.Length > 10)
            //    {
            //        Console.WriteLine("Senha inválida, digite uma senha com até 10 caracteres");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //for (int i = 0; i <senha.Length; i++)
            //{
            //    num = Convert.ToInt32(senha[i]) + 3;
            //    senhaCrip = senhaCrip + Convert.ToChar(num);
            //}

            //Console.WriteLine(senhaCrip);

            // exec 04 - com vetor
            //int numLetras;
            //string senha;

            //while (true)
            //{
            //    Console.WriteLine("Digite a senha que deseja criptografar");
            //    senha = Console.ReadLine();

            //    if (senha.Length > 10)
            //    {
            //        Console.WriteLine("Senha inválida. Digite uma senha com até 10 caracteres");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //char[] crip = new char[senha.Length];
            //for (int i = 0; i < senha.Length; i++)
            //{
            //    numLetras = Convert.ToInt32(senha[i]);
            //    crip[i] = Convert.ToChar((numLetras + 3));
            //    Console.Write(crip[i]);
            //}

            // exec 05 - com vetor
            //int numLetras;
            //string senha;

            //while (true)
            //{
            //    Console.WriteLine("Digite a senha que deseja criptografar");
            //    senha = Console.ReadLine();

            //    if (senha.Length > 10)
            //    {
            //        Console.WriteLine("Senha inválida. Digite uma senha com até 10 caracteres");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //char[] crip = new char[senha.Length];
            //for (int i = 0; i < senha.Length; i++)
            //{
            //    numLetras = (int)senha[i];
            //    crip[i] = (char)(numLetras - 3);
            //    Console.Write(crip[i]);
            //}
            //VETORES - PARTE 03

            // EXEC 01 A
            //int[] numeros = new int[10];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = 10 - i;
            //    Console.Write(numeros[i] + " ");
            //}
            //
        }
    }
}
