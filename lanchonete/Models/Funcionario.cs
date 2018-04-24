using System;
using System.Collections.Generic;

namespace lanchonete.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Pedidos = new HashSet<Pedido>();
              
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public int TelId { get; set; }
        public int EndId { get; set; }
        public Telefone telefone {get; set; }
        public Endereco endereco { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}