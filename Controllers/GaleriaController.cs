using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "Galeria",
                NomeView2 = "Nav1"
            });
        }

        public IActionResult Privacy()
        {
            return View ();
        }
    }
}