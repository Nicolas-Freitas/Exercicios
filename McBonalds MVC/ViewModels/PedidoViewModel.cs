using System.Collections.Generic;
using McBonalds_MVC.Models;
namespace McBonalds_MVC.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get;set;}
        public string NomeUsuario {get; set;}
        public Cliente Cliente {get; set;}

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>();
            this.Shakes = new List<Shake>();
            this.NomeUsuario = "Jovem";
            this.Cliente = new Cliente();
        }
    }
}