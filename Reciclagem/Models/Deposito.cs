using System.Collections.Generic;
namespace Reciclagem.Models
{
    public class Deposito
    {
            public static Dictionary<int, Lixo> Lixos = new Dictionary<int, Lixo>() {
            { 1, new Garrafa() },
            { 2, new GarrafaPET() },
            { 3, new GuardaChuva() },
            { 4, new Latinha() },
            { 5, new Papelao() },
            { 6, new PoteManteiga() },

        };
    }
}