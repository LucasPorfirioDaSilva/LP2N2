namespace lanchonete.Models
{
    public class DetalhesPed
    {
        public int id{get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }

}