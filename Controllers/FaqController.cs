using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class FaqController: Controller
    {
        public IActionResult Index2()
        {
            ViewData["NomeView"] = "FAQ";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}