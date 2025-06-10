Imports VBNet.Domain

Public Class ClienteRepository
    Implements IClienteRepository
    Public Function ObterPorId(id As Integer) As Cliente Implements IClienteRepository.ObterPorId
        ' Simulação de acesso a banco
        Return New Cliente(id, "Fulano", "fulano@email.com", "123456789", "Rua Exemplo, 123")
    End Function

End Class
