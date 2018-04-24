using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class PedidosController : ControllerBase<Pedido>
    {
        public PedidosController(DataContext context) : base(context)
        {
        }
    }
}