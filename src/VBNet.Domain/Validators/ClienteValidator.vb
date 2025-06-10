Imports System.Text.RegularExpressions

Public Class ClienteValidator
    Public Function Validar(cliente As Cliente) As List(Of String)
        Dim erros As New List(Of String)()

        If String.IsNullOrWhiteSpace(cliente.Nome) Then
            erros.Add("O nome é obrigatório.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Email) Then
            erros.Add("O e-mail é obrigatório.")
        ElseIf Not Regex.IsMatch(cliente.Email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            erros.Add("O e-mail informado é inválido.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Telefone) Then
            erros.Add("O telefone é obrigatório.")
        End If

        If String.IsNullOrWhiteSpace(cliente.Endereco) Then
            erros.Add("O endereço é obrigatório.")
        End If

        Return erros
    End Function
End Class
