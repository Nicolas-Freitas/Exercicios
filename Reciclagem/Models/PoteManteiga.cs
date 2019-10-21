using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : Lixo, IPlastico
    {
        public bool LixoIndefinido()
        {
            System.Console.WriteLine("|Lixeira : Plástico | Cor: Vermelho|");
            return true;
        }
    }
}