Imports System.Collections.Generic

Public Class AspNetUserClaim
    Public Shared Function Add(value As Models.AspNetUserClaim) As Integer
        Return Data.AspNetUserClaim.Add(value)
    End Function

    Public Shared Function Edit(value As Models.AspNetUserClaim) As Integer
        Return Data.AspNetUserClaim.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.AspNetUserClaim.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.AspNetUserClaim
        Return Data.AspNetUserClaim.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.AspNetUserClaim
        Return Data.AspNetUserClaim.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.AspNetUserClaim)
        Return Data.AspNetUserClaim.GetAll()
    End Function
End Class