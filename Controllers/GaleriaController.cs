using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Galeria";
            return View();
        }

        public IActionResult Privacy()
        {
            return View ();
        }
    }
}