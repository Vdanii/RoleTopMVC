using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class SobreNosController : Controller
    {
        public IActionResult Index1() {
            ViewData["NomeView"] = "SobreNos";
            return View();
        }
    }
}