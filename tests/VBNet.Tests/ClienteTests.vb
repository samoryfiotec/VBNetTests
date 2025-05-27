Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class ClienteTests

    <Test>
    Public Sub Cliente_DevePermitirDefinirEObterPropriedades()
        ' Arrange
        Dim cliente As New Cliente()

        ' Act
        cliente.Id = 1
        cliente.Nome = "João"
        cliente.Email = "joao@gmail.com"
        cliente.Telefone = Nothing ' Telefone é opcional
        cliente.Endereco = "Rua A, 123"

        ' Assert
        Assert.AreEqual(1, cliente.Id)
        Assert.AreEqual("João", cliente.Nome)
        Assert.AreEqual("joao@gmail.com", cliente.Email)
        Assert.IsNull(cliente.Telefone)
        Assert.AreEqual("Rua A, 123", cliente.Endereco)
    End Sub

End Class