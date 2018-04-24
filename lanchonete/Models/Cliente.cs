using System.Collections.Generic;

namespace lanchonete.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int TelefoneId { get; set; }
        public int EnderecoId { get; set; }
        public Telefone telefone {get; set; }
        public Endereco endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}