using System;
using System.Collections.Generic;
using System.Text;
using EscolaDeRock.Models;

namespace EscolaDeRock
{

    class program
    {
        static void Main(string[] args){
            InstrumentoMusical generico = new InstrumentoMusical();
            System.Console.WriteLine("Generico: " + generico.TocarMusica());

            Violao violao1 = new Violao();
            System.Console.WriteLine("Violão: " + violao1.TocarMusica());
            violao1.TocarAcordes();


        }
    }
}