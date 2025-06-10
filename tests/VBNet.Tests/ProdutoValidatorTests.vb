Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class ProdutoValidatorTests

    Private _validator As ProdutoValidator

    <SetUp>
    Public Sub SetUp()
        _validator = New ProdutoValidator()
    End Sub

    <Test>
    Public Sub Validar_ProdutoValido_DeveRetornarListaVazia()

        Dim produto = New Produto(1, "Produto Teste", 10.5D, 5, "Categoria Teste")

        Dim erros = _validator.Validar(produto)

        Assert.IsEmpty(erros)

    End Sub

    <Test>
    Public Sub Validar_NomeVazio_DeveRetornarErro()
        Dim produto = New Produto(1, "", 10.5D, 5, "Categoria Teste")

        Dim erros = _validator.Validar(produto)

        Assert.Contains("O nome do produto é obrigatório.", erros)
    End Sub

    <Test>
    Public Sub Validar_PrecoNegativo_DeveRetornarErro()
        Dim produto = New Produto(1, "Produto Teste", -10.5D, 5, "Categoria Teste")

        Dim erros = _validator.Validar(produto)

        Assert.Contains("O preço do produto não pode ser negativo.", erros)
    End Sub

    <Test>
    Public Sub Validar_QuantidadeNegativa_DeveRetornarErro()
        Dim produto = New Produto(1, "Produto Teste", 10.5D, -5, "Categoria Teste")

        Dim erros = _validator.Validar(produto)

        Assert.Contains("A quantidade em estoque não pode ser negativa.", erros)
    End Sub

    <Test>
    Public Sub Validar_CategoriaVazia_DeveRetornarErro()
        Dim produto = New Produto(1, "Produto Teste", 10.5D, 5, "")

        Dim erros = _validator.Validar(produto)

        Assert.Contains("A categoria do produto é obrigatória.", erros)
    End Sub

    <Test>
    Public Sub Validar_MultiplosErros_DeveRetornarTodosOsErros()
        Dim produto = New Produto(0, "", -10.5D, -5, "")

        Dim erros = _validator.Validar(produto)

        Assert.That(erros, Has.Member("O nome do produto é obrigatório."))
        Assert.That(erros, Has.Member("O preço do produto não pode ser negativo."))
        Assert.That(erros, Has.Member("A quantidade em estoque não pode ser negativa."))
        Assert.That(erros, Has.Member("A categoria do produto é obrigatória."))
        Assert.That(erros.Count, [Is].EqualTo(4))
    End Sub

End Class
