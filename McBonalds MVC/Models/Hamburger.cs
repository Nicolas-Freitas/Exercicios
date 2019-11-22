using Microsoft.Extensions.Primitives;

namespace McBonalds_MVC.Models
{
    public class Hamburger : Produto
    {
        public Hamburger()
        {

        }
        public Hamburger(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}