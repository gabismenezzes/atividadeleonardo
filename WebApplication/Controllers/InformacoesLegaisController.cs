using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication.Controllers
{
    public class InformacoesLegaisController
    {
        public InformacoesLegaisController(){
        }

        public IActionResult TermosDeUso()
        {   
            return View();
        }
        
        public IActionResult PoliticaDePrivacidade()
        {   
            return View();
        }
    }
}