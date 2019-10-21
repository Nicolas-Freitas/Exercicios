using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : Lixo, IMetal
    {
        public bool LixoMetal()
        {
            System.Console.WriteLine("|Lixeira : Metal | Cor: Verde|");
            return true;
        }
    }
}