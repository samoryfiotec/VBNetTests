Imports VBNet.Infra

Public Class ClienteService
    Implements IClienteService

    Private ReadOnly _repositorio As IClienteRepository ' Alterado para a interface

    Public Sub New()
        _repositorio = New ClienteRepository()
    End Sub

    Public Sub New(repositorio As IClienteRepository)
        _repositorio = repositorio
    End Sub

    Public Function BuscarNomeDoCliente(id As Integer) As String Implements IClienteService.BuscarNomeDoCliente
        Dim cliente = _repositorio.ObterPorId(id)
        If cliente Is Nothing Then
            Throw New Exception("Cliente não encontrado.")
        End If
        Return cliente.Nome
    End Function
End Class
