Imports VBNet.Domain

Public Interface IPedidoService

    Function ListarPedidos() As List(Of Pedido)
    Function ObterPedidoPorId(id As Integer) As Pedido
    Sub CriarPedido(pedido As Pedido)

End Interface
