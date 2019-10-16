using System;
using System.Collections.Generic;
using System.Text;
namespace EscolaDeRock

{
    public class InstrumentoMusical
    {
        string [] notas = { "Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};
        protected string TocarMusica (){
            int nota = new Random().Next(notas.Length - 1);
            return notas [nota];
        }
    }
}