using System;
using System.Collections.Generic;

namespace _8._3_OO_pt_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //// LISTA 1------------------------

            //// Exec 01
            //// A
            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Insira uma pessoa");
            //pes.Nome = CR();
            //pes.Cpf = CR();
            //pes.Idade = Convert.ToInt32(CR());
            //pes.Rua = CR();
            //pes.Numero = CR();
            //pes.Cidade = CR();
            //pes.Estado = CR();

            //Console.WriteLine("----------//------------");
            //Console.WriteLine("{0} | {1} | {2}", pes.Nome, pes.Cpf, pes.Idade);
            //Console.WriteLine("{0} | n{1} | {2} | {3}", pes.Rua, pes.Numero, pes.Cidade, pes.Estado);

            //// B
            //Empresa emp = new Empresa();
            //Console.WriteLine("Insira uma empresa");
            //emp.Nome = CR();
            //emp.NumFunc = Convert.ToInt32(CR());
            //emp.Rua = CR();
            //emp.Numero = CR();
            //emp.Cidade = CR();
            //emp.Estado = CR();

            //Console.WriteLine("----------//------------");
            //Console.WriteLine("{0} | {1}", emp.Nome, emp.NumFunc);
            //Console.WriteLine("{0} | n{1} | {2} | {3}", emp.Rua, emp.Numero, emp.Cidade, emp.Estado);

            //// C
            //List<Habitacao> habitar = new List<Habitacao>();


            //for (int i = 0; i < 4; i++)
            //{
            //    Habitacao habit = new Habitacao();
            //    Console.WriteLine("Preencha a " + (i + 1) + "ª habitação:");
            //    Console.WriteLine("Nome do dono");
            //    habit.NomeDono = CR();
            //    Console.WriteLine("Tipo de habitação");
            //    habit.TipoHabitacao = CR();
            //    Console.WriteLine("Informe a rua");
            //    habit.Rua = CR();
            //    Console.WriteLine("Informe o número");
            //    habit.Numero = CR();
            //    Console.WriteLine("Informe a cidade");
            //    habit.Cidade = CR();
            //    Console.WriteLine("Informe o estado");
            //    habit.Estado = CR();

            //    habitar.Add(habit);
            //}

            //for (int i = 0; i < habitar.Count; i++)
            //{
            //    Console.WriteLine("----------//------------");
            //    Console.WriteLine("{0} | {1}", habitar[i].NomeDono, habitar[i].TipoHabitacao);
            //    Console.WriteLine("{0} | n{1} | {2} | {3}", habitar[i].Rua, habitar[i].Numero, habitar[i].Cidade, habitar[i].Estado);
            //}

            //// Exec 02
            //// A
            //Pessoa1 pess = new Pessoa1();
            //Console.WriteLine("Preencha pessoa");
            //Console.WriteLine();
            //Console.WriteLine("Informe o nome");
            //pess.Nome = CR();
            //Console.WriteLine("Informe a idade");
            //pess.Idade = Convert.ToInt32(CR());
            //Console.WriteLine("Informe dopamina");
            //pess.Dopamina = Convert.ToDouble(CR());
            //Console.WriteLine("Informe o dinheiro");
            //pess.Dinheiro = Convert.ToDouble(CR());
            //Console.WriteLine();
            //Console.WriteLine("Deseja trabalhar ou comer?");
            //Console.WriteLine("1 - Trabalhar\n2 - Comer");
            //int escolha = Convert.ToInt32(CR());
            //if (escolha == 1)
            //{
            //    Console.WriteLine("Quantas horas?");
            //    int dinheiro = Convert.ToInt32(CR());
            //    pess.Dinheiro = Pessoa1.Trabalhar(dinheiro) + pess.Dinheiro;                
            //}
            //else
            //{
            //    Console.WriteLine("Quantos quilogramas?");
            //    double comida = Convert.ToDouble(CR());
            //    pess.Dopamina = Pessoa1.Comer(comida) + pess.Dopamina;

            //}
            //Console.WriteLine("-----------------//-----------------");
            //Console.WriteLine("{0} / {1} / {2} / {3:c}", pess.Nome, pess.Idade, pess.Dopamina, pess.Dinheiro);

            //// B
            //List<Cachorro> dogs = new List<Cachorro>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Cachorro dog = new Cachorro();
            //    Console.WriteLine("Preencha os dados do cachorro");
            //    Console.WriteLine("Informe o nome");
            //    dog.Nome = CR();
            //    Console.WriteLine("Informe a dopamina");
            //    dog.Dopamina = Convert.ToDouble(CR());
            //    Console.WriteLine("Informe conforto");
            //    dog.Conforto = Convert.ToDouble(CR());

            //    dogs.Add(dog);
            //}
            //while (true)
            //{
            //    Console.WriteLine("*** MENU ***");
            //    Console.WriteLine("1 - Comer");
            //    Console.WriteLine("2 - Descansar");
            //    Console.WriteLine("3 - Sair");
            //    int escolha = Convert.ToInt32(CR());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("Qual cachorro irá comer?\nDigite o ID:");
            //        for (int i = 0; i < dogs.Count; i++)
            //        {
            //            Console.WriteLine("ID " + (i + 1) + " " + dogs[i].Nome);
            //        }
            //        int id = Convert.ToInt32(CR());
            //        id--;
            //        Console.WriteLine("Quantos quilogramas?");
            //        double kilos = Convert.ToDouble(CR());
            //        dogs[id].Dopamina = Cachorro.Comer(kilos) + dogs[id].Dopamina;
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("Qual cachorro irá descansar?\nDigite o ID:");
            //        for (int i = 0; i < dogs.Count; i++)
            //        {
            //            Console.WriteLine("ID " + (i + 1) + " " + dogs[i].Nome);
            //        }
            //        int id = Convert.ToInt32(CR());
            //        id--;
            //        Console.WriteLine("Quantas horas?");
            //        int horas = Convert.ToInt32(CR());
            //        dogs[id].Conforto = Cachorro.Descansar(horas) + dogs[id].Conforto;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //foreach (var item in dogs)
            //{
            //    Console.WriteLine("----------------------//----------------");
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.Dopamina);
            //    Console.WriteLine(item.Conforto);
            //}

            //// C
            //Funcionario func = new Funcionario();
            //Console.WriteLine("Preencha funcionário");
            //Console.WriteLine("Informe o nome");
            //func.Nome = CR();
            //Console.WriteLine("Informe o dinheiro no bolso");
            //func.DinheiroNoBolso = Convert.ToDouble(CR());
            //while (func.DinheiroNoBolso < 1520)
            //{
            //    func.DinheiroNoBolso += Funcionario.Trabalhar(1);
            //}

            //Console.WriteLine("{0} {1} {2}", func.Nome, func.DinheiroNoBolso);

            //// LISTA 02 -----------------------------------------

            //// Exec 01 INCOMPLETO, FALTA LETRA C
            //CalculadoraCientifica calculo = new CalculadoraCientifica();

            //double resultado = 0;
            //Console.WriteLine("Insira o primeiro número");
            //double numero1 = Convert.ToDouble(CR());
            //Console.WriteLine("Insira a operação");
            //string operacao = CR();
            //if (operacao == "raiz")
            //{
            //    resultado = calculo.Raiz(numero1);
            //}
            //else
            //{
            //    Console.WriteLine("Insira o segundo número");
            //    double numero2 = Convert.ToDouble(CR());
            //    if (operacao == "+")
            //    {
            //        resultado = calculo.Soma(numero1, numero2);
            //    }
            //    else if (operacao == "-")
            //    {
            //        resultado = calculo.Subtracao(numero1, numero2);
            //    }
            //    else if (operacao == "*")
            //    {
            //        resultado = calculo.Multiplicacao(numero1, numero2);
            //    }
            //    else if (operacao == "^")
            //    {
            //        resultado = calculo.Potenciacao(numero1, numero2);
            //    }
            //}
            //Console.WriteLine(resultado);            

            //// Exec 02
            //Pagamento cli = new Pagamento();
            //Console.WriteLine("Insira o valor");
            //cli.ValorPagamento = Convert.ToDouble(CR());
            //Console.WriteLine("Informe a data");
            //cli.DataPagamento = CR();

            //while (true)
            //{
            //    Console.WriteLine("***MENU - FORMAS DE PAGAMENTO***");
            //    Console.WriteLine("Opção 1 - Cartão de Crédito (taxa 4%)");
            //    Console.WriteLine("Opção 2 - Cartão de Débito (taxa 2%)");
            //    Console.WriteLine("Opção 3 - Boleto Bancário");
            //    int opcao = Convert.ToInt32(CR());
            //    if (opcao == 1)
            //    {
            //        cli.c = cli.ValorPagamento + (cli.ValorPagamento * 0.04);
            //    }
            //    else if (opcao == 2)
            //    {

            //    }
            //    else if (opcao == 3)
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("OPÇÃO INCORRETA");
            //    }
            //}     






            //// Exec 03
            //// b CORRIGIDO
            //Empresa1 emp = new Empresa1();
            ////List<Funcionarios> temp = new List<Funcionarios>();
            //List<Funcionarios> temp2 = new List<Funcionarios>();
            //temp2.Add(new Funcionarios { Nome = "Jorge", Cargo = "Peão", Salario = 1350.24, Conta = "155584685", Saldo = -624.33, Senha = 1554 });
            //temp2.Add(new Funcionarios { Nome = "Cleiton", Cargo = "Entregador", Salario = 1624.72, Conta = "35698758", Saldo = 800, Senha = 1337 });
            //temp2.Add(new Funcionarios { Nome = "Dr. Hamilton", Cargo = "Gerente", Salario = 2215.56, Conta = "485789512", Saldo = 1542.75, Senha = 6522 });

            //emp.Func = temp2;

            ////for (int i = 0; i < 1; i++)
            ////{
            ////    PreencheFunc(temp);
            ////}
            ////emp.Func = temp;

            ////foreach (var item in emp.Func)
            ////{
            ////    Console.WriteLine(item.Nome);
            ////}

            //while (true)
            //{
            //    Console.WriteLine("Seja bem vindo");
            //    Console.WriteLine("1 - Aumento");
            //    Console.WriteLine("2 - Demitir");
            //    Console.WriteLine("3 - Fechamento");
            //    Console.WriteLine("4 - Sair :,(");
            //    int escolha = Convert.ToInt32(CR());
            //    if (escolha == 1)
            //    {
            //        Console.WriteLine("De qual deseja aumentar o salário?");
            //        for (int i = 0; i < emp.Func.Count; i++)
            //        {
            //            Console.WriteLine("{0}- {1}", i + 1, emp.Func[i].Nome);
            //        }
            //        escolha = Convert.ToInt32(CR()) - 1;
            //        Console.WriteLine("Quantos % de aumento?");
            //        double aumento = Convert.ToDouble(CR());
            //        emp.Func[escolha].Salario += emp.Func[escolha].Salario * (aumento / 100);
            //        Console.WriteLine(emp.Func[escolha].Salario);
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if (escolha == 2)
            //    {
            //        Console.WriteLine("De qual deseja demitir?");
            //        for (int i = 0; i < emp.Func.Count; i++)
            //        {
            //            Console.WriteLine("{0}- {1}", i + 1, emp.Func[i].Nome);
            //        }
            //        escolha = Convert.ToInt32(CR()) - 1;
            //        emp.Func.RemoveAt(escolha);
            //        Console.Clear();
            //    }
            //    else if (escolha == 3)
            //    {
            //        double faturamento = 0;
            //        foreach (var item in emp.Func)
            //        {
            //            if(item.Cargo == "Peão")
            //            {
            //                faturamento += 4785.26;
            //            }
            //            else if(item.Cargo == "Entregador")
            //            {
            //                faturamento += 5324.82;
            //            }
            //            else
            //            {
            //                foreach (var item2 in emp.Func)
            //                {
            //                    if(item2.Cargo != "Gerente")
            //                    {
            //                        faturamento += 2485.64;
            //                    }
            //                }
            //            }
            //        }
            //        emp.Saldo += faturamento;
            //        for (int i = 0; i < emp.Func.Count; i++)
            //        {
            //            emp.Func[i].Saldo += emp.Func[i].Salario;
            //            emp.Saldo -= emp.Func[i].Salario;
            //            faturamento -= emp.Func[i].Salario;
            //        }
            //        if(faturamento < 0)
            //        {
            //            Console.WriteLine("Prejuízo");
            //            Console.WriteLine(faturamento);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Deu lucro");
            //            Console.WriteLine(faturamento);
            //        }
            //        Console.ReadLine();
            //        Console.Clear();


            //    }
            //    else if (escolha == 4)
            //    {
            //        Console.WriteLine("FIM");
            //        break;
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
        public static void PreencheFunc(List<Funcionarios> Funci)
        {
            Funcionarios colaborador = new Funcionarios();
            Console.WriteLine("Informações pessoais");
            colaborador.Nome = CR();
            colaborador.Cargo = CR();
            colaborador.Salario = Convert.ToDouble(CR());
            Console.WriteLine("Dados Bancários");
            colaborador.Conta = CR();
            colaborador.Saldo = Convert.ToDouble(CR());
            colaborador.Senha = Convert.ToInt32(CR());
            Funci.Add(colaborador);
        }
    }
}
