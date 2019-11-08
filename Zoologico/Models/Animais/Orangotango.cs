using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Orangotango : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + " sobe em árvore";
        }
    }
}