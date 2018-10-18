Imports System.Collections.Generic

Public Class Organismo
    Public Shared Function Add(value As Models.Organismo) As Integer
        Return Data.Organismo.Add(value)
    End Function

    Public Shared Function Edit(value As Models.Organismo) As Integer
        Return Data.Organismo.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.Organismo.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.Organismo
        Return Data.Organismo.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Organismo
        Return Data.Organismo.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.Organismo)
        Return Data.Organismo.GetAll()
    End Function
End Class