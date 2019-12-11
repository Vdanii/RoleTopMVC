using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class LocalizeNosController : AbstractController
    {
       

        public IActionResult Index3()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "LocalizeNos",
                NomeView2 = "Nav1"
            });
        }

        public IActionResult Privacy()
        {
            return View ();
        }
    }
}