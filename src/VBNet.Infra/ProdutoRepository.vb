Imports VBNet.Domain

Public Class ProdutoRepository
    Implements IProdutoRepository

    Private ReadOnly _produtos As New List(Of Produto)()

    Public Sub Adicionar(produto As Produto) Implements IProdutoRepository.Adicionar
        _produtos.Add(produto)
    End Sub

    Public Function Listar() As List(Of Produto) Implements IProdutoRepository.Listar
        Return _produtos.ToList()
    End Function

    Public Function ObterPorId(id As Integer) As Produto Implements IProdutoRepository.ObterPorId
        Return _produtos.FirstOrDefault(Function(p) p.Id = id)
    End Function
End Class
