Imports System.Collections.Generic

Public Class TEstado
    Public Shared Function Add(value As Models.TEstado) As Integer
        Return Data.TEstado.Add(value)
    End Function

    Public Shared Function Edit(value As Models.TEstado) As Integer
        Return Data.TEstado.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.TEstado.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.TEstado
        Return Data.TEstado.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.TEstado
        Return Data.TEstado.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.TEstado)
        Return Data.TEstado.GetAll()
    End Function
End Class