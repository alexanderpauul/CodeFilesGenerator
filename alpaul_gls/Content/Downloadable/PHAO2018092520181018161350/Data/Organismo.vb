Imports System
Imports System.Data.SqlClient

Public Class Organismos
    Public Shared Function Add(value As Models.Organismos) As Integer
        Using cmd As New SqlCommand("dbo.Organismos_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@OrganismoId", value.OrganismoId))
         cmd.Parameters.Add(New SqlParameter("@DscOrganismo", value.DscOrganismo))
         cmd.Parameters.Add(New SqlParameter("@Sigla", value.Sigla))
         cmd.Parameters.Add(New SqlParameter("@URL", value.URL))
         cmd.Parameters.Add(New SqlParameter("@TOrganismoId", value.TOrganismoId))
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

    Public Shared Function Edit(value As Models.Organismos) As Integer
        Using cmd As New SqlCommand("dbo.Organismos_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@OrganismoId", value.OrganismoId))
         cmd.Parameters.Add(New SqlParameter("@DscOrganismo", value.DscOrganismo))
         cmd.Parameters.Add(New SqlParameter("@Sigla", value.Sigla))
         cmd.Parameters.Add(New SqlParameter("@URL", value.URL))
         cmd.Parameters.Add(New SqlParameter("@TOrganismoId", value.TOrganismoId))
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
        Using cmd As New SqlCommand("dbo.Organismos_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.Organismos
        Using cmd As New SqlCommand("dbo.Organismos_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Organismos = New Models.Organismos

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.OrganismoId = CType(drResultado("OrganismoId"), Integer)
                registro.DscOrganismo = CType(drResultado("DscOrganismo"), Integer)
                registro.Sigla = CType(drResultado("Sigla"), Integer)
                registro.URL = CType(drResultado("URL"), Integer)
                registro.TOrganismoId = CType(drResultado("TOrganismoId"), Integer)
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

    Public Shared Function GetByGUID(value As String) As Models.Organismos
        Using cmd As New SqlCommand("dbo.Organismos_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Organismos = New Models.Organismos

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.OrganismoId = CType(drResultado("OrganismoId"), Integer)
                registro.DscOrganismo = CType(drResultado("DscOrganismo"), Integer)
                registro.Sigla = CType(drResultado("Sigla"), Integer)
                registro.URL = CType(drResultado("URL"), Integer)
                registro.TOrganismoId = CType(drResultado("TOrganismoId"), Integer)
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

    Public Shared Function GetAll() As List(Of Models.Organismos)
        Using cmd As New SqlCommand("dbo.Organismos_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.Organismos) = New List(Of Models.Organismos)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.Organismos
                                    registro.OrganismoId = CType(drResultado("OrganismoId"), Integer)
                registro.DscOrganismo = CType(drResultado("DscOrganismo"), Integer)
                registro.Sigla = CType(drResultado("Sigla"), Integer)
                registro.URL = CType(drResultado("URL"), Integer)
                registro.TOrganismoId = CType(drResultado("TOrganismoId"), Integer)
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
