# LP2N2

Telefone {
    public long ID;
    public string Numero;
}

Endereço {
    public long ID;
    public string Rua;
    public string Cidade;
    public string Estado;
    public string País;
    public int Numero;
    public string Referencia;
}

Fornecedor {
    public long ID;
    public string Nome;
    public Telefone telefone;
}

Filial {
    public long ID;
    public Endereço endereço;
    public Telefone telefone;
}

Cliente {   
    public long ID;
    public string Nome;
    public Telefone telefone;
    public Endereço endereço;
}

Pedido{
    public long id ;
    public Funcionario funcionario FK;
    public Cliente cliente FK;
    public Filial filial FK;
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
    public Endereço endereço;
    public Telefone telefone ;
}