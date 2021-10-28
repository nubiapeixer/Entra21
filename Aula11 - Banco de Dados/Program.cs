using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-II58GDS;Initial Catalog=tempdb;Integrated Security=True");

            // Criando objeto 
            SqlCommand cmd;

            //// LISTA 1 -----------------------------------

            //// Exec 1)
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cliente", i + 1);
            //    string nome = Console.ReadLine();
            //    string cpf = Console.ReadLine();
            //    int idade = Convert.ToInt32(Console.ReadLine());

            //    // idade não tem aspas simples porque é inteiro
            //    string insert = $"INSERT into dbo.Pessoa (Nome,CPF,Idade) values ('{nome}','{cpf}',{idade})";
            //    // preparação do insert
            //    cmd = new SqlCommand(insert, conn);
            //    // ele fica protegido, para isso serve open
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //// complemento: update
            //string update = "UPDATE dbo.Pessoa Set Nome = 'João', Idade = 25 WHERE idPessoa = 1";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //// delete
            //string delete = "DELETE from dbo.Pessoa WHERE Nome = 'Carlos'";
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //// Select
            //string select = "SELECT * FROM dbo.Pessoa";
            //cmd = new SqlCommand(select, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idPessoa"]); // coluna 0
            //    Console.WriteLine(dr["Nome"]); // coluna 1
            //    Console.WriteLine(dr[2]); // acessa a coluna 2
            //    Console.WriteLine(dr["Idade"]); // coluna 3
            //    Console.WriteLine("------------//------------");
            //}
            //dr.Close();
            //conn.Close();

            //// Exec 02)
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cachorro", i + 1);
            //    string nome = Console.ReadLine();
            //    string nomeDoDono = Console.ReadLine();
            //    string telefone = Console.ReadLine();

            //    // usa $ para puxar os valores das variáveis, existem outras formas mais feias
            //    string insert = $"INSERT into dbo.Cachorro (Nome,NomeDoDono,Telefone) values ('{nome}','{nomeDoDono}', '{telefone}')";

            //    // criar/preparar novo comando onde vai executar o 'insert', na conexão 'conn'
            //    cmd = new SqlCommand(insert, conn);

            //    conn.Open();
            //    // executar comando
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

            //string delete = "DELETE from dbo.Cachorro WHERE idCachorro = 1";
            //// "DELETE from dbo.Cachorro WHERE Nome LIKE '%o%'" (vai deletar tudo que tem 'o')
            //// "DELETE from dbo.Cachorro WHERE Salario > 3000"
            //cmd = new SqlCommand(delete, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //// update/atualizar
            //string update = "UPDATE dbo.Cachorro Set Nome='Latino', Telefone='888555' WHERE Nome='Lessi'";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string select = "SELECT * from dbo.Cachorro";
            //cmd = new SqlCommand(select, conn);
            //SqlDataReader dr;
            //conn.Open();
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    //Console.WriteLine(dr[0]);
            //    //Console.WriteLine(dr[1]);
            //    //Console.WriteLine(dr[2]);
            //    //Console.WriteLine(dr[3]);

            //    Cachorro cao = new Cachorro();
            //    cao.Id = Convert.ToInt32(dr["IdCachorro"]); // ou dr[0]
            //    cao.Nome = Convert.ToString(dr[1]);
            //    cao.NomeDoDono = dr["NomeDoDono"].ToString();
            //    cao.Telefone = dr[3].ToString();
            //    cao.MostraCao();
            //}

            //// CORRIGIDO 02)
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o {0}° cachorro", i + 1);
            //    string nome = Console.ReadLine();
            //    string nomeDoDono = Console.ReadLine();
            //    string telefone = Console.ReadLine();

            //    string insert = $"INSERT into dbo.Cachorro (Nome,NomeDoDono,Telefone) values ('{nome}','{nomeDoDono}','{telefone}')";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

            //string select = "SELECT * from dbo.Cachorro";
            //cmd = new SqlCommand(select, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();            

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr["idCachorro"]);
            //    Console.WriteLine(dr[1]);
            //    Console.WriteLine(dr[2]);
            //    Console.WriteLine(dr[3]);
            //    Console.WriteLine("-----------//---------");
            //}
            //dr.Close();
            //conn.Close();

            //// Exec 03) 
            //for (int i = 0; i < 3; i++)
            //{
            //    Funcionario func = new Funcionario();
            //    Console.WriteLine("Insira o {0}° funcionário", i+1);
            //    //string nome = Console.ReadLine();
            //    //string cargo = Console.ReadLine();
            //    //int salario = Convert.ToInt32(Console.ReadLine());
            //    func.Nome = Console.ReadLine();
            //    func.Cargo = Console.ReadLine();
            //    func.Salario = Convert.ToInt32(Console.ReadLine());

            //    string insert = $"INSERT into dbo.Funcionario (Nome,Cargo,Salario) values ('{func.Nome}','{func.Cargo}',{func.Salario})";
            //    //string insert = $"INSERT into dbo.Funcionario (Nome,Cargo,Salario) values ('{nome}','{cargo}',{salario})";
            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}

            //string select = "SELECT * from dbo.Funcionario WHERE Salario > 3000";
            //cmd = new SqlCommand(select, conn);
            //SqlDataReader dr;
            //conn.Open();
            //dr = cmd.ExecuteReader();          

            //while (dr.Read())
            //{
            //    Funcionario func = new Funcionario();
            //    func.Id = Convert.ToInt32(dr["IdFuncionario"]); // ou dr[0]
            //    func.Nome = Convert.ToString(dr[1]);
            //    func.Cargo = dr["Cargo"].ToString();
            //    func.Salario = Convert.ToInt32(dr[3]);
            //    func.MostraFuncionario();

            //    //Console.WriteLine(dr[0]);
            //    //Console.WriteLine(dr[1]);
            //    //Console.WriteLine(dr[2]);
            //    //Console.WriteLine(dr[3]);
            //}
            //dr.Close();
            //conn.Close();

            //// Exec 04)
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Digite o {0}° e-mail", i+1);
            //    string email = Console.ReadLine();

            //    string insert = $"INSERT into dbo.Email (Email) values ('{email}')";

            //    cmd = new SqlCommand(insert, conn);
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //}
            //string select = "SELECT * from dbo.Email WHERE Email LIKE '%outlook%'";
            //cmd = new SqlCommand(select, conn);            

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    Console.WriteLine(dr[0]);
            //    Console.WriteLine(dr[1]);
            //}
            //dr.Close();
            //conn.Close();

            //// Exec 05)
            //// update/atualizar           

            //string update = "UPDATE dbo.Funcionario Set Salario=3000 WHERE Salario < 3000";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //// Exec 06)
            //string delete = "DELETE from dbo.Email WHERE NOT Email LIKE '%outlook%'";
            //cmd = new SqlCommand(delete,conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();            

            //// Exec 07)
            //string update = "UPDATE dbo.Funcionario Set Salario = Salario * 1.2593";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //string update = "UPDATE dbo.Funcionario Set Salario = Salario * 0.9424 WHERE Salario > 5000";
            //cmd = new SqlCommand(update, conn);
            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //// LISTA 02 -----------------------------------------------------------------
            //// Exec 01) 
            //// a) CORRIGIDO

            //while (true)
            //{
            //    Console.WriteLine("***MENU DONO***");
            //    Console.WriteLine("1 - Adicionar produto");
            //    Console.WriteLine("2 - Remover produto");
            //    Console.WriteLine("3 - Atualizar produto");
            //    Console.WriteLine("4 - Mostrar produtos");
            //    Console.WriteLine("5 - Encerrar");
            //    int escolha = Convert.ToInt32(Console.ReadLine());

            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Insira as informações do produto que deseja adicionar");
            //        string nome = Console.ReadLine();
            //        int preco = Convert.ToInt32(Console.ReadLine());
            //        int quantidade = Convert.ToInt32(Console.ReadLine());

            //        string insert = $"INSERT into dbo.Produto (Nome,Preco,Quantidade) values ('{nome}',{preco},{quantidade})";
            //        cmd = new SqlCommand(insert, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        Console.WriteLine("Produto cadastrado");
            //    }
            //    else if (escolha == 2)
            //    {
            //        string select = "SELECT Nome from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.WriteLine(dr[0]); // é 0 porque é o único elemento selecionado no SELECT
            //        }
            //        dr.Close();
            //        conn.Close();

            //        Console.WriteLine("\nInsira o nome do produto que deseja remover");
            //        string produtoParaExcluir = Console.ReadLine();

            //        string delete = $"DELETE from dbo.Produto WHERE Nome = '{produtoParaExcluir}'";
            //        cmd = new SqlCommand(delete, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();

            //        Console.WriteLine("Produto removido");
            //    }
            //    else if (escolha == 3)
            //    {
            //        string select = "SELECT * from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.WriteLine("Nome                  : " + dr[1]);
            //            Console.WriteLine("Preço                 : " + dr[2]);
            //            Console.WriteLine("Quantidade em Estoque : " + dr[3]);
            //            Console.WriteLine("-------------------//--------------------");
            //        }
            //        dr.Close();
            //        conn.Close();

            //        Console.WriteLine("\nInsira o nome do produto que deseja atualizar");
            //        string produto = Console.ReadLine();

            //        Console.WriteLine("Insira todos os dados do produto");
            //        string nome = Console.ReadLine();
            //        int preco = Convert.ToInt32(Console.ReadLine());
            //        int quantidade = Convert.ToInt32(Console.ReadLine());

            //        string update = $"UPDATE dbo.Produto set Nome = '{nome}',Preco = {preco}, Quantidade = {quantidade} WHERE Nome = '{produto}'";
            //        cmd = new SqlCommand(update, conn);
            //        conn.Open();
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
            //    }
            //    else if (escolha == 4)
            //    {
            //        Console.Write("id");
            //        Console.Write("   Nome");
            //        Console.Write("   Preço");
            //        Console.WriteLine("   Quantidade");
            //        string select = "SELECT * from dbo.Produto";
            //        cmd = new SqlCommand(select, conn);
            //        conn.Open();
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        while (dr.Read())
            //        {
            //            Console.Write(dr[0]);
            //            Console.Write("   " + dr[1]);
            //            Console.Write("   " + dr[2]);
            //            Console.WriteLine("   " + dr[3]);

            //        }
            //        dr.Close();
            //        conn.Close();
            //    }
            //    else if (escolha == 5)
            //    {
            //        Console.WriteLine("Obrigado por usar nossas soluções em Software");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opção inválida");
            //    }

            //    Console.WriteLine("\nPressione enter para continuar");
            //    Console.ReadLine();
            //    Console.Clear();
            //}

            //// b)

            while (true)
            {
                List<Produto> carrinho = new List<Produto>();

                while (true)
                {
                    Console.WriteLine("***MENU DO FUNCIONÁRIO***");
                    string select = "SELECT idProduto,Nome from dbo.Produto WHERE Quantidade > 0";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("id   : " + dr[0]);
                        Console.WriteLine("Nome : " + dr[1]);
                        Console.WriteLine("-------------//---------------");
                    }
                    dr.Close();
                    conn.Close();
                    Console.WriteLine("\nDigite o id do produto que você deseja incluir no carrinho");
                    Console.WriteLine("Digite -1 para encerrar a compra");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    if (escolha == -1)
                    {
                        double valorTotal = 0;
                        foreach (var item in carrinho)
                        {
                            valorTotal += item.Preco;
                        }
                        Console.WriteLine("Valor da compra: {0:c}", valorTotal);
                        break;
                    }

                    string update = $"UPDATE dbo.Produto set Quantidade = Quantidade -1 WHERE idProduto = {escolha}";
                    cmd = new SqlCommand(update, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    select = $"SELECT Nome,Preco from dbo.Produto WHERE idProduto = {escolha}";
                    cmd = new SqlCommand(select, conn);
                    conn.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Produto prod = new Produto();
                        prod.Nome = Convert.ToString(dr[0]);
                        prod.Preco = Convert.ToInt32(dr[1]);
                        carrinho.Add(prod);
                    }
                    dr.Close();
                    conn.Close();

                    Console.WriteLine("Pressione enter para continuar");
                    Console.ReadLine();
                    Console.Clear();

                }

                Console.WriteLine("Deseja realizar uma nova compra?");
                Console.WriteLine("1 - Sim\n2 - Não");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 2)
                {
                    break;
                }
                Console.Clear();
            }




        }
    }
}
