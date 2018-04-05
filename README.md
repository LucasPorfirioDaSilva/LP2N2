# LP2N2

Fornecedor {
    public long ID;
    public string Nome;
    public string telefone;
}

Pedido{
    public long id ;
    public Funcionario funcionario FK;
}

Produto {
    public long Id;
    public string Descricao;
    public string tipo ;
    public int qtde ;
    public Fornecedor fornecedor;
}

PedidoProduto {
    public long id ;
    public Pedido pedido FK;  
    public Produto produto FK;
    public int  pqtde ;
}

Funcionario {
    public long Id ;
    public string Nome ;
    public string telefone ;
}