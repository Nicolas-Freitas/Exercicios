using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Leao : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name + " pode caminhar";
        }
    }
}