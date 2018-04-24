using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lanchonete.Models
{
    public class Fornecedor
    {
        public Fornecedor(){
            Produtos = new HashSet<Produto>();
        }

        public int Id {get; set;}
        public string Nome {get; set;}
        public Telefone telefone { get; set; }
        public Endereco endereço { get; set; }      
        public ICollection<Produto> Produtos {get; set;}

    }
}