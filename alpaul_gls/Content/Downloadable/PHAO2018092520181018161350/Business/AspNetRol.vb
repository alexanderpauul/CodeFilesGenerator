Imports System.Collections.Generic

Public Class AspNetRol
    Public Shared Function Add(value As Models.AspNetRol) As Integer
        Return Data.AspNetRol.Add(value)
    End Function

    Public Shared Function Edit(value As Models.AspNetRol) As Integer
        Return Data.AspNetRol.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.AspNetRol.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.AspNetRol
        Return Data.AspNetRol.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.AspNetRol
        Return Data.AspNetRol.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.AspNetRol)
        Return Data.AspNetRol.GetAll()
    End Function
End Class