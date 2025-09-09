using System;
using System.Runtime.Intrinsics.Arm;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome1, nome2, jogadaM1, jogadaM2, jogadaM3, escolha, jogadaJ1, jogadaJ2, jogadaJ3, jogadaJ4, jogadaJ5, jogadaJ6;
            int numeroSorteado, numeroSorteado2, numeroSorteado3, pontosJ1, pontosJ2, empate, derrotaJ1, derrotaJ12, derrotaM, derrotaJ2, vitoriaJ1p1, vitoriaM1p1, vitoriaJ1p2, vitoriaM1p2, vitoriaJ1p3,
                vitoriaM1p3, vitoriaJ2p1, vitoriaJ2p2, vitoriaJ2p3, derrotaJ1p1, derrotaM1p1, derrotaJ1p2, derrotaM1p2, derrotaJ1p3, derrotaM1p3, derrotaJ2p1, derrotaJ2p2, derrotaJ2p3, empate1,
                empate2, empate3, maquina, jogo;


            jogo = 0;
            derrotaM = 0;
            empate = 0;
            empate1 = 0;
            pontosJ2 = 0;
            pontosJ1 = 0;
            empate2 = 0;
            empate3 = 0;
            vitoriaJ1p1 = 0;
            vitoriaM1p1 = 0;
            vitoriaJ1p2 = 0;
            vitoriaM1p2 = 0;
            vitoriaJ1p3 = 0;
            vitoriaM1p3 = 0;
            vitoriaJ2p1 = 0;
            vitoriaJ2p2 = 0;
            vitoriaJ2p3 = 0;
            derrotaJ1p1 = 0;
            derrotaM1p1 = 0;
            derrotaJ1p2 = 0;
            derrotaM1p2 = 0;
            derrotaJ1p3 = 0;
            derrotaM1p3 = 0;
            derrotaJ2p1 = 0;
            derrotaJ2p2 = 0;
            derrotaJ2p2 = 0;
            derrotaJ2p3 = 0;



            Console.WriteLine("Informe o seu nome para começar a jogar Jokenpô!!");
            nome1 = Console.ReadLine();


            do
            {

                Console.WriteLine("Se deseja jogar contra algum jogador, digite J, se quiser contra a máquina digite M.");
                escolha = Console.ReadLine();


                if (escolha == "M")
                {
                    Console.Clear();
                    Console.WriteLine("Escolha a sua jogada (pedra, papel ou tesoura).");
                    jogadaM1 = Console.ReadLine();

                    Random sorteio = new Random();

                    numeroSorteado = sorteio.Next(1, 4);

                    Console.WriteLine("O número 1 é igual à pedra");
                    Console.WriteLine("O número 2 é igual à tesoura");
                    Console.WriteLine("O número 3 é igual à papel");

                    Console.WriteLine("A jogada do computador foi: " + numeroSorteado);

                    //Jogada máquina-papel

                    if ((numeroSorteado == 3) && (jogadaM1 == "tesoura"))
                    {
                        vitoriaJ1p1 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p1 = +1;
                    }

                    if ((numeroSorteado == 3) && (jogadaM1 == "papel"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate1 = +1;
                    }

                    if ((numeroSorteado == 3) && (jogadaM1 == "pedra"))
                    {
                        vitoriaM1p1 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p1 = +1;
                    }

                    //Jogada maquina-tesoura

                    if ((numeroSorteado == 2) && (jogadaM1 == "tesoura"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate1 = +1;
                    }

                    if ((numeroSorteado == 2) && (jogadaM1 == "papel"))
                    {
                        vitoriaM1p1 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1 = +1;
                    }

                    if ((numeroSorteado == 2) && (jogadaM1 == "pedra"))
                    {
                        vitoriaJ1p1 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p1 = +1;
                    }

                    // Jogada máquina-pedra

                    if ((numeroSorteado == 1) && (jogadaM1 == "tesoura"))
                    {
                        vitoriaM1p1 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p1 = +1;
                    }

                    if ((numeroSorteado == 1) && (jogadaM1 == "papel"))
                    {
                        vitoriaJ1p1 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p1 = +1;
                    }

                    if ((numeroSorteado == 1) && (jogadaM1 == "pedra"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate1 = +1;
                    }

                    Console.WriteLine("Aperter ENTER para começar a segunda partida");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Segunda partida");

                    Console.WriteLine("Escolha a sua jogada (pedra, papel ou tesoura).");
                    jogadaM2 = Console.ReadLine();

                    Random numerosorteio = new Random();

                    numeroSorteado2 = sorteio.Next(1, 4);

                    Console.WriteLine("O número 1 é igual à pedra");
                    Console.WriteLine("O número 2 é igual à tesoura");
                    Console.WriteLine("O número 3 é igual à papel");

                    Console.WriteLine("A jogada do computador foi: " + numeroSorteado2);

                    //Jogada máquina-papel

                    if ((numeroSorteado2 == 3) && (jogadaM2 == "tesoura"))
                    {
                        vitoriaJ1p2 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p2 = +1;
                    }

                    if ((numeroSorteado2 == 3) && (jogadaM2 == "papel"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate2 = +1;
                    }

                    if ((numeroSorteado2 == 3) && (jogadaM2 == "pedra"))
                    {
                        vitoriaM1p2 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaM1p2 = +1;
                    }

                    //Jogada maquina-tesoura

                    if ((numeroSorteado2 == 2) && (jogadaM2 == "tesoura"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate2 = +1;
                    }

                    if ((numeroSorteado2 == 2) && (jogadaM2 == "papel"))
                    {
                        vitoriaM1p2 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p2 = +1;
                    }

                    if ((numeroSorteado2 == 2) && (jogadaM2 == "pedra"))
                    {
                        vitoriaJ1p2 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p2 = +1;
                    }

                    // Jogada máquina-pedra

                    if ((numeroSorteado2 == 1) && (jogadaM2 == "tesoura"))
                    {
                        vitoriaM1p2 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p2 = +1;
                    }

                    if ((numeroSorteado2 == 1) && (jogadaM2 == "papel"))
                    {
                        vitoriaJ1p2 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p2 = +1;
                    }

                    if ((numeroSorteado2 == 1) && (jogadaM2 == "pedra"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate2 = +1;
                    }

                    Console.WriteLine("Aperter ENTER para começar a última partida");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Última partida");

                    Console.WriteLine("Escolha a sua jogada (pedra, papel ou tesoura).");
                    jogadaM3 = Console.ReadLine();

                    Random nr_sorteio = new Random();

                    numeroSorteado3 = sorteio.Next(1, 4);

                    Console.WriteLine("O número 1 é igual à pedra");
                    Console.WriteLine("O número 2 é igual à tesoura");
                    Console.WriteLine("O número 3 é igual à papel");

                    Console.WriteLine("A jogada do computador foi: " + numeroSorteado3);

                    //Jogada máquina-papel

                    if ((numeroSorteado3 == 3) && (jogadaM3 == "tesoura"))
                    {
                        vitoriaJ1p3 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p3 = +1;
                    }

                    if ((numeroSorteado3 == 3) && (jogadaM3 == "papel"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate3 = +1;
                    }

                    if ((numeroSorteado3 == 3) && (jogadaM3 == "pedra"))
                    {
                        vitoriaM1p3 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p3 = +1;
                    }

                    //Jogada maquina-tesoura

                    if ((numeroSorteado3 == 2) && (jogadaM3 == "tesoura"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate3 = +1;
                    }

                    if ((numeroSorteado3 == 2) && (jogadaM3 == "papel"))
                    {
                        vitoriaM1p3 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p3 = +1;
                    }

                    if ((numeroSorteado3 == 2) && (jogadaM3 == "pedra"))
                    {
                        vitoriaJ1p3 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p3 = +1;
                    }

                    // Jogada máquina-pedra

                    if ((numeroSorteado3 == 1) && (jogadaM3 == "tesoura"))
                    {
                        vitoriaM1p3 = +1;
                        Console.WriteLine("A maquina ganhou!");
                        derrotaJ1p3 = +1;
                    }

                    if ((numeroSorteado3 == 1) && (jogadaM3 == "papel"))
                    {
                        vitoriaJ1p3 = +1;
                        Console.WriteLine("O " + nome1 + " venceu a partida!");
                        derrotaM1p3 = +1;
                    }

                    if ((numeroSorteado3 == 1) && (jogadaM3 == "pedra"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate3 = +1;
                    }
                    Console.ReadKey();
                    Console.Clear();

                    pontosJ1 = vitoriaJ1p1 + vitoriaJ1p2 + vitoriaJ1p3;
                    derrotaJ1 = derrotaJ1p1 + derrotaJ1p2 + derrotaJ1p3;
                    empate = empate1 + empate2 + empate3;
                    derrotaM = derrotaM1p1 + derrotaM1p2 + derrotaM1p3;
                    maquina = vitoriaM1p1 + vitoriaM1p2 + vitoriaM1p3;

                    Console.WriteLine("Ranking:");
                    Console.WriteLine(nome1);
                    Console.WriteLine("vitórias: " + pontosJ1);
                    Console.WriteLine("derrotas: " + derrotaJ1);

                    Console.WriteLine("Pontos da maquina: ");
                    Console.WriteLine("vitórias: " + maquina);

                    Console.WriteLine("número de empates: " + empate);
                }

                if (escolha == "J")
                {
                    Console.Clear();
                    Console.WriteLine("Informe o nome do segundo jogador!!");
                    nome2 = Console.ReadLine();
                    Console.WriteLine(nome1 + " insira sua primeira jogada (pedra, papel ou tesoura).");
                    jogadaJ1 = Console.ReadLine();
                    Console.WriteLine(nome2 + " insira sua primeira jogada (pedra, papel ou tesoura).");
                    jogadaJ2 = Console.ReadLine();

                    // Jogada Jogador1-papel

                    if ((jogadaJ1 == "papel") && (jogadaJ2 == "pedra"))
                    {
                        vitoriaJ1p1 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p1 = +1;
                    }

                    if ((jogadaJ1 == "papel") && (jogadaJ2 == "papel"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate1 = +1;
                    }

                    if ((jogadaJ1 == "papel") && (jogadaJ2 == "tesoura"))
                    {
                        vitoriaJ2p1 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ1p1 = +1;
                    }

                    // Jogada Jogador1-pedra

                    if ((jogadaJ1 == "pedra") && (jogadaJ2 == "pedra"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate1 = +1;
                    }

                    if ((jogadaJ1 == "pedra") && (jogadaJ2 == "papel"))
                    {
                        vitoriaJ2p1 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ2p1 = +1;
                    }

                    if ((jogadaJ1 == "pedra") && (jogadaJ2 == "tesoura"))
                    {
                        vitoriaJ1p1 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p1 = +1;
                    }

                    //Jogada Jogador1-tesoura

                    if ((jogadaJ1 == "tesoura") && (jogadaJ2 == "pedra"))
                    {
                        vitoriaJ2p1 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ2p1 = +1;
                    }

                    if ((jogadaJ1 == "tesoura") && (jogadaJ2 == "papel"))
                    {
                        vitoriaJ1p1 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p1 = +1;
                    }

                    if ((jogadaJ1 == "tesoura") && (jogadaJ2 == "tesoura"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate1 = +1;
                    }

                    Console.WriteLine("Aperter ENTER para começar a segunda partida");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Segunda partida");

                    Console.WriteLine(nome1 + " insira sua primeira jogada (pedra, papel ou tesoura).");
                    jogadaJ3 = Console.ReadLine();
                    Console.WriteLine(nome2 + " insira sua primeira jogada (pedra, papel ou tesoura).");
                    jogadaJ4 = Console.ReadLine();

                    // Jogada Jogador1-papel

                    if ((jogadaJ3 == "papel") && (jogadaJ4 == "pedra"))
                    {
                        vitoriaJ2p2 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p2 = +1;
                    }

                    if ((jogadaJ3 == "papel") && (jogadaJ4 == "papel"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate2 = +1;
                    }

                    if ((jogadaJ3 == "papel") && (jogadaJ4 == "tesoura"))
                    {
                        vitoriaJ2p2 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ2p2 = +1;
                    }

                    // Jogada Jogador1-pedra

                    if ((jogadaJ3 == "pedra") && (jogadaJ4 == "pedra"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate2 = +1;
                    }

                    if ((jogadaJ3 == "pedra") && (jogadaJ4 == "papel"))
                    {
                        vitoriaJ2p2 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ2p2 = +1;
                    }

                    if ((jogadaJ3 == "pedra") && (jogadaJ4 == "tesoura"))
                    {
                        vitoriaJ1p2 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p2 = +1;
                    }

                    //Jogada Jogador1-tesoura

                    if ((jogadaJ3 == "tesoura") && (jogadaJ4 == "pedra"))
                    {
                        vitoriaJ2p2 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ1p2 = +1;
                    }

                    if ((jogadaJ3 == "tesoura") && (jogadaJ4 == "papel"))
                    {
                        vitoriaJ1p2 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p2 = +1;
                    }

                    if ((jogadaJ3 == "tesoura") && (jogadaJ4 == "tesoura"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate2 = +1;
                    }

                    Console.WriteLine("Aperter ENTER para começar a última partida");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Útima partida");

                    Console.WriteLine(nome1 + " insira sua primeira jogada (pedra, papel ou tesoura).");
                    jogadaJ5 = Console.ReadLine();
                    Console.WriteLine(nome2 + " insira sua primeira jogada (pedra, papel ou tesoura).");
                    jogadaJ6 = Console.ReadLine();

                    // Jogada Jogador1-papel

                    if ((jogadaJ5 == "papel") && (jogadaJ6 == "pedra"))
                    {
                        vitoriaJ1p3 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p3 = +1;
                    }

                    if ((jogadaJ5 == "papel") && (jogadaJ6 == "papel"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate3 = +1;
                    }

                    if ((jogadaJ5 == "papel") && (jogadaJ6 == "tesoura"))
                    {
                        vitoriaJ2p3 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ2p3 = +1;
                    }

                    // Jogada Jogador1-pedra

                    if ((jogadaJ5 == "pedra") && (jogadaJ6 == "pedra"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate3 = +1;
                    }

                    if ((jogadaJ5 == "pedra") && (jogadaJ6 == "papel"))
                    {
                        vitoriaJ2p3 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ1p3 = +1;
                    }

                    if ((jogadaJ5 == "pedra") && (jogadaJ6 == "tesoura"))
                    {
                        vitoriaJ1p3 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p3 = +1;
                    }

                    //Jogada Jogador1-tesoura

                    if ((jogadaJ5 == "tesoura") && (jogadaJ6 == "pedra"))
                    {
                        vitoriaJ2p3 = +1;
                        Console.WriteLine(nome2 + " venceu");
                        derrotaJ1p3 = +1;
                    }

                    if ((jogadaJ5 == "tesoura") && (jogadaJ6 == "papel"))
                    {
                        vitoriaJ1p3 = +1;
                        Console.WriteLine(nome1 + " venceu");
                        derrotaJ2p3 = +1;
                    }

                    if ((jogadaJ5 == "tesoura") && (jogadaJ6 == "tesoura"))
                    {
                        Console.WriteLine("Que pena, deu empate!");
                        empate3 = +1;
                    }
                        Console.ReadKey();
                    Console.Clear();

                    derrotaJ12 = derrotaJ2p1 + derrotaJ2p2 + derrotaJ2p3;
                    derrotaJ2 = derrotaJ2p1 + derrotaJ2p2 + derrotaJ2p3;
                    pontosJ2 = vitoriaJ2p1 + vitoriaJ2p2 + vitoriaJ2p3;
                    pontosJ1 = vitoriaJ1p1 + vitoriaJ1p2 + vitoriaJ1p3;
                    empate = empate1 + empate2 + empate3;

                    Console.WriteLine("Ranking:");
                    Console.WriteLine(nome1);
                    Console.WriteLine("vitórias: " + pontosJ1);
                    Console.WriteLine("derrotas: " + derrotaJ12);

                    Console.WriteLine(nome2);
                    Console.WriteLine("vitórias: " + pontosJ2);
                    Console.WriteLine("derrotas: " + derrotaJ2);

                    Console.WriteLine("número de empates: " + empate);

                    Console.WriteLine("Chegamos ao final, digite 1 para continuar ou 0 para parar.");
                    jogo = int.Parse (Console.ReadLine());

                }
            }

            while (jogo != 0);



        }
    }
}