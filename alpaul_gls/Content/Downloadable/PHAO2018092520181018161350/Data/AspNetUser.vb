Imports System
Imports System.Data.SqlClient

Public Class AspNetUsers
    Public Shared Function Add(value As Models.AspNetUsers) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUsers_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@Id", value.Id))
         cmd.Parameters.Add(New SqlParameter("@PersonaId", value.PersonaId))
         cmd.Parameters.Add(New SqlParameter("@IsDisable", value.IsDisable))
         cmd.Parameters.Add(New SqlParameter("@Email", value.Email))
         cmd.Parameters.Add(New SqlParameter("@EmailConfirmed", value.EmailConfirmed))
         cmd.Parameters.Add(New SqlParameter("@PasswordHash", value.PasswordHash))
         cmd.Parameters.Add(New SqlParameter("@SecurityStamp", value.SecurityStamp))
         cmd.Parameters.Add(New SqlParameter("@PhoneNumber", value.PhoneNumber))
         cmd.Parameters.Add(New SqlParameter("@PhoneNumberConfirmed", value.PhoneNumberConfirmed))
         cmd.Parameters.Add(New SqlParameter("@TwoFactorEnabled", value.TwoFactorEnabled))
         cmd.Parameters.Add(New SqlParameter("@LockoutEndDateUtc", value.LockoutEndDateUtc))
         cmd.Parameters.Add(New SqlParameter("@LockoutEnabled", value.LockoutEnabled))
         cmd.Parameters.Add(New SqlParameter("@AccessFailedCount", value.AccessFailedCount))
         cmd.Parameters.Add(New SqlParameter("@UserName", value.UserName))



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

    Public Shared Function Edit(value As Models.AspNetUsers) As Integer
        Using cmd As New SqlCommand("dbo.AspNetUsers_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@Id", value.Id))
         cmd.Parameters.Add(New SqlParameter("@PersonaId", value.PersonaId))
         cmd.Parameters.Add(New SqlParameter("@IsDisable", value.IsDisable))
         cmd.Parameters.Add(New SqlParameter("@Email", value.Email))
         cmd.Parameters.Add(New SqlParameter("@EmailConfirmed", value.EmailConfirmed))
         cmd.Parameters.Add(New SqlParameter("@PasswordHash", value.PasswordHash))
         cmd.Parameters.Add(New SqlParameter("@SecurityStamp", value.SecurityStamp))
         cmd.Parameters.Add(New SqlParameter("@PhoneNumber", value.PhoneNumber))
         cmd.Parameters.Add(New SqlParameter("@PhoneNumberConfirmed", value.PhoneNumberConfirmed))
         cmd.Parameters.Add(New SqlParameter("@TwoFactorEnabled", value.TwoFactorEnabled))
         cmd.Parameters.Add(New SqlParameter("@LockoutEndDateUtc", value.LockoutEndDateUtc))
         cmd.Parameters.Add(New SqlParameter("@LockoutEnabled", value.LockoutEnabled))
         cmd.Parameters.Add(New SqlParameter("@AccessFailedCount", value.AccessFailedCount))
         cmd.Parameters.Add(New SqlParameter("@UserName", value.UserName))



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
        Using cmd As New SqlCommand("dbo.AspNetUsers_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.AspNetUsers
        Using cmd As New SqlCommand("dbo.AspNetUsers_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.AspNetUsers = New Models.AspNetUsers

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.Id = CType(drResultado("Id"), Integer)
                registro.PersonaId = CType(drResultado("PersonaId"), Integer)
                registro.IsDisable = CType(drResultado("IsDisable"), Integer)
                registro.Email = CType(drResultado("Email"), Integer)
                registro.EmailConfirmed = CType(drResultado("EmailConfirmed"), Integer)
                registro.PasswordHash = CType(drResultado("PasswordHash"), Integer)
                registro.SecurityStamp = CType(drResultado("SecurityStamp"), Integer)
                registro.PhoneNumber = CType(drResultado("PhoneNumber"), Integer)
                registro.PhoneNumberConfirmed = CType(drResultado("PhoneNumberConfirmed"), Integer)
                registro.TwoFactorEnabled = CType(drResultado("TwoFactorEnabled"), Integer)
                registro.LockoutEndDateUtc = CType(drResultado("LockoutEndDateUtc"), Integer)
                registro.LockoutEnabled = CType(drResultado("LockoutEnabled"), Integer)
                registro.AccessFailedCount = CType(drResultado("AccessFailedCount"), Integer)
                registro.UserName = CType(drResultado("UserName"), Integer)


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

    Public Shared Function GetByGUID(value As String) As Models.AspNetUsers
        Using cmd As New SqlCommand("dbo.AspNetUsers_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.AspNetUsers = New Models.AspNetUsers

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.Id = CType(drResultado("Id"), Integer)
                registro.PersonaId = CType(drResultado("PersonaId"), Integer)
                registro.IsDisable = CType(drResultado("IsDisable"), Integer)
                registro.Email = CType(drResultado("Email"), Integer)
                registro.EmailConfirmed = CType(drResultado("EmailConfirmed"), Integer)
                registro.PasswordHash = CType(drResultado("PasswordHash"), Integer)
                registro.SecurityStamp = CType(drResultado("SecurityStamp"), Integer)
                registro.PhoneNumber = CType(drResultado("PhoneNumber"), Integer)
                registro.PhoneNumberConfirmed = CType(drResultado("PhoneNumberConfirmed"), Integer)
                registro.TwoFactorEnabled = CType(drResultado("TwoFactorEnabled"), Integer)
                registro.LockoutEndDateUtc = CType(drResultado("LockoutEndDateUtc"), Integer)
                registro.LockoutEnabled = CType(drResultado("LockoutEnabled"), Integer)
                registro.AccessFailedCount = CType(drResultado("AccessFailedCount"), Integer)
                registro.UserName = CType(drResultado("UserName"), Integer)


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

    Public Shared Function GetAll() As List(Of Models.AspNetUsers)
        Using cmd As New SqlCommand("dbo.AspNetUsers_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.AspNetUsers) = New List(Of Models.AspNetUsers)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.AspNetUsers
                                    registro.Id = CType(drResultado("Id"), Integer)
                registro.PersonaId = CType(drResultado("PersonaId"), Integer)
                registro.IsDisable = CType(drResultado("IsDisable"), Integer)
                registro.Email = CType(drResultado("Email"), Integer)
                registro.EmailConfirmed = CType(drResultado("EmailConfirmed"), Integer)
                registro.PasswordHash = CType(drResultado("PasswordHash"), Integer)
                registro.SecurityStamp = CType(drResultado("SecurityStamp"), Integer)
                registro.PhoneNumber = CType(drResultado("PhoneNumber"), Integer)
                registro.PhoneNumberConfirmed = CType(drResultado("PhoneNumberConfirmed"), Integer)
                registro.TwoFactorEnabled = CType(drResultado("TwoFactorEnabled"), Integer)
                registro.LockoutEndDateUtc = CType(drResultado("LockoutEndDateUtc"), Integer)
                registro.LockoutEnabled = CType(drResultado("LockoutEnabled"), Integer)
                registro.AccessFailedCount = CType(drResultado("AccessFailedCount"), Integer)
                registro.UserName = CType(drResultado("UserName"), Integer)


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
