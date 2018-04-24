using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class ClientesController : ControllerBase<Cliente>
    {
        public ClientesController(DataContext context) : base(context)
        {
        }
    }
}