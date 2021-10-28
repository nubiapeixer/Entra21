using System;
using System.Collections.Generic;

namespace _8._1_OO_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// LISTA 1
            //// Exec 01

            //Console.WriteLine("Insira uma pessoa");
            //string nome, cpf, endereco;
            //int idade;
            //nome = Console.ReadLine();
            //cpf = Console.ReadLine();
            //endereco = Console.ReadLine();
            //idade = Convert.ToInt32(Console.ReadLine());

            //Pessoa pes = new Pessoa(nome, cpf, endereco, idade);

            //Console.WriteLine("-------------------//------------------");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);
            //Console.WriteLine(pes.idade);

            //// Exec 02
            //List<SerHumano> pessoas = new List<SerHumano>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira uma pessoa");
            //    string nome = Console.ReadLine();
            //    int idade = Convert.ToInt32(Console.ReadLine());
            //    // H = Homem | M = Mulher
            //    string genero = Console.ReadLine().ToLower(); // Tudo que o usuário inserir vai ficar em letra minúscula
            //    SerHumano ser = new SerHumano(nome, idade, genero);
            //    pessoas.Add(ser);

            //}

            //int indiceHome = -1, indiceMulh = -1;
            //int idadeHome = -1, idadeMulh = -1;

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if(pessoas[i].genero == "m")
            //    {
            //        if(idadeMulh < pessoas[i].idade)
            //        {
            //            indiceMulh = i;
            //            idadeMulh = pessoas[i].idade;
            //        }
            //    }
            //    if (pessoas[i].genero == "h") // usa outro if ao invés de else, porque pode ter outras opções
            //    {
            //        if(idadeHome < pessoas[i].idade)
            //        {
            //            indiceHome = i;
            //            idadeHome = pessoas[i].idade;
            //        }
            //    }
            //}
            //Console.WriteLine("----------------//--------------------");
            //try
            //{
            //    Console.WriteLine("Mulher mais velha");
            //    Console.WriteLine(pessoas[indiceMulh].nome);
            //    Console.WriteLine(pessoas[indiceMulh].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Não existe mulheres na lista");                
            //}
            //Console.WriteLine("----------------//--------------------");
            //try
            //{
            //    Console.WriteLine("Homem mais velho");
            //    Console.WriteLine(pessoas[indiceHome].nome);
            //    Console.WriteLine(pessoas[indiceHome].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Não existe homens na lista");                
            //}

            //// Exec 03 
            //List<Cachorros> dog = new List<Cachorros>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira os dados do cachorro");
            //    Console.WriteLine();
            //    Console.WriteLine("Insira o nome");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Insira o nome do dono");
            //    string nomeDoDono = Funcoes.CR();
            //    Console.WriteLine("Insira a idade do cachorro");
            //    int idade = Funcoes.CRI();
            //    Cachorros caes = new Cachorros(nome, nomeDoDono, idade);
            //    dog.Add(caes);
            //}
            //for (int i = 0; i < dog.Count; i++)
            //{
            //    if(dog[i].idade > 4)
            //    {
            //        Console.WriteLine("------------//----------");
            //        Console.WriteLine(dog[i].nome);
            //        Console.WriteLine(dog[i].nomeDoDono);
            //        Console.WriteLine(dog[i].idade);
            //    }
            //}

            //// Exec 04
            //List<Produto> mercado = new List<Produto>();
            //Console.WriteLine("Dados dos produtos");
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Informe o produto");
            //    string prod = Funcoes.CR();
            //    Console.WriteLine("Insira o preço do produto");
            //    double preco = Funcoes.CRD();
            //    Console.WriteLine("Insira a quantidade de produto no estoque");
            //    int quantidade = Funcoes.CRI();
            //    Produto produtos = new Produto(prod, preco, quantidade);
            //    mercado.Add(produtos);
            //}

            //mercado = OrdenaMaior(mercado);

            //for (int i = 0; i < mercado.Count; i++)
            //{
            //    Console.WriteLine("----------------//------------");
            //    Console.WriteLine(mercado[i].produto);
            //    Console.WriteLine(mercado[i].preco);
            //    Console.WriteLine(mercado[i].quantidade);
            //}

            //// Exec 05
            //List<Zoologico> animais = new List<Zoologico>();
            //Console.WriteLine("Dados dos animais");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Insira o nome do animal");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Insira a espécie do animal");
            //    string especie = Funcoes.CR();
            //    Console.WriteLine("Insira o tempo do animal no Zoológico");
            //    int tempo = Funcoes.CRI();
            //    Zoologico bichos = new Zoologico(nome, especie, tempo);
            //    animais.Add(bichos);
            //}
            //for (int i = 0; i < animais.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (animais[j - 1].tempo > animais[j].tempo)
            //        {
            //            int temp = animais[j].tempo;
            //            animais[j].tempo = animais[j - 1].tempo;
            //           animais[j - 1].tempo = temp;

            //            string tempNome = animais[j].nome;
            //            animais[j].nome = animais[j - 1].nome;
            //           animais[j - 1].nome = tempNome;

            //            string tempEspecie = animais[j].especie;
            //            animais[j].especie = animais[j - 1].especie;
            //            animais[j - 1].especie = tempEspecie;
            //        }
            //    }
            //}
            //for (int i = 0; i < animais.Count; i++)
            //{
            //    Console.WriteLine("-------------------//----------------");
            //    Console.WriteLine(animais[i].nome);
            //    Console.WriteLine(animais[i].especie);
            //    Console.WriteLine(animais[i].tempo);
            //}

            //// Exec 06
            //List<Empregados> empresa = new List<Empregados>();
            //Console.WriteLine("Dados funcionários");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Informe o nome do empregado");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Informe o salário do empregado");
            //    double salario = Funcoes.CRD();
            //    if (salario < 1500)
            //    {
            //        salario = Empregados.Aumento(salario);
            //        //salario = salario * 1.2;
            //    }
            //    Console.WriteLine("Informe  CPF do empregado");
            //    string cpf = Funcoes.CR();
            //    Empregados ajuste = new Empregados(nome, salario, cpf);
            //    empresa.Add(ajuste);
            //}

            //for (int i = 0; i < empresa.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (empresa[j - 1].salario > empresa[j].salario)
            //        {
            //            double tempSalario = empresa[j].salario;
            //            empresa[j].salario = empresa[j - 1].salario;
            //            empresa[j - 1].salario = tempSalario;

            //            string tempNome = empresa[j].nome;
            //            empresa[j].nome = empresa[j - 1].nome;
            //            empresa[j - 1].nome = tempNome;

            //            string tempCPF = empresa[j].cpf;
            //            empresa[j].cpf = empresa[j - 1].cpf;
            //            empresa[j - 1].cpf = tempCPF;
            //        }
            //    }
            //}

            //for (int i = 0; i < empresa.Count; i++)
            //{
            //    Console.WriteLine("-------------------//----------------");
            //    Console.WriteLine(empresa[i].nome);
            //    Console.WriteLine(empresa[i].salario);
            //    Console.WriteLine(empresa[i].cpf);
            //}

            //// Exec 07             
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o nome do aluno");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Insira a 1ª nota");
            //    double nota1 = Funcoes.CRD();
            //    Console.WriteLine("Insira a 2ª nota");
            //    double nota2 = Funcoes.CRD();
            //    Console.WriteLine("Insira a 3ª nota");
            //    double nota3 = Funcoes.CRD();                
            //    double mediaFinal = Alunos.Media(nota1, nota2, nota3);
            //    Console.WriteLine("Média do aluno: " + mediaFinal);
            //    if (mediaFinal > 7)
            //    {
            //        Console.WriteLine("Aprovado!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprovado!");
            //    }
            //    Console.WriteLine();
            //}

            //// LISTA 2 -----------------------------------

            ////Exec 01 
            //List<Clientes> cliente = new List<Clientes>();
            //Console.WriteLine("Dados dos clientes:");
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira o nome do cliente");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Insira o CPF");
            //    string cpf = Funcoes.CR();
            //    Console.WriteLine("Cliente VIP?\n1 - sim | 2 - não");
            //    int vip = Funcoes.CRI();
            //    if (vip == 1)
            //    {
            //        nome = nome + " VIP";
            //    }
            //    Clientes dadosCliente = new Clientes(nome, cpf, vip);
            //    cliente.Add(dadosCliente);
            //}
            //for (int i = 0; i < cliente.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (cliente[j - 1].vip > cliente[j].vip)
            //        {
            //            string tempNome = cliente[j].nome;
            //            cliente[j].nome = cliente[j - 1].nome;
            //            cliente[j - 1].nome = tempNome;

            //            string tempCPF = cliente[j].cpf;
            //            cliente[j].cpf = cliente[j - 1].cpf;
            //            cliente[j - 1].cpf = tempCPF;
            //        }
            //    }
            //}
            //foreach (var item in cliente)
            //{
            //    Console.WriteLine(item.nome);
            //    Console.WriteLine(item.cpf);
            //}

            //// Exec 02
            //List<Estacionamento> carro = new List<Estacionamento>();
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine("Insira o nome");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Insira a placa");
            //    string placa = Funcoes.CR();
            //    Estacionamento vagas = new Estacionamento(nome, placa);
            //    carro.Add(vagas);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < carro.Count; i++)
            //{
            //    Console.WriteLine("------//------");
            //    Console.WriteLine("Vaga n° " + (i + 1));
            //    Console.WriteLine(carro[i].nome);
            //    Console.WriteLine(carro[i].placa);
            //}

            //// Exec 03
            //List<Hotel> quartos = new List<Hotel>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Informe o nome do hotel");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Informe a quantidade de quartos de solteiro");
            //    int quartoSolteiro = Funcoes.CRI();
            //    Console.WriteLine("Informe a quantidade de quartos de casal");
            //    int quartoCasal = Funcoes.CRI();

            //    Hotel total = new Hotel(nome, quartoSolteiro, quartoCasal);

            //    quartos.Add(total);
            //}

            //for (int i = 0; i < quartos.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if ((quartos[j - 1].qtdSolteiro + (quartos[j - 1].qtdCasal*2)) < (quartos[j].qtdSolteiro + (quartos[j].qtdCasal*2)))
            //        {
            //            string tempNome = quartos[j].nome;
            //            quartos[j].nome = quartos[j - 1].nome;
            //            quartos[j - 1].nome = tempNome;

            //            int tempS = quartos[j].qtdSolteiro;
            //            quartos[j].qtdSolteiro = quartos[j - 1].qtdSolteiro;
            //            quartos[j - 1].qtdSolteiro = tempS;

            //            int tempC = quartos[j].qtdCasal;
            //            quartos[j].qtdCasal = quartos[j - 1].qtdCasal;
            //            quartos[j - 1].qtdCasal = tempC;
            //        }
            //    }
            //}
            //for (int i = 0; i < quartos.Count; i++)
            //{
            //    Console.WriteLine("---------------//------------");
            //    Console.WriteLine(quartos[i].nome);
            //    Console.WriteLine(quartos[i].qtdSolteiro);
            //    Console.WriteLine(quartos[i].qtdCasal);
            //    Console.WriteLine();
            //    Console.WriteLine("Total de vagas: " + (quartos[i].qtdSolteiro + (quartos[i].qtdCasal*2)));

            //}

            //// Exec 04
            //List<Adulto> pessoas = new List<Adulto>();
            //for (int i = 0; i < 7; i++)
            //{                
            //    Console.WriteLine("Insira o nome");
            //    string nome = Funcoes.CR();
            //    Console.WriteLine("Insira a idade");
            //    int idade = Funcoes.CRI();

            //    Adulto pess = new Adulto(nome, idade);

            //    bool adultoConfere = true;
            //    adultoConfere = Adulto.ConfereAdulto(idade);
            //    if (adultoConfere == true)
            //    {
            //        pessoas.Add(pess);
            //    }                
            //}
            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (pessoas[j - 1].idade < pessoas[j].idade)
            //        {
            //            string tempNome = pessoas[j].nome;
            //            pessoas[j].nome = pessoas[j - 1].nome;
            //            pessoas[j - 1].nome = tempNome;

            //            int tempIdade = pessoas[j].idade;
            //            pessoas[j].idade = pessoas[j - 1].idade;
            //            pessoas[j - 1].idade = tempIdade;                        
            //        }
            //    }
            //}

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    Console.WriteLine("-----------//---------");
            //    Console.WriteLine(pessoas[i].nome);
            //    Console.WriteLine(pessoas[i].idade);
            //}

            //// LISTA 03 -------------------------------------------------

            ////Exec 01
            List<Vagas> emprego = new List<Vagas>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Infome o nome da vaga");
                string nome = Funcoes.CR();
                Console.WriteLine("Informe a função");
                string funcao = Funcoes.CR();
                Console.WriteLine("Informe o salário");
                double salario = Funcoes.CRD();

                Vagas empresa = new Vagas(nome, funcao, salario);
                emprego.Add(empresa);
            }
            Console.WriteLine();
            Console.WriteLine("Como você deseja ver as vagas?\n1 - nome\n2 - Função\n3 - Salário");
            int escolha = Funcoes.CRI();

            Console.WriteLine();
            Console.WriteLine("-----------//-----------");
            if(escolha == 1)
            {
                for (int i = 0; i < emprego.Count; i++)
                {
                    Console.WriteLine(emprego[i].nome);
                    Console.WriteLine(emprego[i].funcao);
                    Console.WriteLine(emprego[i].salario);
                    Console.WriteLine("-----------//-----------");
                }
            }
            else if (escolha == 2)
            {
                for (int i = 0; i < emprego.Count; i++)
                {
                    Console.WriteLine(emprego[i].funcao);
                    Console.WriteLine(emprego[i].nome);                    
                    Console.WriteLine(emprego[i].salario);
                    Console.WriteLine("-----------//-----------");
                }
            }
            else
            {
                for (int i = 0; i < emprego.Count; i++)
                {
                    Console.WriteLine(emprego[i].salario);
                    Console.WriteLine(emprego[i].nome);
                    Console.WriteLine(emprego[i].funcao);
                    Console.WriteLine("-----------//-----------");
                }
                
            }




        }
        // Lista 01
        // Exec 04
        public static List<Produto> OrdenaMaior(List<Produto> mercado)
        {
            for (int i = 0; i < mercado.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (mercado[j - 1].quantidade < mercado[j].quantidade)
                    {
                        int temp = mercado[j].quantidade;
                        mercado[j].quantidade = mercado[j - 1].quantidade;
                        mercado[j - 1].quantidade = temp;

                        string tempProd = mercado[j].produto;
                        mercado[j].produto = mercado[j - 1].produto;
                        mercado[j - 1].produto = tempProd;

                        double tempPreco = mercado[j].preco;
                        mercado[j].preco = mercado[j - 1].preco;
                        mercado[j - 1].preco = tempPreco;
                    }
                }
            }
            return mercado;
        }


    }
}
