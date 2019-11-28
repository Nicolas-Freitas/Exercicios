using McBonalds_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using McBonalds_MVC.Repositories;
using System;
using McBonalds_MVC.ViewModels;

namespace McBonalds_MVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new BaseViewModels(){
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try{
            Cliente cliente = new Cliente(form["nome"], form["endereco"], form["telefone"], form["senha"], form["email"], DateTime.Parse(form["data-nascimento"]));
            System.Console.WriteLine(form["nome"]);

            clienteRepositorio.Inserir(cliente);
            return View("Sucesso");
            }catch (Exception e)
            {
                return View ("Erro"); 
            }
        }
    }
}