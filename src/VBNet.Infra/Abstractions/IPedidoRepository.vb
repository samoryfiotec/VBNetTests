Imports VBNet.Domain

Public Interface IPedidoRepository
    Function ObterPorId(id As Integer) As Pedido
    Sub Adicionar(pedido As Pedido)
End Interface
