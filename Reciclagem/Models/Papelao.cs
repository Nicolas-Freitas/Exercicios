using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : Lixo, IPlastico
    {
        public bool LixoIndefinido()
        {
            System.Console.WriteLine("|Lixeira : Papel | Cor: Azul|");
            return true;
        }
    }
}