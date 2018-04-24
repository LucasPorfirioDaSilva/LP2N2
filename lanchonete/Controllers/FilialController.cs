using lanchonete.Data.Context;
using lanchonete.Models;

namespace lanchonete.Controllers
{
    public class FilialController : ControllerBase<Filial>
    {
        public FilialController(DataContext context) : base(context)
        {

        }
        
    }
}