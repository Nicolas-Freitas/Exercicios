using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, IIndefinido
    {
        public bool LixoIndefinido()
        {
            System.Console.WriteLine("|Lixeira : Indefinido | Cor: Cinza|");
            return true;
        }
    }
}