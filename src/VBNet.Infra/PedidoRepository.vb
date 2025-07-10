Imports VBNet.Domain

Public Class PedidoRepository
    Implements IPedidoRepository

    Private ReadOnly _pedidos As New List(Of Pedido)()

    Public Sub Adicionar(pedido As Pedido) Implements IPedidoRepository.Adicionar
        _pedidos.Add(pedido)
    End Sub

    Public Function ObterPorId(id As Integer) As Pedido Implements IPedidoRepository.ObterPorId
        Return _pedidos.FirstOrDefault(Function(p) p.Id = id)
    End Function

    Public Function Listar() As List(Of Pedido) Implements IPedidoRepository.Listar
        Return _pedidos.ToList()
    End Function
End Class
