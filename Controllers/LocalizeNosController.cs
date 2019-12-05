using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class LocalizeNosController : Controller
    {
       

        public IActionResult Index3()
        {
            ViewData["NomeView"] = "LocalizeNos";
            return View();
        }

        public IActionResult Privacy()
        {
            return View ();
        }
    }
}