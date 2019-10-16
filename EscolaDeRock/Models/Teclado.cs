using System;
using System.Collections.Generic;
using System.Text;

using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Teclado");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do teclado");
            return true;
        }
    }
}