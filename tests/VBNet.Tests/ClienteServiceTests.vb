Imports Moq
Imports NUnit.Framework
Imports VBNet.Domain
Imports VBNet.Infra
Imports VBNet.Service

<TestFixture>
Public Class ClienteServiceTests

    <Test>
    Public Sub BuscarNomeDoCliente_DeveRetornarNome()
        ' Arrange
        Dim mockRepo = New Mock(Of IClienteRepository)()
        Dim clienteEsperado = New Cliente(1, "Maria", "maria@email.com", "123456789", "Rua A, 123")
        mockRepo.Setup(Function(r) r.ObterPorId(1)).Returns(clienteEsperado)

        Dim service = New ClienteService(mockRepo.Object)

        ' Act
        Dim nome = service.BuscarNomeDoCliente(1)

        ' Assert
        Assert.AreEqual("Maria", nome)
    End Sub

    <Test>
    Public Sub BuscarNomeDoCliente_ClienteNaoEncontrado_DeveLancarExcecao()
        ' Arrange
        Dim mockRepo = New Mock(Of IClienteRepository)()
        mockRepo.Setup(Function(r) r.ObterPorId(99)).Returns(CType(Nothing, Cliente))

        Dim service = New ClienteService(mockRepo.Object)

        ' Act & Assert
        Assert.Throws(Of Exception)(Sub() service.BuscarNomeDoCliente(99))
    End Sub

End Class

