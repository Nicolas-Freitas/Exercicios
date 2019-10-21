using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Garrafa : Lixo, IVidro
    {
        public bool LixoVidro()
        {
            System.Console.WriteLine("|Lixeira : Vidro | Cor: Verde|");
            return true;
        }
    }
}