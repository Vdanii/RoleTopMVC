using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index6()
        {
            ViewData["NomeView"] = "Cliente";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}