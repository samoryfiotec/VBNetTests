Imports NUnit.Framework

<TestFixture>
Public Class ClienteTests

    <Test>
    Public Sub Cliente_DevePermitirDefinirEObterPropriedades()
        ' Arrange
        Dim cliente As New Cliente()

        ' Act
        cliente.Id = 1
        cliente.Nome = "Jo�o"

        ' Assert
        Assert.AreEqual(1, cliente.Id)
        Assert.AreEqual("Jo�o", cliente.Nome)
    End Sub

End Class
