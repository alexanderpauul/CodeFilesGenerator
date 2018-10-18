Imports System.Collections.Generic

Public Class AspNetUser
    Public Shared Function Add(value As Models.AspNetUser) As Integer
        Return Data.AspNetUser.Add(value)
    End Function

    Public Shared Function Edit(value As Models.AspNetUser) As Integer
        Return Data.AspNetUser.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.AspNetUser.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.AspNetUser
        Return Data.AspNetUser.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.AspNetUser
        Return Data.AspNetUser.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.AspNetUser)
        Return Data.AspNetUser.GetAll()
    End Function
End Class