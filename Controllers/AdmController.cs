
using RoleTopMVC.Enuns;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositorio;
using RoleTopMVC.ViewModels;
using RoleTopMVC.ViewsModels;

namespace RoleTopMVC.Controllers {
    public class AdministradorController : AbstractController 
    { 
        PedidoRepositorio pedidoRepository = new PedidoRepositorio ();
        public IActionResult Dashboard () {

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TipoUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) {

                var pedidos = pedidoRepository.ObterTodos ();
                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var pedido in pedidos) {
                    switch (pedido.Status) {
                        default:
                            dashboardViewModel.PedidosPendentes++;
                            dashboardViewModel.Pedidos.Add (pedido);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioTipoSession ();

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new MensagemViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard"
                });

            }
        }
    }
}