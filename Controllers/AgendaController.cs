using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers
{
    public class AgendaController : AbstractController
    {
        public IActionResult Index0()
        {
            
            return View(new BaseViewModel()
            {
                NomeView = "Agenda",
                NomeView2 = "Nav1"
            }); 
        }

        public IActionResult Privacy()
        {
            return View ();
        }
    }
}