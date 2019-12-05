using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index5(){
            ViewData["NomeView"] = "Login";
            return View();
        }
    }
}