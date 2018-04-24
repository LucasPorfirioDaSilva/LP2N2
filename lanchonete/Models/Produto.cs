using System.Collections.Generic;

namespace lanchonete.Models
{
    public class Produto
    {
        public Produto()
        {
            Detalhes = new HashSet<DetalhesPed>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }  
        public string tipo { get; set; }
        public double Preco { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
      
        public ICollection<DetalhesPed> Detalhes { get; set; }
    }
}