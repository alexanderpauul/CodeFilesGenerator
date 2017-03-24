Imports System
Imports System.Data.SqlClient

Public Class Empresas
    Public Shared Function Add(value As Models.Empresas) As Integer
        Using cmd As New SqlCommand("Empresa.Empresas_Add", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@EmpresaId", value.EmpresaId))
         cmd.Parameters.Add(New SqlParameter("@AcadID", value.AcadID))
         cmd.Parameters.Add(New SqlParameter("@TEmpresaId", value.TEmpresaId))
         cmd.Parameters.Add(New SqlParameter("@DscEmpresa", value.DscEmpresa))
         cmd.Parameters.Add(New SqlParameter("@UsuarioId", value.UsuarioId))
         cmd.Parameters.Add(New SqlParameter("@FechaRegistro", value.FechaRegistro))
         cmd.Parameters.Add(New SqlParameter("@Modificacion", value.Modificacion))
         cmd.Parameters.Add(New SqlParameter("@Identificador", value.Identificador))
         cmd.Parameters.Add(New SqlParameter("@EstadoId", value.EstadoId))
         cmd.Parameters.Add(New SqlParameter("@PaisId", value.PaisId))



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

    Public Shared Function Edit(value As Models.Empresas) As Integer
        Using cmd As New SqlCommand("Empresa.Empresas_Edit", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
			         cmd.Parameters.Add(New SqlParameter("@EmpresaId", value.EmpresaId))
         cmd.Parameters.Add(New SqlParameter("@AcadID", value.AcadID))
         cmd.Parameters.Add(New SqlParameter("@TEmpresaId", value.TEmpresaId))
         cmd.Parameters.Add(New SqlParameter("@DscEmpresa", value.DscEmpresa))
         cmd.Parameters.Add(New SqlParameter("@UsuarioId", value.UsuarioId))
         cmd.Parameters.Add(New SqlParameter("@FechaRegistro", value.FechaRegistro))
         cmd.Parameters.Add(New SqlParameter("@Modificacion", value.Modificacion))
         cmd.Parameters.Add(New SqlParameter("@Identificador", value.Identificador))
         cmd.Parameters.Add(New SqlParameter("@EstadoId", value.EstadoId))
         cmd.Parameters.Add(New SqlParameter("@PaisId", value.PaisId))



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
        Using cmd As New SqlCommand("Empresa.Empresas_Delete", Connection.Cnn)
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

    Public Shared Function GetById(value As String) As Models.Empresas
        Using cmd As New SqlCommand("Empresa.Empresas_GetById", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Empresas = New Models.Empresas

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.EmpresaId = CType(drResultado("EmpresaId"), Integer)
                registro.AcadID = CType(drResultado("AcadID"), Integer)
                registro.TEmpresaId = CType(drResultado("TEmpresaId"), Integer)
                registro.DscEmpresa = CType(drResultado("DscEmpresa"), Integer)
                registro.UsuarioId = CType(drResultado("UsuarioId"), Integer)
                registro.FechaRegistro = CType(drResultado("FechaRegistro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)
                registro.EstadoId = CType(drResultado("EstadoId"), Integer)
                registro.PaisId = CType(drResultado("PaisId"), Integer)


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

    Public Shared Function GetByGUID(value As String) As Models.Empresas
        Using cmd As New SqlCommand("Empresa.Empresas_GetByGUID", Connection.Cnn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlParameter("@value", value))
            Dim drResultado As IDataReader = Nothing
            Dim registro As Models.Empresas = New Models.Empresas

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                If drResultado.Read Then
                                    registro.EmpresaId = CType(drResultado("EmpresaId"), Integer)
                registro.AcadID = CType(drResultado("AcadID"), Integer)
                registro.TEmpresaId = CType(drResultado("TEmpresaId"), Integer)
                registro.DscEmpresa = CType(drResultado("DscEmpresa"), Integer)
                registro.UsuarioId = CType(drResultado("UsuarioId"), Integer)
                registro.FechaRegistro = CType(drResultado("FechaRegistro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)
                registro.EstadoId = CType(drResultado("EstadoId"), Integer)
                registro.PaisId = CType(drResultado("PaisId"), Integer)


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

    Public Shared Function GetAll() As List(Of Models.Empresas)
        Using cmd As New SqlCommand("Empresa.Empresas_GetAll", Connection.Cnn)

            cmd.CommandType = CommandType.StoredProcedure
            Dim drResultado As IDataReader = Nothing
            Dim registros As List(Of Models.Empresas) = New List(Of Models.Empresas)

            Try
                If Connection.Cnn.State = ConnectionState.Closed Then
                    Connection.Cnn.Open()
                End If

                drResultado = cmd.ExecuteReader
                While drResultado.Read
                    Dim registro = New Models.Empresas
                                    registro.EmpresaId = CType(drResultado("EmpresaId"), Integer)
                registro.AcadID = CType(drResultado("AcadID"), Integer)
                registro.TEmpresaId = CType(drResultado("TEmpresaId"), Integer)
                registro.DscEmpresa = CType(drResultado("DscEmpresa"), Integer)
                registro.UsuarioId = CType(drResultado("UsuarioId"), Integer)
                registro.FechaRegistro = CType(drResultado("FechaRegistro"), Integer)
                registro.Modificacion = CType(drResultado("Modificacion"), Integer)
                registro.Identificador = CType(drResultado("Identificador"), Integer)
                registro.EstadoId = CType(drResultado("EstadoId"), Integer)
                registro.PaisId = CType(drResultado("PaisId"), Integer)


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
