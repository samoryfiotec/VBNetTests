Public Class Cliente
    Public Property Id As Integer
    Public Property Nome As String
    Public Property Email As String
    Public Property Telefone As String
    Public Property Endereco As String

    Public Sub New(id As Integer, nome As String, email As String, telefone As String, endereco As String)
        Me.Id = id
        Me.Nome = nome
        Me.Email = email
        Me.Telefone = telefone
        Me.Endereco = endereco
    End Sub
End Class

