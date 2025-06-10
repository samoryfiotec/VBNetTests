Imports System

Public Class PedidoValidator
    Public Function Validate(pedido As Pedido) As List(Of String)
        Dim errors As New List(Of String)()

        If pedido Is Nothing Then
            errors.Add("Pedido não pode ser nulo.")
            Return errors
        End If

        If pedido.Id <= 0 Then
            errors.Add("Id deve ser maior que zero.")
        End If

        If pedido.ClienteId <= 0 Then
            errors.Add("ClienteId deve ser maior que zero.")
        End If

        If pedido.Data = DateTime.MinValue Then
            errors.Add("Data do pedido é inválida.")
        End If

        If pedido.ValorTotal < 0 Then
            errors.Add("ValorTotal não pode ser negativo.")
        End If

        Return errors
    End Function
End Class
