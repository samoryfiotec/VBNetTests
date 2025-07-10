Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class ProdutoTests

    <Test>
    Public Sub Produto_Construtor_DeveAtribuirPropriedadesCorretamente()
        ' Arrange & Act
        Dim produto As New Produto(1, "Mouse", 49.99D, 100, "Periféricos")

        ' Assert
        Assert.AreEqual(1, produto.Id)
        Assert.AreEqual("Mouse", produto.Nome)
        Assert.AreEqual(49.99D, produto.Preco)
        Assert.AreEqual(100, produto.QuantidadeEmEstoque)
        Assert.AreEqual("Periféricos", produto.Categoria)
    End Sub

    <Test>
    Public Sub Produto_PropriedadesPodemSerAlteradas()
        ' Arrange
        Dim produto As New Produto(0, "", 0D, 0, "")

        ' Act
        produto.Id = 2
        produto.Nome = "Monitor"
        produto.Preco = 599.99D
        produto.QuantidadeEmEstoque = 25
        produto.Categoria = "Hardware"

        ' Assert
        Assert.AreEqual(2, produto.Id)
        Assert.AreEqual("Monitor", produto.Nome)
        Assert.AreEqual(599.99D, produto.Preco)
        Assert.AreEqual(25, produto.QuantidadeEmEstoque)
        Assert.AreEqual("Hardware", produto.Categoria)
    End Sub

End Class
