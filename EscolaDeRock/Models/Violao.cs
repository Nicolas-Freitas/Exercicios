using System;
using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    class Violao : InstrumentoMusical, IMelodia, IHarmonia, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Tocar ritmo do violão");
            return true;
        }
        public bool TocarAcordes(){
            System.Console.WriteLine("Tocar Acordes ");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do teclado");
            return true;
        }
    }
}
