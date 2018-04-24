using System.Collections.Generic;
namespace lanchonete.Models
{
    public class Endereco
    {
        public Endereco(){
            clientes = new HashSet<Cliente>();
            Filials = new HashSet<Filial>();
            Fornecedores = new HashSet<Fornecedor>();
            Funcionarios = new HashSet<Funcionario>();     
        }
        
        public int Id { get; set; }
        public string Rua  { get; set; }
        public string Cidade  { get; set; }
        public string Estado  { get; set; }
        public string País  { get; set; }
        public int Numero  { get; set; }
        public string Referencia  { get; set; }

        public ICollection<Cliente> clientes { get; set; }
        public ICollection<Filial> Filials { get; set; }
        public ICollection<Fornecedor> Fornecedores { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}