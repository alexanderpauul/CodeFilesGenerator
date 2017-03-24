Imports System
Imports System.Data.SqlClient

Public Class Documentos
    Public Shared Function Add(value As Models.Documentos) As Integer
        Using cmd As New SqlCommand("General.Documentos_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@DocumentoId", value.DocumentoId))
         cmd.Parameters.Add(New SqlParameter("@DscDocumento", value.DscDocumento))
         cmd.Parameters.Add(New SqlParameter("@DscContacto", value.DscContacto))
         cmd.Parameters.Add(New SqlParameter("@TDocumentoId", value.TDocumentoId))
         cmd.Parameters.Add(New SqlParameter("@UsuarioId", value.UsuarioId))
         cmd.Parameters.Add(New SqlParameter("@FechaRegistro", value.FechaRegistro))
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

    Public Shared Function Edit(value As Models.Documentos) As Integer
        Using cmd As New SqlCommand("General.Documentos_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@DocumentoId", value.DocumentoId))
         cmd.Parameters.Add(New SqlParameter("@DscDocumento", value.DscDocumento))
         cmd.Parameters.Add(New SqlParameter("@DscContacto", value.DscContacto))
         cmd.Parameters.Add(New SqlParameter("@TDocumentoId", value.TDocumentoId))
         cmd.Parameters.Add(New SqlParameter("@UsuarioId", value.UsuarioId))
         cmd.Parameters.Add(New SqlParameter("@FechaRegistro", value.FechaRegistro))
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
        Using cmd As New SqlCommand("General.Documentos_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.Documentos
        Using cmd As New SqlCommand("General.Documentos_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Documentos = New Models.Documentos

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.DocumentoId = CType(drResultado("DocumentoId"), Integer)
                registro.DscDocumento = CType(drResultado("DscDocumento"), Integer)
                registro.DscContacto = CType(drResultado("DscContacto"), Integer)
                registro.TDocumentoId = CType(drResultado("TDocumentoId"), Integer)
                registro.UsuarioId = CType(drResultado("UsuarioId"), Integer)
                registro.FechaRegistro = CType(drResultado("FechaRegistro"), Integer)
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

    Public Shared Function GetByGUID(value As String) As Models.Documentos
        Using cmd As New SqlCommand("General.Documentos_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Documentos = New Models.Documentos

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.DocumentoId = CType(drResultado("DocumentoId"), Integer)
                registro.DscDocumento = CType(drResultado("DscDocumento"), Integer)
                registro.DscContacto = CType(drResultado("DscContacto"), Integer)
                registro.TDocumentoId = CType(drResultado("TDocumentoId"), Integer)
                registro.UsuarioId = CType(drResultado("UsuarioId"), Integer)
                registro.FechaRegistro = CType(drResultado("FechaRegistro"), Integer)
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

    Public Shared Function GetAll() As List(Of Models.Documentos)
        Using cmd As New SqlCommand("General.Documentos_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.Documentos) = New List(Of Models.Documentos)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.Documentos
                                    registro.DocumentoId = CType(drResultado("DocumentoId"), Integer)
                registro.DscDocumento = CType(drResultado("DscDocumento"), Integer)
                registro.DscContacto = CType(drResultado("DscContacto"), Integer)
                registro.TDocumentoId = CType(drResultado("TDocumentoId"), Integer)
                registro.UsuarioId = CType(drResultado("UsuarioId"), Integer)
                registro.FechaRegistro = CType(drResultado("FechaRegistro"), Integer)
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
