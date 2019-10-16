using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models

{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Matendo ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }
    }
}