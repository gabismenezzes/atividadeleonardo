using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers.Admin
{
    
    public class AdminController : Controller
    {
        public AdminController()
        {
        }
        [Authorize]
        public IActionResult Supervisao()
        {
            return View();
        }
    }
}