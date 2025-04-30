Imports VBNet.Domain
Imports VBNet.Infra

Public Class PedidoService
    Implements IPedidoService

    Private ReadOnly _repositorio As IPedidoRepository

    Public Sub New()
        _repositorio = New PedidoRepository()
    End Sub

    Public Sub New(repositorio As IPedidoRepository)
        _repositorio = repositorio
    End Sub

    Public Sub CriarPedido(pedido As Pedido) Implements IPedidoService.CriarPedido
        If pedido.ValorTotal <= 0 Then
            Throw New Exception("O valor total do pedido deve ser maior que zero.")
        End If
        _repositorio.Adicionar(pedido)
    End Sub

    Public Function ObterPedidoPorId(id As Integer) As Pedido Implements IPedidoService.ObterPedidoPorId
        Dim pedido = _repositorio.ObterPorId(id)
        If pedido Is Nothing Then
            Throw New Exception("Pedido não encontrado.")
        End If
        Return pedido
    End Function
End Class
