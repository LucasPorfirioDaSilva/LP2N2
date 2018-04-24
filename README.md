# LP2N2
// XX = criar model e controller.
Telefone { XX
    public long ID;
    public string Numero;
}

Endereço { XX
    public long ID;
    public string Rua;
    public string Cidade;
    public string Estado;
    public string País;
    public int Numero;
    public string Referencia;
}

Filial { XX
    public long ID;
    public Endereço Endereço;
    public Telefone Telefone;
}

// conferir todas os models do projeto.

Fornecedor {
    public long ID;
    public string Nome;
    public Telefone Telefone;
    public Endereço Endereço;
}

Cliente {   
    public long ID;
    public string Nome;
    public int TelefoneId;
    public int EnderecoId;
    public Telefone Telefone;
    public Endereço Endereço;
}

Pedido{
    public long Id ;
    public Funcionario Funcionario FK;
    public Cliente Cliente FK;
    public Filial Filial FK;
}

Produto {
    public long Id;
    public string Descricao;
    public string Tipo ;
    public double Preco;
    public int Qtde ;
    public Fornecedor Fornecedor FK;
}

DetalhesPed {
    public long Id ;
    public int Pedidoid;
    public int Produtoid;
    public Pedido Pedido FK;  
    public Produto Produto FK;
    public int  Pqtde ;
}

Funcionario {
    public long Id ;
    public string Nome ;
    public Endereço Endereço;
    public Telefone Telefone ;
}