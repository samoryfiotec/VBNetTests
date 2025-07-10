Public Class DapperUnitOfWork
    Implements IUnityOfWork

    Private ReadOnly _connection As IDbConnection
    Private _transaction As IDbTransaction

    Public Sub New(connection As IDbConnection)
        _connection = connection
        _transaction = _connection.BeginTransaction()
    End Sub

    Public Async Function Commit() As Task Implements IUnityOfWork.Commit
        _transaction.Commit()
        Await Task.CompletedTask
    End Function

    Protected Overridable Sub Dispose(disposing As Boolean)
        If disposing Then
            If _transaction IsNot Nothing Then
                _transaction.Dispose()
                _transaction = Nothing
            End If
            If _connection IsNot Nothing Then
                _connection.Close()
                _connection.Dispose()
            End If
        End If
    End Sub
End Class
