using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Chimpanze : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + " sobe em árvore";
        }
    }
}