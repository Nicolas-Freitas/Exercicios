using System.Collections.Generic;

namespace McBonalds_MVC.ViewModels
{
    public class DashboardViewModel : BaseViewModels
    {
        public List<Pedidos> pedidos {get;set;}

        public uint PedidoAprovados {get;set;}
        public uint PedidoReprovados {get;set;}
        public uint PedidoPendentes {get;set;}

        public DashboardViewModel()
        {
            this.pedidos = new List<Pedidos>();
        }
        

    }
}