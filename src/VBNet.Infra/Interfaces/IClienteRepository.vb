Imports VBNet.Domain

Public Interface IClienteRepository

    Function Listar() As List(Of Cliente)
    Function Obter(cliente As Cliente) As Cliente
    Function ObterPorId(id As Integer) As Cliente
    Sub Adicionar(cliente As Cliente)

End Interface
