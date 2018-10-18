Imports System
Imports System.Data.SqlClient

Public Class AspNetUserClaims
    Public Shared Function Add(value As Models.AspNetUserClaims) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUserClaims_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@Id", value.Id))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@ClaimType", value.ClaimType))
         cmd.Parameters.Add(New SqlParameter("@ClaimValue", value.ClaimValue))



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

    Public Shared Function Edit(value As Models.AspNetUserClaims) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUserClaims_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@Id", value.Id))
         cmd.Parameters.Add(New SqlParameter("@UserId", value.UserId))
         cmd.Parameters.Add(New SqlParameter("@ClaimType", value.ClaimType))
         cmd.Parameters.Add(New SqlParameter("@ClaimValue", value.ClaimValue))



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
        Using cmd As New SqlCommand("dbo.AspNetUserClaims_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.AspNetUserClaims
        Using cmd As New SqlCommand("dbo.AspNetUserClaims_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.AspNetUserClaims = New Models.AspNetUserClaims

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.Id = CType(drResultado("Id"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.ClaimType = CType(drResultado("ClaimType"), Integer)
                registro.ClaimValue = CType(drResultado("ClaimValue"), Integer)


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

    Public Shared Function GetByGUID(value As String) As Models.AspNetUserClaims
        Using cmd As New SqlCommand("dbo.AspNetUserClaims_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.AspNetUserClaims = New Models.AspNetUserClaims

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.Id = CType(drResultado("Id"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.ClaimType = CType(drResultado("ClaimType"), Integer)
                registro.ClaimValue = CType(drResultado("ClaimValue"), Integer)


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

    Public Shared Function GetAll() As List(Of Models.AspNetUserClaims)
        Using cmd As New SqlCommand("dbo.AspNetUserClaims_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.AspNetUserClaims) = New List(Of Models.AspNetUserClaims)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.AspNetUserClaims
                                    registro.Id = CType(drResultado("Id"), Integer)
                registro.UserId = CType(drResultado("UserId"), Integer)
                registro.ClaimType = CType(drResultado("ClaimType"), Integer)
                registro.ClaimValue = CType(drResultado("ClaimValue"), Integer)


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
