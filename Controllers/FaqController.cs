using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class FaqController: AbstractController
    {
        public IActionResult Index2()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "FAQ",
                NomeView2 = "Nav1"
            });
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}