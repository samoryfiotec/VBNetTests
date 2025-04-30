Imports VBNet.Domain

Public Class ClienteRepository
    Implements IClienteRepository
    Public Function ObterPorId(id As Integer) As Cliente Implements IClienteRepository.ObterPorId
        ' Simulação de acesso a banco
        Return New Cliente With {.Id = id, .Nome = "Fulano"}
    End Function

End Class
