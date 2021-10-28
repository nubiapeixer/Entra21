using System;
using System.Collections.Generic;

namespace OO_pt_6___Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //// LISTA 1 --------------------------
            //// 1) a,b,c,e

            //Console.WriteLine("ADM: Qual o preço do ingresso e o extra do VIP?");
            //double valor, extra;
            //valor = CRD();
            //extra = CRD();
            //Normal nor = new Normal();
            //nor.Valor = valor;
            //CamaroteInferior camI = new CamaroteInferior();
            //camI.Valor = valor;
            //camI.ValorExtra = extra;
            //Console.WriteLine("Qual a localização do Camarote Inferior?");
            //camI.Localizacao = CR();
            //CamaroteSuperior camS = new CamaroteSuperior();
            //camS.Valor = valor * 3;
            //camS.ValorExtra = extra * 3;
            //Console.WriteLine("Qual a localização do Camarote Superior?");
            //camS.Localizacao = CR();
            //Console.WriteLine("Cliente: Qual deseja comprar?");
            //Console.WriteLine("Ingresso Normal");
            //nor.ImprimeValor();
            //Console.WriteLine("Camarote Inferior");
            //camI.ImprimeValor();
            //Console.WriteLine("Camarote Superior");
            //camS.ImprimeValor();
            //CR();
            //Console.WriteLine("Obrigado pela preferência!");

            //// 2) a,b,c
            //Administrativo adm = new Administrativo();
            //Tecnico tec = new Tecnico();
            //adm.Nome = "Joeslei";
            //adm.Salario = 2568.48;
            //adm.NumeroMatricula = 155248;
            //adm.Bonus = 562.12;
            //adm.Turno = false;
            //tec.Nome = "Jaime";
            //tec.Salario = 1978.25;
            //tec.NumeroMatricula = 125466;
            //tec.Bonus = 897.15;

            ////Assistente assis = Preenche();

            //while (true)
            //{
            //    Console.WriteLine("O que deseja fazer?");
            //    Console.WriteLine("1 - Editar");
            //    Console.WriteLine("2 - Excluir");
            //    Console.WriteLine("3 - Sair");
            //    int escolha = Convert.ToInt32(CR());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Qual deseja editar?");
            //        Console.WriteLine("1");
            //        adm.ExibeDados();
            //        Console.WriteLine("-----------//-----------------");
            //        Console.WriteLine("2");
            //        tec.ExibeDados();
            //        escolha = Convert.ToInt32(CR());
            //        if (escolha == 1)
            //        {
            //            adm = Preenche(0);
            //        }
            //        else
            //        {
            //            tec = Preenche();
            //        }
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("Qual deseja excluir?");
            //        Console.WriteLine("1");
            //        adm.ExibeDados();
            //        Console.WriteLine("-----------//-----------------");
            //        Console.WriteLine("2");
            //        tec.ExibeDados();
            //        escolha = Convert.ToInt32(CR());
            //        if (escolha == 1)
            //        {
            //            adm = new Administrativo();
            //        }
            //        else
            //        {
            //            tec = new Tecnico();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Obrigado por usar nossos Serviços");
            //        break;
            //    }
            //}

            //// Exec 3) a,b,c (Gustavo github)
            //Cliente cli = new Cliente("Bruna", 1000);
            //Novo imovelNovo = new Novo(2000, "Rua República Argentina");
            //Novo imovelNovo2 = new Novo(1800, "Rua xv de Novembro");
            //Velho imovelVelho = new Velho(1000, "Rua dos Caçadores");
            //Velho imovelVelho2 = new Velho(1100, "Rua das Missões");
            //imovelNovo.PrecoAdicional = 500;
            //imovelNovo2.PrecoAdicional = 200;
            //imovelVelho.Desconto = 300;
            //imovelVelho2.Desconto = 200;

            //List<Imovel> imoveis = new List<Imovel>();
            //imoveis.Add(imovelNovo);
            //imoveis.Add(imovelNovo2);
            //imoveis.Add(imovelVelho);
            //imoveis.Add(imovelVelho2);

            //while (true)
            //{
            //    Console.WriteLine("Nome: " + cli.Nome);
            //    Console.WriteLine("Saldo da Conta: " + "{0:c}", cli.Dinheiro);
            //    Console.WriteLine();
            //    Console.WriteLine("***IMÓVEIS***");
            //    for (int i = 0; i < imoveis.Count; i++)
            //    {
            //        Console.WriteLine("ID " + (i + 1));
            //        imoveis[i].CalculaValor();
            //        Console.WriteLine("------------//--------------");
            //    }
            //    Console.WriteLine("Qual deseja comprar? Insira o ID");
            //    int escolha = CRI();
            //    escolha--;
            //    if (imoveis[escolha].Preco > cli.Dinheiro)
            //    {
            //        Console.WriteLine("SALDO INSUFICIENTE");
            //        Console.WriteLine("1 - Parcelar 12x + acréscimo | 2 - Escolher outro Imóvel");
            //        int opcao = CRI();
            //        if (opcao == 1)
            //        {
            //            Console.WriteLine("Valor Total: " + "{0:c}", imoveis[escolha].Preco);
            //            double parcelas = imoveis[escolha].Preco * 1.1674;
            //            parcelas /= 12;
            //            Console.WriteLine("12x " + "{0:c}", parcelas);
            //            cli.Dinheiro -= parcelas;
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        cli.Dinheiro -= imoveis[escolha].Preco;
            //        break;
            //    }
            //}
            //Console.WriteLine("SALDO ATUAL DO CLIENTE: " + "{0:c}", cli.Dinheiro);
            //Console.WriteLine("Obrigado pela preferência!!");
            //Console.ReadLine();

            //// 3 ---------------------------- CORRIGIDO 
            //List<Novo1> novos = new List<Novo1>();
            //List<Velho1> velhos = new List<Velho1>();
            //Random ran = new Random();
            //for (int i = 0; i < 2; i++)
            //{
            //    Novo1 n = new Novo1();
            //    n.Endereco = $"Rua XV n°{ran.Next(10, 200 + 1)}";
            //    n.Preco = ran.Next(100000, 300000 + 1);
            //    n.Adicional = ran.Next(50000, 100000 + 1);
            //    n.CalculaValor();
            //    Velho1 v = new Velho1();
            //    v.Endereco = $"Rua General Osório n°{ran.Next(10, 200 + 1)}";
            //    v.Preco = ran.Next(100000, 300000 + 1);
            //    v.Desconto = ran.Next(50000, 100000 + 1);
            //    v.CalculaValor();
            //    novos.Add(n); velhos.Add(v);
            //}
            //Cliente1 cli = new Cliente1();
            //cli.Nome = "Cleber";
            //cli.DinheiroDisponivel = ran.Next(100000, 300000 + 1);

            //while (true)
            //{
            //    Console.WriteLine("Olá Sr " + cli.Nome);
            //    Console.WriteLine("Com saldo de: {0:c}", cli.DinheiroDisponivel);
            //    Console.WriteLine("Qual imóvel deseja comprar?");
            //    Console.WriteLine("Imóveis Novos");
            //    int contador = 1;
            //    foreach (var item in novos)
            //    {
            //        Console.WriteLine(contador);
            //        MostraObjeto(item);
            //        contador++;
            //    }
            //    Console.WriteLine("Imóveis Clássicos");
            //    foreach (var item in velhos)
            //    {
            //        Console.WriteLine(contador);
            //        MostraObjeto(item);
            //        contador++;
            //    }
            //    Console.WriteLine("Qual deseja comprar?");
            //    contador = CRI();
            //    if (contador < 3)
            //    {
            //        contador--;
            //        if (novos[contador].Preco > cli.DinheiroDisponivel)
            //        {
            //            Console.WriteLine("Não tem como pagar à vista");
            //            Console.WriteLine("Mas podemos parcelar pra você");
            //            double valorParcela = CalculaParcela(novos[contador].Preco);
            //            Console.WriteLine("Deseja finalizar esta compra?");
            //            Console.WriteLine("1 - Sim\n2 - Não");
            //            contador = CRI();
            //            if (contador == 1)
            //            {
            //                cli.DinheiroDisponivel -= valorParcela;
            //                Console.WriteLine("Obrigado pela preferência");
            //                break;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            cli.DinheiroDisponivel -= novos[contador].Preco;
            //            Console.WriteLine("Obrigado pela preferência");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        contador -= 3;
            //        if (velhos[contador].Preco > cli.DinheiroDisponivel)
            //        {
            //            Console.WriteLine("Não tem como pagar à vista");
            //            Console.WriteLine("Mas podemos parcelar pra você");
            //            double valorParcela = CalculaParcela(velhos[contador].Preco);
            //            Console.WriteLine("Deseja finalizar esta compra?");
            //            Console.WriteLine("1 - Sim\n2 - Não");
            //            contador = CRI();
            //            if (contador == 1)
            //            {
            //                cli.DinheiroDisponivel -= valorParcela;
            //                Console.WriteLine("Obrigado pela preferência");
            //                break;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //        else
            //        {
            //            cli.DinheiroDisponivel -= velhos[contador].Preco;
            //            Console.WriteLine("Obrigado pela preferência");
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Pressione Enter para prosseguir");
            //CR();
            //Console.Clear();

            //Console.WriteLine("Saldo final do cliente");
            //Console.WriteLine("{0:c}", cli.DinheiroDisponivel);

            //// LISTA 2 -----------------------------------
            //// Exec 1)
            //List<PessoaFisica> pessFisica = new List<PessoaFisica>();
            //List<PessoaJuridica> pessJuridica = new List<PessoaJuridica>();
            //PessoaFisica pessF = new PessoaFisica();
            //PessoaJuridica pessJ = new PessoaJuridica();

            //while (true)
            //{
            //    Console.WriteLine("AGENDA DE CONTATOS");
            //    Console.WriteLine("1 - Adicionar");
            //    Console.WriteLine("2 - Remover");
            //    Console.WriteLine("3 - Pesquisar Contato");
            //    Console.WriteLine("4 - Ver Lista");

            //    int escolha = CRI();
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Deseja adicionar: 1 - Pessoa Física ou 2 - Jurídica?");
            //        escolha = CRI();
            //        if (escolha == 1)
            //        {
            //            pessF = PreenchePessoa(0);
            //            pessFisica.Add(pessF);
            //        }
            //        else
            //        {
            //            pessJ = PreenchePessoa(0d);
            //            pessJuridica.Add(pessJ);
            //        }
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("Deseja remover: 1 - Pessoa Física ou 2 - Jurídica?");
            //        escolha = CRI();
            //        if (escolha == 1)
            //        {
            //            foreach (var item in pessFisica)
            //            {
            //                Console.WriteLine("-----------------//--------------");
            //                MostraAgenda(item);
            //            }

            //            Console.WriteLine("Digite o nome e/ou CPF");
            //            string nome = CR();
            //            string cpf = CR();

            //            for (int i = 0; i < pessFisica.Count; i++)
            //            {
            //                if (nome == pessFisica[i].Nome || cpf == pessFisica[i].Cpf)
            //                {
            //                    pessFisica.RemoveAt(i);
            //                    Console.WriteLine("CONTATO REMOVIDO");
            //                }
            //            }
            //        }
            //        else
            //        {
            //            foreach (var item in pessJuridica)
            //            {
            //                Console.WriteLine("-----------------//--------------");
            //                MostraAgenda(item);
            //            }
            //            Console.WriteLine("Digite o nome e/ou CNPJ");
            //            string nome = CR();
            //            string cnpj = CR();


            //            for (int i = 0; i < pessJuridica.Count; i++)
            //            {
            //                if (nome == pessJuridica[i].Nome || cnpj == pessJuridica[i].Cnpj)
            //                {
            //                    pessJuridica.RemoveAt(i);
            //                    Console.WriteLine("CONTATO REMOVIDO");
            //                }
            //            }
            //        }
            //    }
            //    else if (escolha == 3)
            //    {
            //        Console.WriteLine("Deseja pesquisar: 1 - Pessoa Física ou 2 - Jurídica?");
            //        escolha = CRI();

            //        if (escolha == 1)
            //        {
            //            Console.WriteLine("Digite o nome e/ou CPF");
            //            string nome = CR();
            //            string cpf = CR();

            //            for (int i = 0; i < pessFisica.Count; i++)
            //            {
            //                if (nome == pessFisica[i].Nome || cpf == pessFisica[i].Cpf)
            //                {
            //                    pessFisica[i].MostraLista();
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Digite o nome e/ou CNPJ");
            //            string nome = CR();
            //            string cnpj = CR();
            //            for (int i = 0; i < pessJuridica.Count; i++)
            //            {
            //                if (nome == pessJuridica[i].Nome || cnpj == pessJuridica[i].Cnpj)
            //                {
            //                    pessJuridica[i].MostraLista();
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        foreach (var item in pessFisica)
            //        {
            //            Console.WriteLine("-----------------//--------------");
            //            MostraAgenda(item);
            //        }
            //        foreach (var item in pessJuridica)
            //        {
            //            Console.WriteLine("-----------------//--------------");
            //            MostraAgenda(item);
            //        }
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Pressione Enter para prosseguir");
            //    Console.ReadLine();
            //    Console.Clear();
            //}
            //// Exec 2) a,b,c
            //List<Mouse> eletro = new List<Mouse>();
            //List<Livro> livraria = new List<Livro>();
            //Mouse mou = new Mouse();
            //mou.Nome = "Mouse";
            //mou.Preco = 620.10;
            //mou.Tipo = "eletrônico";
            //mou.Dpi = 160;
            //mou.Modelo = "Gamer Longitech MX";
            //mou.CalculaPreco();
            //eletro.Add(mou);

            //Mouse mou2 = new Mouse();
            //mou2.Nome = "Mouse";
            //mou2.Preco = 550.20;
            //mou2.Tipo = "eletrônico";
            //mou2.Dpi = 100;
            //mou2.Modelo = "Gamer Multilaser";
            //mou2.CalculaPreco();
            //eletro.Add(mou2);

            //Mouse mou3 = new Mouse();
            //mou3.Nome = "Mouse";
            //mou3.Preco = 250;
            //mou3.Tipo = "eletrônico";
            //mou3.Dpi = 120;
            //mou3.Modelo = "Gamer HP";
            //mou3.CalculaPreco();
            //eletro.Add(mou3);

            //Livro liv = new Livro();
            //liv.Nome = "Hamlet";
            //liv.Preco = 160;
            //liv.Tipo = "Livros";
            //liv.Autor = "William Shakespeare";
            //liv.Estilo = "Romance";
            //liv.CalculaPreco();
            //livraria.Add(liv);

            //Livro liv2 = new Livro();
            //liv2.Nome = "As crônicas de gelo e fogo";
            //liv2.Preco = 120.90;
            //liv2.Tipo = "Livros";
            //liv2.Autor = "George R. R. Martin";
            //liv2.Estilo = "Fantasia";
            //liv2.CalculaPreco();
            //livraria.Add(liv2);

            //Livro liv3 = new Livro();
            //liv3.Nome = "Harry Potter";
            //liv3.Preco = 60.99;
            //liv3.Tipo = "Livros";
            //liv3.Autor = "J. K. Rowling";
            //liv3.Estilo = "Fantasia";
            //liv3.CalculaPreco();
            //livraria.Add(liv3);

            //double carrinho = 0;

            //while (true)
            //{
            //    int contador = 1;
            //    Console.WriteLine("LISTA MOUSE");
            //    Console.WriteLine();
            //    foreach (var item in eletro)
            //    {
            //        Console.WriteLine(contador);
            //        MostraObjeto(item);
            //        contador++;
            //    }
            //    Console.WriteLine("LISTA LIVROS");
            //    Console.WriteLine();
            //    foreach (var item in livraria)
            //    {
            //        Console.WriteLine(contador);
            //        MostraObjeto(item);
            //        contador++;
            //    }
            //    Console.WriteLine("O que você deseja colocar no carrinho?");
            //    Console.WriteLine("Insira o ID do produto ou digite Encerrar");
            //    string opcao = CR().ToLower();
            //    if (opcao == "encerrar")
            //    {
            //        break;
            //    }
            //    contador = Convert.ToInt32(opcao);
            //    if(contador > 3)
            //    {
            //        contador -= 4;
            //        carrinho += livraria[contador].Preco;
            //    }
            //    else
            //    {
            //        contador--; ;
            //        carrinho += eletro[contador].Preco;
            //    }
            //}
            //Console.WriteLine("VALOR TOTAL");
            //Console.WriteLine("{0:c}", carrinho);

            //// LISTA 03 ------------------------------------------
            //// Exec 1)           

            List<Transacao> contaComum = new List<Transacao>();
            List<Transacao> contaLimite = new List<Transacao>();
            List<Transacao> poupanca = new List<Transacao>();                    


            Conta cc = new Conta();
            cc.Nome = "Julia";
            cc.NumeroConta = "001";
            cc.Saldo = 4500;

            CorrenteLimite cl = new CorrenteLimite();
            cl.Nome = "Núbia";
            cl.NumeroConta = "002";
            cl.Saldo = 5500;
            cl.ValorLimite = 300;

            Poupanca p = new Poupanca();
            p.Nome = "Bruna";
            p.NumeroConta = "003";
            p.Saldo = 10000;
            p.DataAniversário = "06/07/1994";


            double deposito = 0; double saque = 0;

            while (true)
            {
                

                Console.WriteLine("Informe o número da conta");
                string conta = CR();
                if (conta == "001")
                {
                    
                    while (true)
                    {
                        Transacao trans = new Transacao();

                        Console.WriteLine("MENU DE OPÇÕES");
                        Console.WriteLine("1 - Depósito");
                        Console.WriteLine("2 - Retirada");
                        Console.WriteLine("3 - Extrato");

                        int opcao = CRI();
                        if (opcao == 1)
                        {
                            Console.WriteLine("-----//------");
                            cc.Extrato();
                            Console.WriteLine("-----//------");

                            deposito = cc.Deposito();

                            trans.ValorTransacao = deposito;
                            trans.DataTransacao = DateTime.Now.ToString("yyyy-MM-dd");
                            trans.Descricao = "Depósito em conta corrente";
                            contaComum.Add(trans);

                        }
                        else if (opcao == 2)
                        {
                            Console.WriteLine("-----//------");
                            cc.Extrato();
                            Console.WriteLine("-----//------");

                            saque = cc.Retirada();

                            if(saque != 0)
                            {
                                trans.ValorTransacao = saque;
                                trans.DataTransacao = DateTime.Now.ToString("yyyy-MM-dd");
                                trans.Descricao = "Saque em conta corrente";
                                contaComum.Add(trans);
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("-----//------");
                            cc.Extrato();
                            Console.WriteLine();
                            Console.WriteLine("ÚLTIMAS TRANSAÇÕES:");
                            foreach (var item in contaComum)
                            {
                                Console.WriteLine("{0:c}", item.ValorTransacao);
                                Console.WriteLine(item.DataTransacao);
                                Console.WriteLine(item.Descricao);
                                Console.WriteLine();
                            }
                            Console.WriteLine("-----//------");
                        }                        

                        Console.WriteLine("1 - Realizar outra operação\n2 - Sair");
                        int escolha = CRI();
                        if (escolha == 2)
                        {
                            break;
                        }

                        Console.WriteLine("Pressione Enter para Continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (conta == "002")
                {
                    while (true)
                    {
                        Transacao trans = new Transacao();

                        Console.WriteLine("MENU DE OPÇÕES");
                        Console.WriteLine("1 - Depósito");
                        Console.WriteLine("2 - Retirada");
                        Console.WriteLine("3 - Extrato");

                        int opcao = CRI();
                        if (opcao == 1)
                        {
                            Console.WriteLine("-----//------");
                            cl.Extrato();
                            Console.WriteLine("-----//------");

                            deposito = cl.Deposito();

                            trans.ValorTransacao = deposito;
                            trans.DataTransacao = DateTime.Now.ToString("yyyy-MM-dd");
                            trans.Descricao = "Depósito em conta corrente limite";
                        }
                        else if (opcao == 2)
                        {

                            Console.WriteLine("-----//------");
                            cl.Extrato();
                            Console.WriteLine("-----//------");

                            saque = cl.Retirada();
                            if(saque != 0)
                            {
                                trans.ValorTransacao = saque;
                                trans.DataTransacao = DateTime.Now.ToString("yyyy-MM-dd");
                                trans.Descricao = "Saque em conta corrente limite";
                            }
                        }
                        else
                        {
                            Console.WriteLine("-----//------");
                            cl.Extrato();
                            Console.WriteLine();
                            Console.WriteLine("ÚLTIMAS TRANSAÇÕES:");
                            foreach (var item in contaLimite)
                            {
                                Console.WriteLine("{0:c}", item.ValorTransacao);
                                Console.WriteLine(item.DataTransacao);
                                Console.WriteLine(item.Descricao);
                                Console.WriteLine();
                            }
                            Console.WriteLine("-----//------");
                            
                        }
                        contaLimite.Add(trans);

                        Console.WriteLine("1 - Realizar outra operação\n2 - Sair");
                        int escolha = CRI();
                        if (escolha == 2)
                        {
                            break;
                        }
                        Console.WriteLine("Pressione Enter para Continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    while (true)
                    {
                        Transacao trans = new Transacao();

                        Console.WriteLine("MENU DE OPÇÕES");
                        Console.WriteLine("1 - Depósito");
                        Console.WriteLine("2 - Retirada");
                        Console.WriteLine("3 - Extrato");

                        int opcao = CRI();
                        if (opcao == 1)
                        {
                            Console.WriteLine("-----//------");
                            p.Extrato();
                            Console.WriteLine("-----//------");

                            deposito = p.Deposito();

                            trans.ValorTransacao = deposito;
                            trans.DataTransacao = DateTime.Now.ToString("yyyy-MM-dd");
                            trans.Descricao = "Depósito em conta poupança";
                        }
                        else if (opcao == 2)
                        {

                            Console.WriteLine("-----//------");
                            p.Extrato();
                            Console.WriteLine("-----//------");

                            saque = p.Retirada();

                            if(saque != 0)
                            {
                                trans.ValorTransacao = saque;
                                trans.DataTransacao = DateTime.Now.ToString("yyyy-MM-dd");
                                trans.Descricao = "Depósito em conta corrente";
                            }
                        }
                        else
                        {
                            Console.WriteLine("-----//------");
                            p.Extrato();
                            Console.WriteLine();
                            Console.WriteLine("ÚLTIMAS TRANSAÇÕES:");
                            foreach (var item in poupanca)
                            {
                                Console.WriteLine("{0:c}", item.ValorTransacao);
                                Console.WriteLine(item.DataTransacao);
                                Console.WriteLine(item.Descricao);
                                Console.WriteLine();
                            }
                            
                            Console.WriteLine("-----//------");
                        }

                        poupanca.Add(trans);

                        Console.WriteLine("1 - Realizar outra operação\n2 - Sair");
                        int escolha = CRI();
                        if (escolha == 2)
                        {
                            break;
                        }

                        Console.WriteLine("Pressione Enter para Continuar");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                Console.WriteLine("Pressione Enter para prosseguir");
                Console.ReadLine();
                Console.Clear();
            }






        }
        /// <summary>
        /// Função para Console.ReadLine() - Marcações Recomendadas C#
        /// </summary>
        /// <returns></returns>
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static double CRD()
        {
            return Convert.ToDouble(CR());
        }
        public static int CRI()
        {
            return Convert.ToInt32(CR());
        }
        // Lista 1 -----------------------------
        // exec 2)
        public static Administrativo Preenche(int administrativo)
        {
            Console.WriteLine("Prencha os dados novos");
            Administrativo adm = new Administrativo();
            adm.Nome = CR();
            adm.Salario = CRD();
            string turno = CR().ToLower();
            if (turno == "dia")
            {
                adm.Turno = true;
            }
            else
            {
                adm.Turno = false;
            }
            adm.NumeroMatricula = Convert.ToInt32(CR());
            return adm;
        }
        public static Tecnico Preenche()
        {
            Tecnico tec = new Tecnico();
            tec.Nome = CR();
            tec.Salario = CRD();
            tec.NumeroMatricula = Convert.ToInt32(CR());
            return tec;
        }
        // Exec 03
        public static void MostraObjeto(Novo1 n)
        {
            Console.WriteLine(n.Endereco);
            Console.WriteLine("{0:c}", n.Preco);
            Console.WriteLine("--------------//------------");
        }
        public static void MostraObjeto(Velho1 v)
        {
            Console.WriteLine(v.Endereco);
            Console.WriteLine("{0:c}", v.Preco);
            Console.WriteLine("--------------//------------");
        }
        public static double CalculaParcela(double valor)
        {
            Console.WriteLine("Valor das parcelas {0:c}", (valor * 1.1674) / 12);
            Console.WriteLine("Valor Final {0:c}", (valor * 1.1674));
            return (valor * 1.1674) / 12;

        }
        // LISTA 2 ----------------------------------------      
        // Exec 1)
        public static PessoaFisica PreenchePessoa(int x)
        {
            Console.WriteLine("Preencha os dados da pessoa física");
            PessoaFisica pessoa = new PessoaFisica();
            pessoa.Nome = CR();
            pessoa.Endereco = CR();
            pessoa.Email = CR();
            pessoa.Cpf = CR();
            pessoa.Nascimento = CR();
            pessoa.EstadoCivil = CR();

            return pessoa;
        }
        public static PessoaJuridica PreenchePessoa(double x)
        {
            Console.WriteLine("Preencha os dados da pessoa jurídica");
            PessoaJuridica pessoa = new PessoaJuridica();
            pessoa.Nome = CR();
            pessoa.Endereco = CR();
            pessoa.Email = CR();
            pessoa.Cnpj = CR();
            pessoa.InscricaoEstadual = CR();
            pessoa.RazaoSocial = CR();

            return pessoa;
        }
        public static void MostraAgenda(PessoaFisica pessoa)
        {
            pessoa.MostraLista();
        }
        public static void MostraAgenda(PessoaJuridica pessoa)
        {
            pessoa.MostraLista();
        }

        //Exec 2
        public static void MostraObjeto(Mouse m)
        {
            Console.WriteLine(m.Nome);
            Console.WriteLine("{0:c}", m.Preco);
            Console.WriteLine(m.Tipo);
            Console.WriteLine(m.Dpi);
            Console.WriteLine(m.Modelo);
            Console.WriteLine("--------------//------------");
        }
        public static void MostraObjeto(Livro l)
        {
            Console.WriteLine(l.Nome);
            Console.WriteLine("{0:c}", l.Preco);
            Console.WriteLine(l.Tipo);
            Console.WriteLine(l.Autor);
            Console.WriteLine(l.Estilo);
            Console.WriteLine("--------------//------------");
        }
    }
}
