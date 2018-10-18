Imports System
Imports System.Data.SqlClient

Public Class Personas
    Public Shared Function Add(value As Models.Personas) As Integer
        Using cmd As New SqlCommand("dbo.Personas_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@PersonaId", value.PersonaId))
         cmd.Parameters.Add(New SqlParameter("@Nombre", value.Nombre))
         cmd.Parameters.Add(New SqlParameter("@PrimerApellido", value.PrimerApellido))
         cmd.Parameters.Add(New SqlParameter("@SegundoApellido", value.SegundoApellido))
         cmd.Parameters.Add(New SqlParameter("@FechaNacimiento", value.FechaNacimiento))
         cmd.Parameters.Add(New SqlParameter("@PaisId", value.PaisId))
         cmd.Parameters.Add(New SqlParameter("@NacionalidadId", value.NacionalidadId))
         cmd.Parameters.Add(New SqlParameter("@SexoId", value.SexoId))
         cmd.Parameters.Add(New SqlParameter("@ECivilId", value.ECivilId))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@Registro", value.Registro))
         cmd.Parameters.Add(New SqlParameter("@Modificacion", value.Modificacion))
         cmd.Parameters.Add(New SqlParameter("@Identificador", value.Identificador))
         cmd.Parameters.Add(New SqlParameter("@EstadoId", value.EstadoId))



            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                Return CInt(cmd.ExecuteScalar())
            Catch ex As Exception
                Return 0
                Throw New Exception("Error: 0x0000PA")
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function Edit(value As Models.Personas) As Integer
        Using cmd As New SqlCommand("dbo.Personas_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@PersonaId", value.PersonaId))
         cmd.Parameters.Add(New SqlParameter("@Nombre", value.Nombre))
         cmd.Parameters.Add(New SqlParameter("@PrimerApellido", value.PrimerApellido))
         cmd.Parameters.Add(New SqlParameter("@SegundoApellido", value.SegundoApellido))
         cmd.Parameters.Add(New SqlParameter("@FechaNacimiento", value.FechaNacimiento))
         cmd.Parameters.Add(New SqlParameter("@PaisId", value.PaisId))
         cmd.Parameters.Add(New SqlParameter("@NacionalidadId", value.NacionalidadId))
         cmd.Parameters.Add(New SqlParameter("@SexoId", value.SexoId))
         cmd.Parameters.Add(New SqlParameter("@ECivilId", value.ECivilId))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@Registro", value.Registro))
         cmd.Parameters.Add(New SqlParameter("@Modificacion", value.Modificacion))
         cmd.Parameters.Add(New SqlParameter("@Identificador", value.Identificador))
         cmd.Parameters.Add(New SqlParameter("@EstadoId", value.EstadoId))



            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                Return 0
                Throw New Exception("Error: 0x0000NC")
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function Delete(value As String) As Integer
        Using cmd As New SqlCommand("dbo.Personas_Delete", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                Return cmd.ExecuteNonQuery
            Catch ex As Exception
                Return 0
                Throw New Exception("Error: 0x0000NR")
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function GetById(value As String) As Models.Personas
        Using cmd As New SqlCommand("dbo.Personas_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Personas = New Models.Personas

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.PersonaId = CType(drResultado("PersonaId"), Integer)
                registro.Nombre = CType(drResultado("Nombre"), Integer)
                registro.PrimerApellido = CType(drResultado("PrimerApellido"), Integer)
                registro.SegundoApellido = CType(drResultado("SegundoApellido"), Integer)
                registro.FechaNacimiento = CType(drResultado("FechaNacimiento"), Integer)
                registro.PaisId = CType(drResultado("PaisId"), Integer)
                registro.NacionalidadId = CType(drResultado("NacionalidadId"), Integer)
                registro.SexoId = CType(drResultado("SexoId"), Integer)
                registro.ECivilId = CType(drResultado("ECivilId"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.Registro = CType(drResultado("Registro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)
                registro.EstadoId = CType(drResultado("EstadoId"), Integer)


                End If

                Return registro
            Catch ex As Exception
                Return registro
                Throw New Exception("Error: 0x00000N", ex)
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function GetByGUID(value As String) As Models.Personas
        Using cmd As New SqlCommand("dbo.Personas_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Personas = New Models.Personas

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.PersonaId = CType(drResultado("PersonaId"), Integer)
                registro.Nombre = CType(drResultado("Nombre"), Integer)
                registro.PrimerApellido = CType(drResultado("PrimerApellido"), Integer)
                registro.SegundoApellido = CType(drResultado("SegundoApellido"), Integer)
                registro.FechaNacimiento = CType(drResultado("FechaNacimiento"), Integer)
                registro.PaisId = CType(drResultado("PaisId"), Integer)
                registro.NacionalidadId = CType(drResultado("NacionalidadId"), Integer)
                registro.SexoId = CType(drResultado("SexoId"), Integer)
                registro.ECivilId = CType(drResultado("ECivilId"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.Registro = CType(drResultado("Registro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)
                registro.EstadoId = CType(drResultado("EstadoId"), Integer)


                End If

                Return registro
            Catch ex As Exception
                Return registro
                Throw New Exception("Error: 0x00000N", ex)
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function

    Public Shared Function GetAll() As List(Of Models.Personas)
        Using cmd As New SqlCommand("dbo.Personas_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.Personas) = New List(Of Models.Personas)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.Personas
                                    registro.PersonaId = CType(drResultado("PersonaId"), Integer)
                registro.Nombre = CType(drResultado("Nombre"), Integer)
                registro.PrimerApellido = CType(drResultado("PrimerApellido"), Integer)
                registro.SegundoApellido = CType(drResultado("SegundoApellido"), Integer)
                registro.FechaNacimiento = CType(drResultado("FechaNacimiento"), Integer)
                registro.PaisId = CType(drResultado("PaisId"), Integer)
                registro.NacionalidadId = CType(drResultado("NacionalidadId"), Integer)
                registro.SexoId = CType(drResultado("SexoId"), Integer)
                registro.ECivilId = CType(drResultado("ECivilId"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.Registro = CType(drResultado("Registro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)
                registro.EstadoId = CType(drResultado("EstadoId"), Integer)


                    registros.Add(registro)
                End While

                Return registros
            Catch ex As Exception
                Return registros
                Throw New Exception("Error: 0x00000N", ex)
            Finally
                If Connection.Cnn.State = ConnectionState.Open Then
                    Connection.Cnn.Close()
                End If
            End Try
        End Using
    End Function
End Class
