using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Golfinho : Animal, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name + " sabe nadar!";
        }
    }
}