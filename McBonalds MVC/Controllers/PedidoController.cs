using System;
using McBonalds_MVC.Models;
using McBonalds_MVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers {
    public class PedidoController : Controller {

        PedidoRepository pedidoRepository = new PedidoRepository();
        public IActionResult Index () {
            return View ();
        }
        public IActionResult Registrar (IFormCollection form) {
            Pedido pedido = new Pedido ();

            Shake shake = new Shake ();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;
            pedido.Shake = shake;

            Hamburger hamburger = new Hamburger (form["hamburger"], 0.0);

            pedido.Hamburger = hamburger;

            Cliente cliente = new Cliente () {
                Nome = form["Nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]

            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = 0.0;

            pedidoRepository.Inserir (pedido);

            return View ("Sucesso");
        }
    }
}