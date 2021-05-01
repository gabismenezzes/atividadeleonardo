using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication.Controllers
{
    public class AjudaController
    {
        public AjudaController(){
        }

        public IActionResult Index()
        {   
            return View();
        }
    }
}