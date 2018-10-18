Imports System
Imports System.Data.SqlClient

Public Class __MigrationHistory
    Public Shared Function Add(value As Models.__MigrationHistory) As Integer
        Using cmd As New SqlCommand("dbo.__MigrationHistory_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@MigrationId", value.MigrationId))
         cmd.Parameters.Add(New SqlParameter("@ContextKey", value.ContextKey))
         cmd.Parameters.Add(New SqlParameter("@Model", value.Model))
         cmd.Parameters.Add(New SqlParameter("@ProductVersion", value.ProductVersion))



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

    Public Shared Function Edit(value As Models.__MigrationHistory) As Integer
        Using cmd As New SqlCommand("dbo.__MigrationHistory_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@MigrationId", value.MigrationId))
         cmd.Parameters.Add(New SqlParameter("@ContextKey", value.ContextKey))
         cmd.Parameters.Add(New SqlParameter("@Model", value.Model))
         cmd.Parameters.Add(New SqlParameter("@ProductVersion", value.ProductVersion))



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
        Using cmd As New SqlCommand("dbo.__MigrationHistory_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.__MigrationHistory
        Using cmd As New SqlCommand("dbo.__MigrationHistory_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.__MigrationHistory = New Models.__MigrationHistory

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.MigrationId = CType(drResultado("MigrationId"), Integer)
                registro.ContextKey = CType(drResultado("ContextKey"), Integer)
                registro.Model = CType(drResultado("Model"), Integer)
                registro.ProductVersion = CType(drResultado("ProductVersion"), Integer)


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

    Public Shared Function GetByGUID(value As String) As Models.__MigrationHistory
        Using cmd As New SqlCommand("dbo.__MigrationHistory_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.__MigrationHistory = New Models.__MigrationHistory

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.MigrationId = CType(drResultado("MigrationId"), Integer)
                registro.ContextKey = CType(drResultado("ContextKey"), Integer)
                registro.Model = CType(drResultado("Model"), Integer)
                registro.ProductVersion = CType(drResultado("ProductVersion"), Integer)


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

    Public Shared Function GetAll() As List(Of Models.__MigrationHistory)
        Using cmd As New SqlCommand("dbo.__MigrationHistory_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.__MigrationHistory) = New List(Of Models.__MigrationHistory)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.__MigrationHistory
                                    registro.MigrationId = CType(drResultado("MigrationId"), Integer)
                registro.ContextKey = CType(drResultado("ContextKey"), Integer)
                registro.Model = CType(drResultado("Model"), Integer)
                registro.ProductVersion = CType(drResultado("ProductVersion"), Integer)


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
