using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class TelefoneController : ControllerBase<Telefone>
    {
        public TelefoneController(DataContext context) : base(context)
        {
        }
    }
}