using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class ProdutosController : ControllerBase<Produto>
    {
        public ProdutosController(DataContext context) : base(context)
        {
        }
    }
}