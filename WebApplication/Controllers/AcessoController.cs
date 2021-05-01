using System;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication.Models.WebApplication.Cliente;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication.Controllers
{
    public class AcessoController : Controller
    {
        private readonly ClienteService _clienteService;

        public AcessoController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Login()
        {
            //_clienteService.ObterClientes();
            
            return View();
        }

        public IActionResult RecuperarConta()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }

}