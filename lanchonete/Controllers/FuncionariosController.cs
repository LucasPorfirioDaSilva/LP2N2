using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class FuncionariosController : ControllerBase<Funcionario>
    {
        public FuncionariosController(DataContext context) : base(context)
        {
        }
    }
}