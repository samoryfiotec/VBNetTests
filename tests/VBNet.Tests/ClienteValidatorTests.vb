Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class ClienteValidatorTests

    Private _validator As ClienteValidator

    <SetUp>
    Public Sub SetUp()
        _validator = New ClienteValidator()
    End Sub

    <Test>
    Public Sub Validar_TodosOsCamposValidos_DeveRetornarListaVazia()
        Dim cliente = New Cliente(1, "João", "joao@email.com", "11999999999", "Rua B, 456")
        Dim erros = _validator.Validar(cliente)
        Assert.IsEmpty(erros)
    End Sub

    <Test>
    Public Sub Validar_NomeVazio_DeveRetornarErroDeNome()
        Dim cliente = New Cliente(1, "", "joao@email.com", "11999999999", "Rua B, 456")
        Dim erros = _validator.Validar(cliente)
        Assert.Contains("O nome é obrigatório.", erros)
    End Sub

    <Test>
    Public Sub Validar_EmailVazio_DeveRetornarErroDeEmailObrigatorio()
        Dim cliente = New Cliente(1, "João", "", "11999999999", "Rua B, 456")
        Dim erros = _validator.Validar(cliente)
        Assert.Contains("O e-mail é obrigatório.", erros)
    End Sub

    <Test>
    Public Sub Validar_EmailInvalido_DeveRetornarErroDeEmailInvalido()
        Dim cliente = New Cliente(1, "João", "emailinvalido", "11999999999", "Rua B, 456")
        Dim erros = _validator.Validar(cliente)
        Assert.Contains("O e-mail informado é inválido.", erros)
    End Sub

    <Test>
    Public Sub Validar_TelefoneVazio_DeveRetornarErroDeTelefone()
        Dim cliente = New Cliente(1, "João", "joao@email.com", "", "Rua B, 456")
        Dim erros = _validator.Validar(cliente)
        Assert.Contains("O telefone é obrigatório.", erros)
    End Sub

    <Test>
    Public Sub Validar_EnderecoVazio_DeveRetornarErroDeEndereco()
        Dim cliente = New Cliente(1, "João", "joao@email.com", "11999999999", "")
        Dim erros = _validator.Validar(cliente)
        Assert.Contains("O endereço é obrigatório.", erros)
    End Sub

    <Test>
    Public Sub Validar_TodosOsCamposVazios_DeveRetornarTodosOsErros()
        Dim cliente = New Cliente(1, "", "", "", "")
        Dim erros = _validator.Validar(cliente)
        Assert.Contains("O nome é obrigatório.", erros)
        Assert.Contains("O e-mail é obrigatório.", erros)
        Assert.Contains("O telefone é obrigatório.", erros)
        Assert.Contains("O endereço é obrigatório.", erros)
        Assert.AreEqual(4, erros.Count)
    End Sub

End Class
