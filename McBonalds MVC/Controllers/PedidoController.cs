using System;
using McBonalds_MVC.Models;
using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers {
    public class PedidoController : AbstractController {

        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository ();
        ShakeRepository shakeRepository = new ShakeRepository();

        ClienteRepository clienteRepository = new ClienteRepository();
        
        public IActionResult Index () {
            var hamburgueres = hamburguerRepository.ObterTodos ();
            PedidoViewModel pvm = new PedidoViewModel();
            pvm.Hamburgueres = hamburgueres;

            var shake = shakeRepository.ObterTodos ();
            pvm.Shakes = shake;

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }

            return View (pvm);
        }
        public IActionResult Registrar (IFormCollection form) {
            Pedido pedido = new Pedido ();

            Shake shake = new Shake ();
            shake.Nome = form["shake"];
            shake.Preco = shakeRepository.ObterPrecoDe(form["shake"]);

            pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer (nomeHamburguer, hamburguerRepository.ObterPrecoDe(nomeHamburguer));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente () {
                Nome = form["Nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            pedidoRepository.Inserir (pedido);

            return View ("Sucesso");
        }
    }
}