using System.Collections.Generic;
namespace lanchonete.Models
{
    public class Telefone
    {
        public Telefone(){
            clientes = new HashSet<Cliente>();
            Filials = new HashSet<Filial>();
            Fornecedores = new HashSet<Fornecedor>();
            Funcionarios = new HashSet<Funcionario>();
            
        }
        public int Id { get; set; }
        public string numenumeroro { get; set; } 

        public ICollection<Cliente> clientes { get; set; }
        public ICollection<Filial> Filials { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}