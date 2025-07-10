Imports NUnit.Framework
Imports VBNet.Domain

<TestFixture>
Public Class PedidoTests

    '<Test>
    'Public Sub Pedido_DeveInicializarComValoresCorretos()
    '    ' Arrange
    '    Dim id As Integer = 1
    '    Dim clienteId As Integer = 123
    '    Dim data As DateTime = New DateTime(2023, 1, 1)
    '    Dim valorTotal As Decimal = 100.5D

    '    ' Act
    '    Dim pedido = New Pedido With {
    '        .Id = id,
    '        .ClienteId = clienteId,
    '        .Data = data,
    '        .ValorTotal = valorTotal
    '    }

    '    ' Assert
    '    Assert.AreEqual(id, pedido.Id)
    '    Assert.AreEqual(clienteId, pedido.ClienteId)
    '    Assert.AreEqual(data, pedido.Data)
    '    Assert.AreEqual(valorTotal, pedido.ValorTotal)
    'End Sub

    '<Test>
    'Public Sub Pedido_PropriedadesDevemSerAlteraveis()
    '    ' Arrange
    '    Dim pedido = New Pedido()

    '    ' Act
    '    pedido.Id = 2
    '    pedido.ClienteId = 456
    '    pedido.Data = New DateTime(2023, 2, 2)
    '    pedido.ValorTotal = 200.75D

    '    ' Assert
    '    Assert.AreEqual(2, pedido.Id)
    '    Assert.AreEqual(456, pedido.ClienteId)
    '    Assert.AreEqual(New DateTime(2023, 2, 2), pedido.Data)
    '    Assert.AreEqual(200.75D, pedido.ValorTotal)
    'End Sub

End Class
