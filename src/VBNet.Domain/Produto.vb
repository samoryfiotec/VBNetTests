Public Class Produto

    Public Property Id As Integer
    Public Property Nome As String
    Public Property Preco As Decimal
    Public Property QuantidadeEmEstoque As Integer
    Public Property Categoria As String

    Public Sub New(id As Integer, nome As String, preco As Decimal, quantidadeEmEstoque As Integer, categoria As String)
        Me.Id = id
        Me.Nome = nome
        Me.Preco = preco
        Me.QuantidadeEmEstoque = quantidadeEmEstoque
        Me.Categoria = categoria
    End Sub

End Class
