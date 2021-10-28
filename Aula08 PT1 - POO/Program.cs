using System;
using System.Collections.Generic;

namespace _8._OO
{
    class Program
    {
        static void Main(string[] args)
        {

            //// LISTA 1
            //// Exec 01
            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Preencha com os dados da pessoa");
            //pes.nome = Console.ReadLine();
            //pes.idade = Convert.ToInt32(Console.ReadLine());
            //pes.cpf = Console.ReadLine();
            //pes.endereco = Console.ReadLine();
            //Console.WriteLine("--------------//-----------");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.idade);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);

            //// Exec 02
            //// para preencher 2 pode criar vetor ou lista
            //List<Cachorro> dog = new List<Cachorro>();

            //// Preenche a lista
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o dog");
            //    Cachorro cao = new Cachorro(); // cria objeto
            //    cao.nome = Console.ReadLine();
            //    cao.nomeDoDono = Console.ReadLine();
            //    cao.idade = Convert.ToInt32(Console.ReadLine());
            //    dog.Add(cao); // adiciona objeto na lista
            //}
            //Console.WriteLine("-----//-----");
            //// Mostrar a lista, apenas cachorros velhos
            //foreach (var item in dog)
            //{
            //    if (item.idade > 6)
            //    {
            //        Console.WriteLine(item.nome);
            //        Console.WriteLine(item.nomeDoDono);
            //        Console.WriteLine(item.idade);
            //        Console.WriteLine("-----//-----");
            //    }
            //}

            //// exemplo usando for
            //for (int i = 0; i < dog.Count; i++)
            //{
            //    if(dog[i].idade > 6)
            //    {
            //        Console.WriteLine(dog[i].nome);
            //        Console.WriteLine(dog[i].nomeDoDono);
            //        Console.WriteLine(dog[i].idade);
            //        Console.WriteLine("-----//-----");
            //    }
            //}

            //// Exec 03
            //List<PessoasGenero> homem = new List<PessoasGenero>();
            //List<PessoasGenero> mulher = new List<PessoasGenero>();

            //Console.WriteLine("Insira os dados da pessoa");
            //Console.WriteLine();
            //for (int i = 0; i < 5; i++)
            //{
            //    PessoasGenero pess = new PessoasGenero();
            //    Console.WriteLine("Insira o nome");
            //    pess.nome = Console.ReadLine();
            //    Console.WriteLine("Insira a idade");
            //    pess.idade = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Insira o genero F ou M");
            //    pess.genero = Convert.ToChar(Console.ReadLine());
            //    if (pess.genero == 'F')
            //    {
            //        mulher.Add(pess);
            //    }
            //    else
            //    {
            //        homem.Add(pess);
            //    }

            //}

            //// Função:
            //SortManual(mulher);

            //Console.WriteLine("-----------//-----------");
            //Console.WriteLine(mulher[0].nome);
            //Console.WriteLine(mulher[0].idade);

            //SortManual(homem);

            //Console.WriteLine("-----------//-----------");
            //Console.WriteLine(homem[0].nome);
            //Console.WriteLine(homem[0].idade);

            //// Exec 04
            //List<Zoo> animais = new List<Zoo>();
            //Console.WriteLine("Insira os dados dos animais");

            //for (int i = 0; i < 3; i++)
            //{
            //    Zoo animals = new Zoo();
            //    Console.WriteLine("Insira o nome do animal");
            //    animals.nome = Console.ReadLine();
            //    Console.WriteLine("Insira a espécie do animal");
            //    animals.especie = Console.ReadLine();
            //    Console.WriteLine("Insira o tempo que o animal está no Zoo");
            //    animals.tempo = Convert.ToInt32(Console.ReadLine());
            //    animais.Add(animals);
            //}
            //Console.WriteLine();

            //for (int i = 0; i < animais.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (animais[j - 1].tempo > animais[j].tempo)
            //        {
            //            int temp = animais[j].tempo;
            //            animais[j].tempo = animais[j - 1].tempo;
            //            animais[j - 1].tempo = temp;

            //            string tempEspecie = animais[j].especie;
            //            animais[j].especie = animais[j - 1].especie;
            //            animais[j - 1].especie = tempEspecie;

            //            string tempNome = animais[j].nome;
            //            animais[j].nome = animais[j - 1].nome;
            //            animais[j - 1].nome = tempNome;
            //        }
            //    }
            //}

            //for (int i = 0; i < animais.Count; i++)
            //{
            //    Console.WriteLine(animais[i].nome);
            //    Console.WriteLine(animais[i].especie);
            //    Console.WriteLine(animais[i].tempo);
            //    Console.WriteLine("------//-------");
            //}

            //// Exec 05
            //List<ProdutosNoEstoque> produto = new List<ProdutosNoEstoque>();
            //Console.WriteLine("Insira os dados dos produtos:");
            //for (int i = 0; i < 5; i++)
            //{
            //    ProdutosNoEstoque elementos = new ProdutosNoEstoque();
            //    Console.WriteLine("Informe o produto");
            //    elementos.produto = Console.ReadLine();
            //    Console.WriteLine("Informe o valor do produto");
            //    elementos.preco = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Informe quantidade em estoque");
            //    elementos.quantidade = Convert.ToInt32(Console.ReadLine());

            //    produto.Add(elementos);
            //}

            //for (int i = 0; i < produto.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (produto[j - 1].quantidade < produto[j].quantidade)
            //        {
            //            int temp = produto[j].quantidade;
            //            produto[j].quantidade = produto[j - 1].quantidade;
            //            produto[j - 1].quantidade = temp;

            //            string tempNome = produto[j].produto;
            //            produto[j].produto = produto[j - 1].produto;
            //            produto[j - 1].produto = tempNome;

            //            double tempValor = produto[j].preco;
            //            produto[j].preco = produto[j - 1].preco;
            //            produto[j - 1].preco = tempValor;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //foreach (var item in produto)
            //{
            //    Console.WriteLine(item.produto);
            //    Console.WriteLine(item.preco);
            //    Console.WriteLine(item.quantidade);
            //    Console.WriteLine("--------//-------");
            //}

            //// Exec 06
            //List<Funcionarios> aumento = new List<Funcionarios>();
            //Console.WriteLine("Informe os dados dos funcionários");
            //for (int i = 0; i < 3; i++)
            //{
            //    Funcionarios pess = new Funcionarios();
            //    Console.WriteLine("Insira o nome do funcionário");
            //    pess.nomeFuncionario = Console.ReadLine();
            //    Console.WriteLine("Insira o salário");
            //    pess.salario = Convert.ToDouble(Console.ReadLine());
            //    if(pess.salario < 1500)
            //    {
            //        pess.salario = pess.salario * 1.2;
            //    }
            //    Console.WriteLine("Insira o cpf do funcionário");
            //    pess.cpf = Console.ReadLine();
            //    aumento.Add(pess);
            //}
            //for (int i = 0; i < aumento.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if(aumento[j - 1].salario > aumento[j].salario)
            //        {
            //            double tempSalario = aumento[j].salario;
            //            aumento[j].salario = aumento[j - 1].salario;
            //            aumento[j - 1].salario = tempSalario;

            //            string tempNome = aumento[j].nomeFuncionario;
            //            aumento[j].nomeFuncionario = aumento[j - 1].nomeFuncionario;
            //            aumento[j - 1].nomeFuncionario = tempNome;

            //            string tempCPF = aumento[j].cpf;
            //            aumento[j].cpf = aumento[j - 1].cpf;
            //            aumento[j - 1].cpf = tempCPF;
            //        }
            //    }
            //}
            //Console.WriteLine();

            //foreach (var item in aumento)
            //{
            //    Console.WriteLine("---------//----------");
            //    Console.WriteLine(item.nomeFuncionario);
            //    Console.WriteLine(item.salario);
            //    Console.WriteLine(item.cpf);                
            //}

            //// Exec 07
            //List<Alunos> media = new List<Alunos>();
            //Console.WriteLine("Insira os dados de cada aluno");

            //for (int i = 0; i < 3; i++)
            //{
            //    Alunos notas = new Alunos();
            //    Console.WriteLine("Insira o nome do aluno");
            //    notas.nomeAluno = Console.ReadLine();
            //    Console.WriteLine("Insira a 1ª nota");
            //    notas.nota1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Insira a 2ª nota");
            //    notas.nota2 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Insira a 3ª nota");
            //    notas.nota3 = Convert.ToDouble(Console.ReadLine());
            //    double resultado = Media(notas.nota1, notas.nota2, notas.nota3);
            //    Console.WriteLine("Média do aluno: " + resultado);
            //    if(resultado > 7)
            //    {
            //        Console.WriteLine("Aprovado");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reprovado");
            //    }

            //}

            //// -----------------------------------------------------------------
            //// LISTA 02

            //// Exec 01 --- NÃO DEU CERTO
            //List<Vip> clientes = new List<Vip>();
            //Console.WriteLine("Insira os dados dos clientes");
            //for (int i = 0; i < 4; i++)
            //{
            //    Vip pessoa = new Vip();
            //    Console.WriteLine("Insira o nome do cliente");
            //    pessoa.nomeCliente = Console.ReadLine();
            //    Console.WriteLine("Insira o cpf do cliente");
            //    pessoa.cpf = Console.ReadLine();
            //    Console.WriteLine("É vip? \n1- sim | 2 - não");
            //    pessoa.vip = Convert.ToInt32(Console.ReadLine());
            //    if (pessoa.vip == 1)
            //    {
            //        pessoa.nomeCliente = pessoa.nomeCliente + " ;)";
            //    }
            //    clientes.Add(pessoa);
            //}


            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        if (clientes[j - 1].vip > clientes[j].vip)
            //        {
            //            string tempNome = clientes[j].nomeCliente;
            //            clientes[j].nomeCliente = clientes[j - 1].nomeCliente;
            //            clientes[j - 1].nomeCliente = tempNome;

            //            string tempCPF = clientes[j].cpf;
            //            clientes[j].cpf = clientes[j - 1].cpf;
            //            clientes[j - 1].cpf = tempCPF;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //foreach (var item in clientes)
            //{
            //    Console.WriteLine("----------//-----------");
            //    Console.WriteLine(item.nomeCliente);
            //    Console.WriteLine(item.cpf);
            //}

            //// Exec 02            
            //List<Estacionamento> placas = new List<Estacionamento>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Estacionamento carro = new Estacionamento();
            //    Console.WriteLine("Insira a placa do carro");
            //    carro.placa = Console.ReadLine();
            //    Console.WriteLine("Insira o nome do dono");
            //    carro.nome = Console.ReadLine();
            //    placas.Add(carro);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < placas.Count; i++)
            //{
            //    Console.WriteLine("Vaga n° " + (i + 1));
            //    Console.WriteLine(placas[i].placa);
            //    Console.WriteLine(placas[i].nome);
            //    Console.WriteLine("------------//-------------");
            //}

        }

        //LISTA 1
        //Exec 03
        public static List<PessoasGenero> SortManual(List<PessoasGenero> ordenar)
        {
            for (int i = 0; i < ordenar.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (ordenar[j - 1].idade < ordenar[j].idade)
                    {
                        int temp = ordenar[j].idade;
                        ordenar[j].idade = ordenar[j - 1].idade;
                        ordenar[j - 1].idade = temp;

                        string tempNome = ordenar[j].nome;
                        ordenar[j].nome = ordenar[j - 1].nome;
                        ordenar[j - 1].nome = tempNome;
                    }
                }
            }
            return ordenar;
        }
        // Exec 07
        public static double Media(double nota1, double nota2, double nota3)
        {
            return ((nota1 + nota2 + nota3) / 3);
        }




    }
}
