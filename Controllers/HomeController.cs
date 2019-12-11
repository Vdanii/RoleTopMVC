using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoleTopMVC.Models;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "Home",
                NomeView2 = "Nav1"
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
