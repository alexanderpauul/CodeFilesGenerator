Imports System.Collections.Generic

Public Class TProyecto
    Public Shared Function Add(value As Models.TProyecto) As Integer
        Return Data.TProyecto.Add(value)
    End Function

    Public Shared Function Edit(value As Models.TProyecto) As Integer
        Return Data.TProyecto.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.TProyecto.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.TProyecto
        Return Data.TProyecto.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.TProyecto
        Return Data.TProyecto.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.TProyecto)
        Return Data.TProyecto.GetAll()
    End Function
End Class