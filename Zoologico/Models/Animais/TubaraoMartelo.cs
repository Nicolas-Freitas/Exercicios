using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class TubaraoMartelo : Animal, IAquatico, IBranquiado
    {
        public string Nadar()
        {
            return this.GetType().Name + " consegue nadar!";
        }

        public string RespirarDebaixoDAgua()
        {
            return this.GetType().Name + " consegue respirar debaixo d'água!";
        }
    }
}