using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class EnderecoController : ControllerBase<Endereco>
    {
        public EnderecoController(DataContext context) : base(context)
        {
        }
    }
}