using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index4()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}