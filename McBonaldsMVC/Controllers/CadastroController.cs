using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using McBonaldsMVC.Models;
using System;
namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    

        public IActionResult CadastrarCliente(IFormCollection form)
        {

            ViewData["Action"] = "Cadastro";
            try{
            
            Cliente cliente = new Cliente(form["nome"], form["endereco"], form["telefone"], form["senha"], form["email"], DateTime.Parse(form["data-nascimento"]));

            return View("Sucesso");
            
            }catch(Exception e)
            {
                return View("Erro");
            }
        }
    }
}