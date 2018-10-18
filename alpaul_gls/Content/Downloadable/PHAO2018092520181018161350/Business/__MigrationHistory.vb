Imports System.Collections.Generic

Public Class __MigrationHistory
    Public Shared Function Add(value As Models.__MigrationHistory) As Integer
        Return Data.__MigrationHistory.Add(value)
    End Function

    Public Shared Function Edit(value As Models.__MigrationHistory) As Integer
        Return Data.__MigrationHistory.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.__MigrationHistory.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.__MigrationHistory
        Return Data.__MigrationHistory.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.__MigrationHistory
        Return Data.__MigrationHistory.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.__MigrationHistory)
        Return Data.__MigrationHistory.GetAll()
    End Function
End Class