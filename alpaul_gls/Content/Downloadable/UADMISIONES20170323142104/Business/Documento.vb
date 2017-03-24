Imports System.Collections.Generic

Public Class Documento
    Public Shared Function Add(value As Models.Documento) As Integer
        Return Data.Documento.Add(value)
    End Function

    Public Shared Function Edit(value As Models.Documento) As Integer
        Return Data.Documento.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.Documento.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.Documento
        Return Data.Documento.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Documento
        Return Data.Documento.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.Documento)
        Return Data.Documento.GetAll()
    End Function
End Class