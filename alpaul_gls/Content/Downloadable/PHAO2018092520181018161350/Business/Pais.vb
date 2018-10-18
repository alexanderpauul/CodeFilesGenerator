Imports System.Collections.Generic

Public Class Pais
    Public Shared Function Add(value As Models.Pais) As Integer
        Return Data.Pais.Add(value)
    End Function

    Public Shared Function Edit(value As Models.Pais) As Integer
        Return Data.Pais.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.Pais.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.Pais
        Return Data.Pais.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Pais
        Return Data.Pais.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.Pais)
        Return Data.Pais.GetAll()
    End Function
End Class