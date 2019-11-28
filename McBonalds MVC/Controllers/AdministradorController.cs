using McBonalds_MVC.Repositories;
using McBonalds_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonalds_MVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        public IActionResult DashBoard()
        {
            var pedidos = pedidoRepository.ObterTodos ();
            DashBoardViewModel dashboardViewModel = new DashboardViewModel();

            foreach (var pedido in pedidos)
            {
                switch (pedido.Status)
                {
                    case (uint) StatusPedido.Pendente;
                    dashboardViewModel.PedidoPendentes++;
                    dashboar
                }
            }
        }
    }
}