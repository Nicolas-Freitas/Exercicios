using System;
using McBonalds_MVC.Repositories;
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

                clienteRepository.Obterpor(usuario);



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