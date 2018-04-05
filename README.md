# LP2N2

Fornecedor {
    public long ID;
    public string Nome;
    public string telefone;
}

Pedido{
    public long id ;
    public int  fun_id ;
    public Funcionario funcionario FK;
    public int  pid  ;
    public Produto produto FK;
    public int  pqtde;
}

Produto {
    public long Id;
    public string Descricao;
    public string tipo ;
    public int qtde ;
}

PedidoProduto {
    public long id ;
    public long Pedidoid ;
    public Pedido pedido FK;
    public long Produtoid ;   
    public Produto produto FK;
    public int  pqtde ;
}

Funcionario {
    public long Id ;
    public string Nome ;
    public string telefone ;
}