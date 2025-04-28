Imports NUnit.Framework

<TestFixture>
Public Class ClienteTests

    <Test>
    Public Sub Cliente_DevePermitirDefinirEObterPropriedades()
        ' Arrange
        Dim cliente As New Cliente()

        ' Act
        cliente.Id = 1
        cliente.Nome = "João"

        ' Assert
        Assert.AreEqual(1, cliente.Id)
        Assert.AreEqual("João", cliente.Nome)
    End Sub

End Class
