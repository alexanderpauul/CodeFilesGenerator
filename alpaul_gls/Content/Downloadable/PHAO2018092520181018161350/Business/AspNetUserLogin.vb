Imports System.Collections.Generic

Public Class AspNetUserLogin
    Public Shared Function Add(value As Models.AspNetUserLogin) As Integer
        Return Data.AspNetUserLogin.Add(value)
    End Function

    Public Shared Function Edit(value As Models.AspNetUserLogin) As Integer
        Return Data.AspNetUserLogin.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.AspNetUserLogin.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.AspNetUserLogin
        Return Data.AspNetUserLogin.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.AspNetUserLogin
        Return Data.AspNetUserLogin.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.AspNetUserLogin)
        Return Data.AspNetUserLogin.GetAll()
    End Function
End Class