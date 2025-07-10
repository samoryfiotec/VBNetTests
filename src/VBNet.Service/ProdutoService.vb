Imports VBNet.Domain

Public Class ProdutoService
    Implements IProdutoService

    Public Sub CriarProduto(produto As Produto) Implements IProdutoService.CriarProduto
        Throw New NotImplementedException()
    End Sub

    Public Function ListarProdutos() As List(Of Produto) Implements IProdutoService.ListarProdutos
        Throw New NotImplementedException()
    End Function

    Public Function ObterProdutoPorId(Id As Integer) As Produto Implements IProdutoService.ObterProdutoPorId
        Throw New NotImplementedException()
    End Function
End Class
