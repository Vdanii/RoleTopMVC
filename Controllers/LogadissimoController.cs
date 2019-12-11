using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class LogadissimoController : AbstractController
    {
        public IActionResult Index11()
        {
        
            return View(new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioSession() ,
                UsuarioNome = ObterUsuarioNomeSession(),
                NomeView = "Logadissimo",
                NomeView2 = "Nav2"
            });
        }

        public IActionResult Privacy()
        {
            return View ();
        }
    }
}