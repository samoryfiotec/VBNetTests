Imports VBNet.Domain

Public Interface IClienteService

    Function BuscarClientes() As List(Of Cliente)
    Function BuscarClientePorNome(nome As String) As Cliente
    Function BuscarNomeDoCliente(id As Integer) As String
    Sub InserirCliente(cliente As Cliente)

End Interface
