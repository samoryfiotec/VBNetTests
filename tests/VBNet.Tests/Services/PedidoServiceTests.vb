Imports Moq
Imports NUnit.Framework
Imports VBNet.Domain
Imports VBNet.Infra
Imports VBNet.Service

<TestFixture>
Public Class PedidoServiceTests

    '<Test>
    'Public Sub ObterPedidoPorId_DeveRetornarPedido()
    '    ' Arrange
    '    Dim mockRepo = New Mock(Of IPedidoRepository)()
    '    Dim pedidoEsperado = New Pedido With {.Id = 1, .ClienteId = 1, .Data = DateTime.Now, .ValorTotal = 100D}
    '    mockRepo.Setup(Function(r) r.ObterPorId(1)).Returns(pedidoEsperado)

    '    Dim service = New PedidoService(mockRepo.Object)

    '    ' Act
    '    Dim pedido = service.ObterPedidoPorId(1)

    '    ' Assert
    '    Assert.AreEqual(1, pedido.Id)
    '    Assert.AreEqual(100D, pedido.ValorTotal)
    'End Sub

    <Test>
    Public Sub CriarPedido_ValorTotalInvalido_DeveLancarExcecao()
        ' Arrange
        Dim mockRepo = New Mock(Of IPedidoRepository)()
        Dim service = New PedidoService(mockRepo.Object)
        Dim pedidoInvalido = New Pedido(1, 1, DateTime.Now, 0D)

        ' Act & Assert
        Assert.Throws(Of Exception)(Sub() service.CriarPedido(pedidoInvalido))
    End Sub
End Class