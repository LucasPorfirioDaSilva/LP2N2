using System.Collections.Generic;
namespace lanchonete.Models
{
    public class Filial
    {
        public Filial()
        {
            Pedidos = new HashSet<Pedido>();     
        }
        public int Id {get; set;}
        public Endereco Endereco {get; set;}
        public Telefone Telefone {get; set;}
        
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
