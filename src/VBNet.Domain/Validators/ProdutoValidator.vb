Public Class ProdutoValidator

    Public Function Validar(produto As Produto) As List(Of String)
        Dim erros As New List(Of String)()

        If String.IsNullOrWhiteSpace(produto.Nome) Then
            erros.Add("O nome do produto é obrigatório.")
        End If

        If produto.Preco < 0 Then
            erros.Add("O preço do produto não pode ser negativo.")
        End If

        If produto.QuantidadeEmEstoque < 0 Then
            erros.Add("A quantidade em estoque não pode ser negativa.")
        End If

        If String.IsNullOrWhiteSpace(produto.Categoria) Then
            erros.Add("A categoria do produto é obrigatória.")
        End If

        Return erros
    End Function

End Class
