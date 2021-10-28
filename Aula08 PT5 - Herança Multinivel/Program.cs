using System;
using System.Collections.Generic;

namespace _8._4_OO_pt_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //// LISTA 1 -----------------------------
            //// Exec 01
            //// a)
            //Empresa emp = new Empresa();
            //Console.WriteLine("Preencha a Empresa");
            //emp.Nome = CR();
            //emp.Idade = Convert.ToInt32(CR());
            //emp.Saldo = Convert.ToDouble(CR());
            //emp.QtdFuncionarios = Convert.ToInt32(CR());
            //emp.Cnpj = CR();
            //emp.Rua = CR();
            //emp.Cep = CR();
            //emp.Cidade = CR();
            //emp.Estado = CR();
            //if (emp.QtdFuncionarios > 8)
            //{
            //                            
            //    Console.WriteLine(@"{0} {1} {2:00\.​000\.000\/0000\-00}", emp.Nome, emp.Idade, Convert.ToInt64(emp.Cnpj));
            //    Console.WriteLine("{0:c} {1}", emp.Saldo, emp.QtdFuncionarios);
            //    Console.WriteLine("{0} {1} {2}", emp.Rua, emp.Cep, emp.Cidade);
            //    Console.WriteLine("{0}", emp.Estado);
            //}
            //else
            //{
            //    Console.WriteLine("Micro empresa");
            //}

            //// b)
            //List<Carro> carros = new List<Carro>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Carro car = new Carro();
            //    Console.WriteLine("Insira o modelo do carro");
            //    car.Modelo = CR();
            //    Console.WriteLine("Insira o número de cavalos");
            //    car.CavalosVapor = Convert.ToInt32(CR());
            //    Console.WriteLine("Insira idade");
            //    car.Idade = Convert.ToInt32(CR());
            //    Console.WriteLine("Insira Cidade");
            //    car.Cidade = CR();
            //    Console.WriteLine("Insira Estado");
            //    car.Estado = CR();
            //    carros.Add(car);
            //}

            //SortManual(carros);
            //for (int i = 0; i < carros.Count; i++)
            //{
            //    if (carros[i].CavalosVapor > 500)
            //    {
            //        Console.WriteLine("{0} {1} {2}", carros[i].Modelo, carros[i].CavalosVapor, carros[i].Idade);
            //        Console.WriteLine("{0} {1}", carros[i].Cidade, carros[i].Estado);
            //    }
            //}

            //// Exec 02
            //// a)
            //List<Funcionario> funci = new List<Funcionario>();
            //int cont = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Funcionario colaborador = new Funcionario();
            //    Console.WriteLine("Preencha os dados do funcionário");
            //    colaborador.Nome = CR();
            //    colaborador.Idade = Convert.ToInt32(CR());
            //    colaborador.Cpf = CR();
            //    colaborador.Rua = CR();
            //    colaborador.Cep = CR();
            //    colaborador.Cidade = CR();
            //    colaborador.Estado = CR();
            //    colaborador.Cargo = CR();
            //    colaborador.Salario = Convert.ToDouble(CR());

            //    if (colaborador.Salario < 1800)
            //    {
            //        cont++;
            //    }

            //    funci.Add(colaborador);
            //}

            //for (int i = 0; i < funci.Count; i++)
            //{
            //    if (cont >= 1)
            //    {
            //        if (funci[i].Salario < 1800)
            //        {
            //            Console.WriteLine("---------------//------------");
            //            Console.WriteLine("{0} {1} {2}", funci[i].Nome, funci[i].Idade, funci[i].Cpf);
            //            Console.WriteLine("{0} {1}", funci[i].Rua, funci[i].Cep);
            //            Console.WriteLine("{0} {1}", funci[i].Cidade, funci[i].Estado);
            //            Console.WriteLine("{0} {1}", funci[i].Cargo, funci[i].Salario);
            //        }
            //    }
            //    else
            //    {
            //        if (funci[i].Salario >= 1800)
            //        {
            //            Console.WriteLine("---------------//------------");
            //            Console.WriteLine("{0} {1} {2}", funci[i].Nome, funci[i].Idade, funci[i].Cpf);
            //            Console.WriteLine("{0} {1}", funci[i].Rua, funci[i].Cep);
            //            Console.WriteLine("{0} {1}", funci[i].Cidade, funci[i].Estado);
            //            Console.WriteLine("{0} {1}", funci[i].Cargo, funci[i].Salario);
            //        }
            //    }
            //}

            //// b)
            //Mae pess = new Mae();

            //Console.WriteLine("Preencha as informações");
            //pess.Nome = CR();
            //pess.Idade = Convert.ToInt32(CR());
            //pess.Rua = CR();
            //pess.Cidade = CR();
            //pess.Estado = CR();

            //Console.WriteLine("Nome do conjugê se houver | n - não tem");
            //string opcao = CR();
            //if (opcao != "n")
            //{
            //    pess.Conjuge = opcao;
            //}
            //Console.WriteLine("Tem filhos?\nSe sim, quantos? | n - não tem");
            //opcao = CR();
            //if (opcao != "n")
            //{
            //    pess.QtdFilhos = Convert.ToInt32(opcao);
            //}

            //Console.WriteLine("*INFORMAÇÕES:*");
            //Console.WriteLine("Nome: {0} Idade: {1}", pess.Nome, pess.Idade);
            //Console.WriteLine("Rua: {0} Cidade: {1} Estado: {2}", pess.Rua, pess.Cidade, pess.Estado);
            //Console.WriteLine("Nome do Conjugê: {0} Filhos: {1}", pess.Conjuge, pess.QtdFilhos);

            //while (true)
            //{
            //    Console.WriteLine("Deseja fazer alguma alteração?\ns - sim | n - não");
            //    opcao = CR();
            //    if (opcao == "n")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Qual informação você deseja alterar?");
            //    Console.WriteLine("1 - Nome");
            //    Console.WriteLine("2 - Idade");
            //    Console.WriteLine("3 - Rua");
            //    Console.WriteLine("4 - Cidade");
            //    Console.WriteLine("5 - Estado");
            //    Console.WriteLine("6 - Nome do Conjugê");
            //    Console.WriteLine("7 - Filhos");
            //    int escolha = Convert.ToInt32(CR());
            //    switch (escolha)
            //    {
            //        case 1:
            //            pess.Nome = CR();
            //            break;
            //        case 2:
            //            pess.Idade = Convert.ToInt32(CR());
            //            break;
            //        case 3:
            //            pess.Rua = CR();
            //            break;
            //        case 4:
            //            pess.Cidade = CR();
            //            break;
            //        case 5:
            //            pess.Estado = CR();
            //            break;
            //        case 6:
            //            pess.Conjuge = CR();
            //            break;
            //        case 7:
            //            pess.QtdFilhos = Convert.ToInt32(CR());
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine("*INFORMAÇÕES:*");
            //Console.WriteLine("Nome: {0} Idade: {1}", pess.Nome, pess.Idade);
            //Console.WriteLine("Rua: {0} Cidade: {1} Estado: {2}", pess.Rua, pess.Cidade, pess.Estado);
            //Console.WriteLine("Nome do Conjugê: {0} Filhos: {1}", pess.Conjuge, pess.QtdFilhos);

            //// LISTA 02 ----------------------------
            //// Exec 01
            //// a)
            //List<Casa> house = new List<Casa>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Casa home = new Casa();
            //    Console.WriteLine("Preencha as informações do imóvel:");
            //    Console.WriteLine("Nome do dono");
            //    home.NomeDoDono = CR();
            //    Console.WriteLine("Quantidade de quartos");
            //    home.QtdQuartos = Convert.ToInt32(CR());
            //    Console.WriteLine("Data da construção");
            //    home.DataDeConstrucao = CR();
            //    Console.WriteLine("Informe o endereço do imóvel");
            //    home.Rua = CR();
            //    home.Cidade = CR();
            //    home.Estado = CR();

            //    house.Add(home);
            //}

            //SortManualImovel(house);

            //foreach (var item in house)
            //{
            //    Console.WriteLine("---------------//-------------");
            //    Console.WriteLine("{0} {1} {2}",item.NomeDoDono, item.QtdQuartos, item.DataDeConstrucao);
            //    Console.WriteLine("{0} {1} {2}", item.Rua, item.Cidade, item.Estado);
            //}

            //// b)
            //Hotel apart = new Hotel();

            //Console.WriteLine("Informe o endereço do hotel");
            //apart.Rua = CR();
            //apart.Cep = CR();
            //apart.Cidade = CR();
            //apart.Estado = CR();
            //Console.WriteLine("Qual a quantidade de apartamentos existentes no hotel?");
            //apart.QtdApartamentos = Convert.ToInt32(CR());
            //bool[] vagas = new bool[apart.QtdApartamentos];
            //apart.Apartamentos = vagas;

            //for (int i = 0; i < apart.Apartamentos.Length; i++)
            //{
            //    apart.Apartamentos[i] = true;
            //}

            //while (true)
            //{
            //    Console.WriteLine("A pessoa está entrando ou saindo?");
            //    Console.WriteLine("1 - Entrando");
            //    Console.WriteLine("2 - Saindo");
            //    Console.WriteLine("3 - Encerrar o programa");

            //    int resposta = Convert.ToInt32(CR());
            //    if (resposta == 1)
            //    {

            //        bool cheio = true;
            //        for (int i = 0; i < apart.Apartamentos.Length; i++)
            //        {
            //            if (apart.Apartamentos[i] == true)
            //            {
            //                apart.Apartamentos[i] = false;
            //                cheio = false;
            //                Console.WriteLine("Apartamento disponível");
            //                break;
            //            }
            //        }
            //        if (cheio)
            //        {
            //            Console.WriteLine("Nenhum apartamento livre");
            //        }
            //        Console.WriteLine("Pressione enter");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if (resposta == 2)
            //    {                    
            //        for (int i = 0; i < apart.Apartamentos.Length; i++)
            //        {
            //            if (apart.Apartamentos[i] == false)
            //            {
            //                apart.Apartamentos[i] = true;
            //                Console.WriteLine("Apartamento liberado.");
            //                break;
            //            }
            //        }
            //        Console.WriteLine("Pressione enter");
            //        Console.ReadLine();
            //        Console.Clear();
            //    }
            //    else if(resposta == 3)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("OPÇÃO INVÁLIDA");
            //    }
            //}

            //// LISTA DESAFIO ---------------
            //// Exec 01
            //// a)
            //Ciclista bike = new Ciclista();
            //Console.WriteLine("Insira o nome do ciclista");
            //bike.Nome = CR();
            //Console.WriteLine("Insira a distância a ser percorrida em metros");
            //bike.DistanciaASerPercorrida = Convert.ToDouble(CR());
            //Console.WriteLine("Insira a velocidade em m/s");
            //bike.Velocidade = Convert.ToDouble(CR());
            //double tempo = bike.DistanciaASerPercorrida / bike.Velocidade;
            //Console.WriteLine("O tempo total em segundos será de " + tempo + " segundos");

            //double horas = tempo / 3600;
            //double resto = tempo % 3600;
            //double minutos = resto / 60;
            //double segundos = resto % 60;

            //horas = Math.Round(horas, 0);
            //minutos = Math.Round(minutos, 0);

            //Console.WriteLine();
            //Console.WriteLine(horas + " hora(s)");
            //Console.WriteLine(minutos + " minuto(s)");
            //Console.WriteLine(segundos + " segundo(s)");

            //// b)
            //Ciclista bike = new Ciclista();
            //Random ran = new Random();
            //Console.WriteLine("Insira o nome do ciclista");
            //bike.Nome = CR();
            //bike.DistanciaASerPercorrida = ran.Next(500, 2001);
            //bike.Velocidade = ran.Next(13, 26);

            //double tempo = bike.DistanciaASerPercorrida / bike.Velocidade;
            //Console.WriteLine("{0}m - {1}m/s", bike.DistanciaASerPercorrida, bike.Velocidade);
            //Console.WriteLine("O tempo total em segundos será de " + tempo + " segundos");

            //double horas = tempo / 3600;
            //double resto = tempo % 3600;
            //double minutos = resto / 60;
            //double segundos = resto % 60;

            //horas = Math.Round(horas, 0);
            //minutos = Math.Round(minutos, 0);
            //segundos = Math.Round(segundos, 0);
            //Console.WriteLine();
            //Console.WriteLine(horas + " hora(s)");
            //Console.WriteLine(minutos + " minuto(s)");
            //Console.WriteLine(segundos + " segundo(s)");

            //// c)            
            //List<Ciclista> pedal = new List<Ciclista>();
            //for (int i = 0; i < 4; i++)
            //{
            //    Ciclista bike = new Ciclista();
            //    Console.WriteLine("Insira o nome do ciclista");
            //    bike.Nome = CR();
            //    Console.WriteLine("Distância percorrida");
            //    bike.DistanciaASerPercorrida = Convert.ToDouble(CR());
            //    Console.WriteLine("Velocidade média");
            //    bike.Velocidade = Convert.ToDouble(CR());                
            //    pedal.Add(bike);
            //}

            //SortManualBike(pedal);

            //for (int i = 0; i < pedal.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + " lugar:");
            //    Console.WriteLine(pedal[i].Nome);
            //    Console.WriteLine("Tempo: " + Math.Round((pedal[i].DistanciaASerPercorrida / pedal[i].Velocidade),0) + " segundos");
            //}

            //// DESAFIO CORRIGIDO --------------------------------------------------------------------
            //// 1 a)
            //Console.WriteLine("Preencha um ciclista");
            //Ciclista cic = new Ciclista();
            //cic.Nome = CR();
            //cic.DistanciaASerPercorrida = Convert.ToDouble(CR());
            //cic.Velocidade = Convert.ToDouble(CR());
            //Console.WriteLine("O tempo será de: ");
            //Console.WriteLine("{0:#.##} segundos ", cic.DistanciaASerPercorrida/cic.Velocidade);

            //// b)
            //Random ran = new Random();
            //Console.WriteLine("Preencha um ciclista");
            //Ciclista cic = new Ciclista();
            //cic.Nome = CR();
            //cic.DistanciaASerPercorrida = ran.Next(500, 2000 + 1);
            //cic.Velocidade = ran.Next(13, 25 + 1);
            //Console.WriteLine("{0}  {1}", cic.DistanciaASerPercorrida, cic.Velocidade);
            //Console.WriteLine("O tempo será de: ");
            //Console.WriteLine("{0:#.##} segundos ", cic.DistanciaASerPercorrida / cic.Velocidade);

            //// c)
            //Console.WriteLine("Qual a distância que os ciclistas percorrerão");
            //double distancia = Convert.ToDouble(CR());
            //List<Ciclista> cic = new List<Ciclista>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Preencha este ciclista");
            //    Ciclista temp = new Ciclista();
            //    temp.Nome = CR();
            //    temp.Velocidade = Convert.ToDouble(CR());
            //    temp.DistanciaASerPercorrida = distancia;
            //    cic.Add(temp);
            //}
            //SortManualCiclista(cic);
            //foreach (var item in cic)
            //{
            //    Console.WriteLine("{0} {1}", item.Nome,(item.DistanciaASerPercorrida/item.Velocidade));
            //}





        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        // Exec 1 b)
        public static void SortManual(List<Carro> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (lista[j - 1].CavalosVapor < lista[j].CavalosVapor)
                    {
                        Carro temp = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = temp;
                    }
                }
            }
        }
        // LISTA 02
        //EXEC1
        public static void SortManualImovel(List<Casa> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (lista[j - 1].QtdQuartos < lista[j].QtdQuartos)
                    {
                        Casa temp = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = temp;
                    }
                }
            }
        }
        public static void SortManualBike(List<Ciclista> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if ((lista[j - 1].DistanciaASerPercorrida / lista[j - 1].Velocidade) > (lista[j].DistanciaASerPercorrida / lista[j].Velocidade))
                    {
                        Ciclista temp = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = temp;
                    }
                }
            }
        }
        public static void SortManualCiclista(List<Ciclista> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    double x = lista[j].DistanciaASerPercorrida / lista[j].Velocidade;
                    double y = lista[j - 1].DistanciaASerPercorrida / lista[j - 1].Velocidade;
                    if(y > x)
                    {
                        Ciclista temp = lista[j];
                        lista[j] = lista[j - 1];
                        lista[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

    }
}
