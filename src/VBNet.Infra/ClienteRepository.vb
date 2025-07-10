Imports VBNet.Domain

Public Class ClienteRepository
    Implements IClienteRepository

    Private ReadOnly _clientes As New List(Of Cliente)()

    Public Sub Adicionar(cliente As Cliente) Implements IClienteRepository.Adicionar
        _clientes.Add(cliente)
    End Sub

    Public Function ObterPorId(id As Integer) As Cliente Implements IClienteRepository.ObterPorId
        Return _clientes.FirstOrDefault(Function(p) p.Id = id)
    End Function

    Public Function Listar() As List(Of Cliente) Implements IClienteRepository.Listar
        Return _clientes.ToList()
    End Function

    Public Function Obter(cliente As Cliente) As Cliente Implements IClienteRepository.Obter
        Return _clientes.FirstOrDefault(Function(p) p.Nome = cliente.Nome)
    End Function
End Class
