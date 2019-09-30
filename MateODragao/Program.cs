using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {

                System.Console.WriteLine("--------------------------------------------------------------------");
                System.Console.WriteLine("                        Mate o Dragão");
                System.Console.WriteLine("--------------------------------------------------------------------");

                System.Console.WriteLine(" 1 - Iniciar jogo");
                System.Console.WriteLine(" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Ladino ladino = new Ladino();
                        ladino.Nome = "Gabrielo";
                        ladino.Sobrenome = "Gabrielo";
                        ladino.CidadeNatal = "Ecaterimburgo";
                        ladino.DataNascimento = DateTime.Parse("01/01/01");
                        ladino.FerramentaAtaque = "Peixeira";
                        ladino.FerramenteProtecao = "Armadura leve feita com escamas de dragão";
                        ladino.Forca = 2;
                        ladino.Destreza = 3;
                        ladino.Inteligencia = 2;
                        ladino.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Dovahkiin";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INICIO - Primeiro Diálogo */
                        System.Console.WriteLine($"{ladino.Nome.ToUpper()}: {dragao.Nome}, Bom dia meu consagrado ta afim de tirar um x1 sem perder a amizade!!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Certamente meu bom, vamo lá tira essa luta incrivel \n");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        /* FIM - Primeiro Diálogo */

                        /* INICIO - Segundo Diálogo */
                        Console.Clear();
                        System.Console.WriteLine($"{ladino.Nome.ToUpper()}: Eu sou {ladino.Nome}! Da casa {ladino.Sobrenome}, mlk do crl");
                        System.Console.WriteLine($"{ladino.Nome.ToUpper()}: Vim de {ladino.CidadeNatal}! pra te fumar filhodaputa");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Foda-se mermão acéfalo do caralho");
                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();
                        /* FIM - Segundo Diálogo */
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = ladino.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueLadino = ladino.Forca > ladino.Inteligencia ? ladino.Forca + ladino.Destreza : ladino.Inteligencia + ladino.Destreza;

                        /* INICIO = do FIGHT */
                        if (jogadorAtacaPrimeiro)
                        {
                            Console.Clear();

                            System.Console.WriteLine("-------------------------------------------Turno do Jogador-------------------------------------------");
                            System.Console.WriteLine("Escolha sua ação:");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhajogador = Console.ReadLine();

                            switch (opcaoBatalhajogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    int ladinoDestrezaTotal = ladino.Destreza + numeroAleatorioJogador;
                                    int DragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (ladinoDestrezaTotal > DragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{ladino.Nome.ToUpper()}: Toma essa fumante do crl vai la fumar seu narguines");
                                        dragao.Vida -= poderAtaqueLadino + 5;
                                        System.Console.WriteLine("-------------------------");
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Ladino: {ladino.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}): Plebe inferior nem acertar me consegue vai la dormir baiano");
                                    }
                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine($"{ladino.Nome.ToUpper()}: ih carai deu B.O vou la esticar minha rede");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: bah vai la esticar sua rede baiano");
                                    break;
                            }

                            System.Console.WriteLine("Aperte ENTER  para prosseguir");
                            Console.ReadLine();

                            while (dragao.Vida > 0 && ladino.Vida > 0 && jogadorNaoCorreu)
                            {
                                Console.Clear();
                                System.Console.WriteLine("-----------------Turno do Dragão-----------------");
                                Random geradorNumeroAleatorio = new Random();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                int ladinoDestrezaTotal = ladino.Destreza + numeroAleatorioJogador;
                                int DragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (DragaoDestrezaTotal > ladinoDestrezaTotal)
                                {
                                    System.Console.WriteLine($"{ladino.Nome.ToUpper()}: O tu tem uma bala ai po");
                                    ladino.Vida -= dragao.Forca;
                                    System.Console.WriteLine("-------------------------");
                                    System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine($"HP Ladino: {ladino.Vida}");
                                }
                                else
                                {

                                    System.Console.WriteLine($"{ladino.Nome.ToUpper()}): Na calma irmão, no seu tempo");
                                }
                                System.Console.WriteLine();
                                System.Console.WriteLine("Aperte ENTER para prosseguir");
                                Console.ReadLine();
                                /* INICIO - Turno Jogador */
                                Console.Clear();
                                System.Console.WriteLine("-------------------------------------------Turno do Jogador-------------------------------------------");
                                System.Console.WriteLine("Escolha sua ação:");
                                System.Console.WriteLine(" 1 - Atacar");
                                System.Console.WriteLine(" 2 - Fugir");

                            opcaoBatalhajogador = Console.ReadLine();

                            switch (opcaoBatalhajogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);

                                    ladinoDestrezaTotal = ladino.Destreza + numeroAleatorioJogador;
                                    DragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (ladinoDestrezaTotal > DragaoDestrezaTotal)
                                    {
                                        System.Console.WriteLine($"{ladino.Nome.ToUpper()}: Toma essa fumante do crl vai la fumar seu narguines");
                                        dragao.Vida -= poderAtaqueLadino + 5;
                                        System.Console.WriteLine("-------------------------------------------------------------------------------------------------");
                                        System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine($"HP Ladino: {ladino.Vida}");
                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}): Plebe inferior nem acertar me consegue vai la dormir baiano");
                                    }

                                    if(ladino.Vida <= 0)
                                    {
                                        System.Console.WriteLine("kkk noob tenta de novo");
                                    }
                                    if (dragao.Vida <= 0) {
                                        System.Console.WriteLine("Boa");
                                    }
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                                    Console.ReadLine();
                                    
                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine($"{ladino.Nome.ToUpper()}: ih carai deu B.O vou la esticar minha rede");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: bah vai la esticar sua rede baiano");
                                    break;
                            }

                            System.Console.WriteLine("Aperte ENTER  para prosseguir");
                            Console.ReadLine();
                                /* FIM - Turno Jogador */
                            }
                        }
                        /* FIM = do FIGHT */

                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        break;

                    default:
                        System.Console.WriteLine("Comando desconhecido");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }
    }
}
