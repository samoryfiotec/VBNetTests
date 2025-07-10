Imports VBNet.Domain

Public Interface IProdutoRepository

    Function Listar() As List(Of Produto)
    Function ObterPorId(id As Integer) As Produto
    Sub Adicionar(produto As Produto)

End Interface
