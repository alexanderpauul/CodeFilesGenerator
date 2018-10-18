Imports System.Collections.Generic

Public Class Persona
    Public Shared Function Add(value As Models.Persona) As Integer
        Return Data.Persona.Add(value)
    End Function

    Public Shared Function Edit(value As Models.Persona) As Integer
        Return Data.Persona.Edit(value)
    End Function

    Public Shared Function Delete(value As String) As Integer
        Return Data.Persona.Delete(value)
    End Function

    Public Shared Function GetById(value As String) As Models.Persona
        Return Data.Persona.GetById(value)
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Persona
        Return Data.Persona.GetByGUID(value)
    End Function

    Public Shared Function GetAll() As List(Of Models.Persona)
        Return Data.Persona.GetAll()
    End Function
End Class