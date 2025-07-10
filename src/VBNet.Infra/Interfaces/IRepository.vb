Public Interface IRepository(Of T)
    Function [Get](connection As IDbConnection, Optional transaction As IDbTransaction = Nothing) As Task(Of IEnumerable(Of T))
    Function GetById(connection As IDbConnection, id As Object, Optional transaction As IDbTransaction = Nothing) As Task(Of T)
    Function Add(connection As IDbConnection, entity As T, Optional transaction As IDbTransaction = Nothing) As Task
    Function Update(connection As IDbConnection, entity As T, Optional transaction As IDbTransaction = Nothing) As Task
    Function Delete(connection As IDbConnection, id As Object, Optional transaction As IDbTransaction = Nothing) As Task
End Interface
