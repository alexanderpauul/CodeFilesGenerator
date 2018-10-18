Imports System.Collections.Generic

Public Class AspNetUserRol
    Public Shared Function Add(value As Models.AspNetUserRol) As Integer
        Return Data.AspNetUserRol.Add(value)
    End Function

    Public Shared Function Edit(value As Models.AspNetUserRol) As Integer
        Return Data.AspNetUserRol.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.AspNetUserRol.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.AspNetUserRol
        Return Data.AspNetUserRol.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.AspNetUserRol
        Return Data.AspNetUserRol.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.AspNetUserRol)
        Return Data.AspNetUserRol.GetAll()
    End Function
End Class