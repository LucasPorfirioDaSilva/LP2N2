using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class FornecedoresController : ControllerBase<Fornecedor>
    {
        public FornecedoresController(DataContext context) : base(context)
        {
        }
    }
}