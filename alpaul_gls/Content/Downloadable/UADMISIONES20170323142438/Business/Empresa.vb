Imports System.Collections.Generic

Public Class Empresa
    Public Shared Function Add(value As Models.Empresa) As Integer
        Return Data.Empresa.Add(value)
    End Function

    Public Shared Function Edit(value As Models.Empresa) As Integer
        Return Data.Empresa.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.Empresa.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.Empresa
        Return Data.Empresa.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Empresa
        Return Data.Empresa.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.Empresa)
        Return Data.Empresa.GetAll()
    End Function
End Class