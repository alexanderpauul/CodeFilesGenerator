Imports System.Collections.Generic

Public Class Estado
    Public Shared Function Add(value As Models.Estado) As Integer
        Return Data.Estado.Add(value)
    End Function

    Public Shared Function Edit(value As Models.Estado) As Integer
        Return Data.Estado.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.Estado.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.Estado
        Return Data.Estado.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Estado
        Return Data.Estado.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.Estado)
        Return Data.Estado.GetAll()
    End Function
End Class