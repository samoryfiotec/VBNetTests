Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class ClienteTests

    <Test>
    Public Sub Cliente_DevePermitirDefinirEObterPropriedades()
        ' Arrange
        Dim cliente As New Cliente(0, "", "", "", "")

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

    <Test>
    Public Sub Cliente_ConstrutorDeveAtribuirPropriedadesCorretamente()
        ' Arrange & Act
        Dim cliente As New Cliente(2, "Maria", "maria@email.com", "123456789", "Rua B, 456")

        ' Assert
        Assert.AreEqual(2, cliente.Id)
        Assert.AreEqual("Maria", cliente.Nome)
        Assert.AreEqual("maria@email.com", cliente.Email)
        Assert.AreEqual("123456789", cliente.Telefone)
        Assert.AreEqual("Rua B, 456", cliente.Endereco)
    End Sub

    <Test>
    Public Sub Cliente_TelefonePodeSerNulo()
        ' Arrange & Act
        Dim cliente As New Cliente(3, "Carlos", "carlos@email.com", Nothing, "Rua C, 789")

        ' Assert
        Assert.AreEqual(3, cliente.Id)
        Assert.AreEqual("Carlos", cliente.Nome)
        Assert.AreEqual("carlos@email.com", cliente.Email)
        Assert.IsNull(cliente.Telefone)
        Assert.AreEqual("Rua C, 789", cliente.Endereco)
    End Sub

End Class