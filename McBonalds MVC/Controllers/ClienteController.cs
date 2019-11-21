using System;
using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers {
    public class ClienteController : Controller 
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        [HttpGet]
        public IActionResult Login() 
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try 
            {
                System.Console.WriteLine ("===================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                System.Console.WriteLine ("===================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.Obterpor(usuario);

                if (cliente != null)
                {
                    if(cliente.Email.Equals(usuario) && cliente.Senha.Equals(senha))
                    {
                        return View ("Historico", "Cliente");
                    }
                    else
                    {
                        return View ("Erro", new RespostaViewModel("Senha errada"));
                    }

                }
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));
                }
                return View("Sucesso");
            } 
            catch (Exception e) 
            {
                System.Console.WriteLine (e.StackTrace);
                return View("Deu ruim :(");
            }

        }
    }
}