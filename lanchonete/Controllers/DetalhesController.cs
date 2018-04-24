using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class DetalhesController : ControllerBase<DetalhesPed>
    {
        public DetalhesController(DataContext context) : base(context)
        {
        }
    }
}