using System;
using System.Collections.Generic;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{

    enum ItensEnum : uint
    {
        GARRAFA = 1,
        GARRAFA_PET = 2,
        GUARDA_CHUVA = 3,
        LATINHA = 4,
        PAPELAO = 5,
        POTE_MANTEIGA = 6
    }

    enum CategoriaEnum : uint
    {
        INDEFINIDO,
        METAL,
        ORGANICO,
        PAPEL,
        PLASTICO,
        VIDRO
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(ItensEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesItens = new List<string>() {
                "    - 0                         ",
                "    - 1                         ",
                "    - 2                         ",
                "    - 3                         ",
                "    - 4                         ",
                "    - 5                         "
            };

            int opcaoItemSelecionada = 0;

            string menuBar = "======================================================";

            #endregion

            do
            {
                bool ItemEscolhido = false;
                #region Controla o menu dos itens.
                do
                {
                    Console.Clear();

                    System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("|              Seja bem-vindo(a) ao lixão            |");
                    System.Console.WriteLine("|          Escolha o lixo que deseja remover         |");
                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);

                    #region Troca a cor do menu.
                    for (int i = 0; i < opcoesItens.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if (opcaoItemSelecionada == i)
                        {
                            DestacarOpcao(opcoesItens[opcaoItemSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesItens[i].Replace(i.ToString(), titulo));
                        }
                    }

                    #region Lê a tecla pressionada pelo usuário e verifica a opção selecionada.
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoItemSelecionada = opcaoItemSelecionada == 0 ? opcaoItemSelecionada : --opcaoItemSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoItemSelecionada = opcaoItemSelecionada == opcoesItens.Count - 1 ? opcaoItemSelecionada : ++opcaoItemSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            ItemEscolhido = true;
                            break;
                    }
                    #endregion

                    #endregion

                } while (!ItemEscolhido);

                #endregion
            } while (!querSair);
        }

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}


/* 
    class Program
    {
        static void Main(string[] args)
        {
            string[] itensMenuPrincipal = Enum.GetNames(typeof(CategoriaEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));

            var opcoesFormacao = new List<string>() {
                "    - 0                         ",
                "    - 1                         "
            };
            string menuBar = "======================================================";

            Console.Clear();
            System.Console.WriteLine(menuBar);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("|              Seja bem-vindo(a) ao lixão            |");
            System.Console.WriteLine("|          Escolha o lixo que deseja remover         |");
            Console.ResetColor();
            System.Console.WriteLine(menuBar);    

            ExibirMenuDeLixos();
        }

        public static void ExibirMenuDeLixos()
        {
            var instrumentos = Enum.GetNames(typeof(ItensEnum));
            string menuLixosBorda = "======================================================";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine(menuLixosBorda);
            System.Console.WriteLine($"|{"", 52}|");
            System.Console.WriteLine($"|{"Lixos", 27}{"|", 26}");
            System.Console.WriteLine($"|{"", 52}|");
            System.Console.WriteLine(menuLixosBorda);
            Console.ResetColor ();
            
        }
    }
}
*/
