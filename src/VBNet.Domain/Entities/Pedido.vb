Public Class Pedido
    Public Property Id As Integer

    Public Property ClienteId As Integer

    Public Property Data As DateTime

    Public Property ValorTotal As Decimal

    Public Sub New(id As Integer, clienteId As Integer, data As DateTime, valorTotal As Decimal)
        Me.Id = id
        Me.ClienteId = clienteId
        Me.Data = data
        Me.ValorTotal = valorTotal
    End Sub
End Class