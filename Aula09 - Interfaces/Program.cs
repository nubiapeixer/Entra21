using System;
using System.Collections.Generic;

namespace _9._Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Exec 01
            //List<Pessoa> people = new List<Pessoa>();

            //while (true)
            //{
            //    Console.WriteLine("Insira uma pessoa ou enter para encerrar");
            //    Pessoa pes = new Pessoa();
            //    pes.Nome = Console.ReadLine();
            //    if (pes.Nome == "")
            //    {
            //        Console.WriteLine("Agradecemos pela preferência!");
            //        break;
            //    }
            //    pes.Idade = Convert.ToInt32(Console.ReadLine());
            //    pes.Cpf = Console.ReadLine();

            //    bool insere = true;
            //    foreach (var item in people)
            //    {
            //        if (item.Cpf == pes.Cpf)
            //        {
            //            insere = false;
            //            break;
            //        }
            //    }
            //    if (insere)
            //    {
            //        Console.WriteLine("Pessoa Adicionada");
            //        people.Add(pes);
            //    }
            //    else
            //    {
            //        Console.WriteLine("CPF já existente, pessoa não adicionada");
            //    }
            //    MostraPessoas(people);
            //}

            //// Exec 02
            //List<Hotel> hoteis = new List<Hotel>();
            //Random ran = new Random();

            //Console.WriteLine("Insira os nomes dos hotéis");
            //for (int i = 0; i < 2; i++)
            //{
            //    Hotel cliente = new Hotel();
            //    cliente.Nome = Console.ReadLine();
            //    cliente.QtdQuartos = ran.Next(1, 50 + 1);
            //    cliente.QtdQuartosOcupados = ran.Next(0, cliente.QtdQuartos + 1);
            //    cliente.QtdQuartosDisponiveis = cliente.QtdQuartos - cliente.QtdQuartosOcupados;
            //    hoteis.Add(cliente);
            //}

            //for (int i = 0; i < hoteis.Count; i++)
            //{
            //    Console.WriteLine("HOTÉIS");
            //    Console.Write("---> " + (i + 1) + " ");
            //    Console.WriteLine(hoteis[i].Nome);
            //    Console.WriteLine("-------------//-------------");
            //}
            //Console.WriteLine("Em qual você deseja se hospedar?");
            //int escolha = Convert.ToInt32(Console.ReadLine());
            //escolha--;

            //if (hoteis[escolha].QtdQuartosOcupados == hoteis[escolha].QtdQuartos)
            //{
            //    Console.WriteLine("Hotel está lotado:");
            //    Console.WriteLine("Hotel " + hoteis[escolha].Nome);
            //    Console.WriteLine("Quantidade de quartos disponíveis " + hoteis[escolha].QtdQuartos);
            //    Console.WriteLine("Quantidade de quartos ocupados " + hoteis[escolha].QtdQuartosOcupados);

            //    Console.WriteLine("Sugestão para hospedagem:");
            //    MostraHotel(hoteis);

            //    for (int i = 0; i < hoteis.Count; i++)
            //    {
            //        Console.WriteLine("Hotel: " + hoteis[0].Nome);
            //        Console.WriteLine("Quantidade de quartos disponíveis: " + hoteis[0].QtdQuartosDisponiveis);
            //        Console.WriteLine("Quantidade de quartos ocupados: " + hoteis[0].QtdQuartosOcupados);
            //        Console.WriteLine("Total de quartos: " + hoteis[0].QtdQuartos);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hotel escolhido: " + hoteis[escolha].Nome);
            //    Console.WriteLine("Quantidade de quartos disponíveis: " + hoteis[escolha].QtdQuartosDisponiveis);
            //    Console.WriteLine("Quantidade de quartos ocupados: " + hoteis[escolha].QtdQuartosOcupados);
            //    Console.WriteLine("Total de quartos: " + hoteis[escolha].QtdQuartos);
            //}

            //// Exec 03
            List<string> crimes = new List<string>();

            Advogado adv = new Advogado();

            Console.WriteLine("Insira o nome");
            adv.Nome = CR();
            Console.WriteLine("Insira a idade");
            adv.Idade = CRI();
            Console.WriteLine("Insira o CPF");
            adv.Cpf = CR();

            Console.WriteLine("Insira os crimes cometidos e depois digite *sair*");
            while (true)
            {
                string crime = CR();
                if (crime == "sair")
                {
                    break;
                }
                crimes.Add(crime);
            }
            adv.ListaCrimes = crimes;

            double sentenca = 0;

            for (int i = 0; i < adv.ListaCrimes.Count; i++)
            {
                switch (adv.ListaCrimes[i])
                {
                    case "Assalto":
                        sentenca += 3;
                        break;
                    case "Furto":
                        sentenca += 2;
                        break;
                    case "Assassinato":
                        sentenca += 5.5;
                        break;
                    case "Assassinato seguido de roubo":
                        sentenca += 7;
                        break;
                    default:
                        break;
                }
            }
            adv.QtdAnosPreso = sentenca;
            Console.WriteLine("Insira a data de entrada na prisão");
            adv.DataPrisao = CR();

            Console.WriteLine("Enter para prosseguir");
            CR();
            Console.Clear();

            Console.WriteLine("INFORMAÇÕES:");
            Console.WriteLine("{0} {1} {2}", adv.Nome, adv.Idade, adv.Cpf);
            Console.WriteLine("Data de entrada na prisão: " + adv.DataPrisao);
            Console.WriteLine("Crimes Cometidos:");
            foreach (var item in adv.ListaCrimes)
            {
                Console.Write("--> ");
                Console.WriteLine(item);
            }
            Console.WriteLine(adv.QtdAnosPreso + " anos de prisão");



        }
        public static string CR()
        {
            return Console.ReadLine();
        }
        public static int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        // Exec 01
        public static void MostraPessoas(List<Pessoa> p)
        {
            foreach (var item in p)
            {
                Console.WriteLine("Nome : {0}", item.Nome);
                Console.WriteLine("Idade : {0}", item.Idade);
                Console.WriteLine(@"CPF : {0:000\.000\.000\-00}", Convert.ToInt64(item.Cpf));
                Console.WriteLine("----------------//---------------");               
            }
        }
        // Exec 02
        public static void MostraHotel(List<Hotel> h)
        {
            for (int i = 0; i < h.Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (h[j - 1].QtdQuartosDisponiveis < h[j].QtdQuartosDisponiveis)
                    {
                        Hotel temp = h[j];
                        h[j] = h[j - 1];
                        h[j - 1] = temp;
                    }
                }
            }



        }

    }
}
