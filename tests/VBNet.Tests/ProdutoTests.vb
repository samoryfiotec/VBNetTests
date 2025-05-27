Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class ProdutoTests

    <Test>
    Public Sub Produto_PropriedadesDevemSerAtribuidasCorretamente()
        ' Arrange
        Dim produto As New Produto With {
            .Id = 10,
            .Nome = "Teclado",
            .Preco = 99.99D,
            .QuantidadeEmEstoque = 50,
            .Categoria = "Periféricos"
        }

        ' Assert
        Assert.AreEqual(10, produto.Id)
        Assert.AreEqual("Teclado", produto.Nome)
        Assert.AreEqual(99.99D, produto.Preco)
        Assert.AreEqual(50, produto.QuantidadeEmEstoque)
        Assert.AreEqual("Periféricos", produto.Categoria)
    End Sub

    <Test>
    Public Sub Produto_ValoresPadraoDevemSerPadraoDoTipo()
        ' Arrange
        Dim produto As New Produto()

        ' Assert
        Assert.AreEqual(0, produto.Id)
        Assert.IsNull(produto.Nome)
        Assert.AreEqual(0D, produto.Preco)
        Assert.AreEqual(0, produto.QuantidadeEmEstoque)
        Assert.IsNull(produto.Categoria)
    End Sub

End Class
