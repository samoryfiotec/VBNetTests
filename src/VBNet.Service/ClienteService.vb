Imports VBNet.Infra

Public Class ClienteService
    Implements IClienteService

    Private ReadOnly _repositorio As IClienteRepository

    Public Sub New()
        _repositorio = New ClienteRepository()
    End Sub

    Public Sub New(repositorio As IClienteRepository)
        _repositorio = repositorio
    End Sub

    Public Sub InserirCliente(cliente As Domain.Cliente) Implements IClienteService.InserirCliente
        Throw New NotImplementedException()
    End Sub

    Public Function BuscarNomeDoCliente(id As Integer) As String Implements IClienteService.BuscarNomeDoCliente
        Dim cliente = _repositorio.ObterPorId(id)
        If cliente Is Nothing Then
            Throw New Exception("Cliente não encontrado.")
        End If
        Return cliente.Nome
    End Function

    Public Function BuscarClientes() As List(Of Domain.Cliente) Implements IClienteService.BuscarClientes
        Throw New NotImplementedException()
    End Function

    Public Function BuscarClientePorNome(nome As String) As Domain.Cliente Implements IClienteService.BuscarClientePorNome
        Throw New NotImplementedException()
    End Function
End Class
