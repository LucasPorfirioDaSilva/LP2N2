using System;

namespace lanchonete.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int FunId { get; set; }
        public int CliId { get; set; }
        public int FilId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public Filial Filial { get; set; }
    }
}