Imports VBNet.Domain

Public Interface IPedidoRepository
    Function Listar() As List(Of Pedido)
    Function ObterPorId(id As Integer) As Pedido
    Sub Adicionar(pedido As Pedido)
End Interface
