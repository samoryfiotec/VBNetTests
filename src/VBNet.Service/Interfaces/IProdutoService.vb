Imports VBNet.Domain

Public Interface IProdutoService

    Function ListarProdutos() As List(Of Produto)
    Function ObterProdutoPorId(Id As Integer) As Produto
    Sub CriarProduto(produto As Produto)

End Interface
