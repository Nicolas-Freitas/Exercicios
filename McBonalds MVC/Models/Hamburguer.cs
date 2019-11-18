using Microsoft.Extensions.Primitives;

namespace McBonalds_MVC.Models
{
    public class Hamburguer : Produto
    {
        public Hamburguer()
        {

        }
        public Hamburguer(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}