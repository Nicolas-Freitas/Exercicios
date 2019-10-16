using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeRock.Models{
    public class Bateria : InstrumentoMusical,IPercussao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Tocando a bateria");
            return true;
        }
    }
}