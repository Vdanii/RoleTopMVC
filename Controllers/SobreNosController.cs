using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class SobreNosController : AbstractController
    {
        public IActionResult Index1() {

            return View(new BaseViewModel()
            {
                NomeView = "SobreNos",
                NomeView2 = "Nav1"
            });
        }
    }
}