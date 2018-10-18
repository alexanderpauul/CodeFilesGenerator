Imports System.Collections.Generic

Public Class TOrganismo
    Public Shared Function Add(value As Models.TOrganismo) As Integer
        Return Data.TOrganismo.Add(value)
    End Function

    Public Shared Function Edit(value As Models.TOrganismo) As Integer
        Return Data.TOrganismo.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.TOrganismo.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.TOrganismo
        Return Data.TOrganismo.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.TOrganismo
        Return Data.TOrganismo.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.TOrganismo)
        Return Data.TOrganismo.GetAll()
    End Function
End Class