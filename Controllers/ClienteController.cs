using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        public IActionResult Index6()
        {
            
            return View (new BaseViewModel()
            {
                UsuarioEmail = ObterUsuarioSession() ,
                UsuarioNome = ObterUsuarioNomeSession(),
                NomeView = "Cliente",
                NomeView2 = "Nav2"
            });
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}