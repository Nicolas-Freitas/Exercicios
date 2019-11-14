using System;

namespace McBonalds_MVC.Models
{
    public class Pedido
    {
        public Cliente Cliente {get;set;}
        public Hamburger Hamburger {get;set;}
        public Shake Shake {get;set;}
        public DateTime DataDoPedido {get;set;}
        public double PrecoTotal{get;set;}
    }
}